using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class Form1 : Form {

        #region Vars

        FileItem activeFileItem;
        DirectoryInfo scratchDirectory = new DirectoryInfo("scratch");

        #endregion

        #region Constructor & Form Events

        public Form1() {
            InitializeComponent();

            // Bracket highlight backcolor for when the caret is touching brackets
            txtMain.BracketsStyle  = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));
            txtMain.BracketsStyle2 = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));

            // Initialize all Dictionaries in Dict
            Dicts.init();
        }

        #region SplitContainer Events & Related Methods

        private void splitContainerFull_SplitterMoved(object sender, SplitterEventArgs e) {
            txtMain.Focus();
        }

        #endregion

        #region ToolStrip Events & Related Methods

        #region File

        // Open File
        private void tsiOpen_Click(object sender, EventArgs e) {
            ofdOpen.ShowDialog();
        }

        private void ofdOpen_FileOk(object sender, CancelEventArgs e) {

            string error = "Could not open the following file(s):\r\n";
            bool errorFlag = false;
            int fileCount = pnlOpenFiles.Controls.Count;

            foreach (string path in ofdOpen.FileNames) {
                try {
                    addFile(new FileItem(new BoinFile(new FileInfo(path))), false);
                } catch {
                    error += " " + path + "\r\n";
                    errorFlag = true;
                }
            }

            if (errorFlag) {
                MessageBox.Show(error, Constants.CAPTION_ERROR);
            }

            if (fileCount != pnlOpenFiles.Controls.Count) { // if we added file(s)
                openFileItem(pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1] as FileItem);
            }
        }

        // Open Folder
        private void tsiOpenFolder_Click(object sender, EventArgs e) {
            openFolder();
        }

        // Close Folder
        private void tsiCloseFolder_Click(object sender, EventArgs e) {
            lstDir.closeDir();
            lstDir.Nodes.Add("Open Directory");
        }

        private bool checkSave(FileItem fi) {
            if (fi.file.fileInfo != null && fi.file.fileInfo.Exists) {
                return fi.file.saveAlert();
            } else { // Prompt Save As
                sfdSave.ShowDialog();
                return true;
            }
        }

        // Save
        private void tsiSave_Click(object sender, EventArgs e) {
            checkSave(activeFileItem);
        }
        
        // Save As
        private void tsiSaveAs_Click(object sender, EventArgs e) {
            sfdSave.ShowDialog();
        }

        private void sfdSave_FileOk(object sender, CancelEventArgs e) {
            try {
                // TODO: sort out scratchfiles/new files
            } catch (Exception ex) {
                MessageBox.Show(
                    "Failed to save " + 
                    sfdSave.FileName + 
                    " with the following message:\r\n  " +
                    ex.Message,
                    Constants.CAPTION_ERROR
                );
            }
        }

        // Save All
        private void tsiSaveAll_Click(object sender, EventArgs e) {
            saveAll();
        }

        // Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            PrintDialogSettings pds = new PrintDialogSettings();
            pds.ShowPageSetupDialog = true; // Show a print preview dialog before printing
            txtMain.Print(pds);
        }

        // Exit
        private void tsiExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Edit

        // Undo
        private void tsiUndo_Click(object sender, EventArgs e) {
            txtMain.Undo();
        }

        // Redo
        private void tsiRedo_Click(object sender, EventArgs e) {
            txtMain.Redo();
        }

        // Cut
        private void tsiCut_Click(object sender, EventArgs e) {
            txtMain.Cut();
        }

        // Copy
        private void tsiCopy_Click(object sender, EventArgs e) {
            txtMain.Copy();
        }

        // Paste
        private void tsiPaste_Click(object sender, EventArgs e) {
            txtMain.Paste();
        }

        #endregion

        #region View

        // Toggle SideBar
        private void tsiSideBar_Click(object sender, EventArgs e) {
            splitContainerFull.Panel1Collapsed = !tsiSideBar.Checked;
        }

        // Toggle Console
        private void tsiConsole_Click(object sender, EventArgs e) {
            splitContainerEditConsole.Panel2Collapsed = !tsiConsole.Checked;
        }

        #endregion

        #region FilePath

        // Attempt to open the path in windows explorer
        private void tsiFilePath_Click(object sender, EventArgs e) {
            string path = tsiFilePath.Tag.ToString();

            try {
                Process.Start("explorer.exe", path);
            } catch (Exception ex) {
                MessageBox.Show(
                    "Failed to open folder with the following message:\n  " +
                    ex.Message,
                    Constants.CAPTION_ERROR);
            }
        }

        #endregion

        #region Language

        // Change the language of the FCTB
        private void changeLanguage(string newLanguage) {
            bool hasLanguage = Dicts.languageMap.ContainsKey(newLanguage);
            txtMain.Language = (hasLanguage) ? Dicts.languageMap[newLanguage] : Language.Custom;
            tsiLanguage.Text = (hasLanguage) ? newLanguage : "Plain Text";

            txtMain.ClearStylesBuffer();
            txtMain.OnSyntaxHighlight(new TextChangedEventArgs(txtMain.Range));
        }

        private void languageTSI_Click(object sender, EventArgs e) {
            changeLanguage((sender as ToolStripMenuItem).Text);
        }

        #endregion

        #endregion

        #region SideBar Events & Related Methods

        private void toggleButtonText(BoinBoxNS.BoinBox button) {
            string buttonText = button.Text.Substring(1); // Everything after 1st char
            button.Text = (button.Text.StartsWith("v")) ? ">" + buttonText : "v" + buttonText;
        }

        private void btnToggleOpenFiles_Click(object sender, EventArgs e) {
            pnlOpenFiles.Visible = !pnlOpenFiles.Visible;
            toggleButtonText(btnToggleOpenFiles);
        }

        private void btnToggleDir_Click(object sender, EventArgs e) {
            lstDir.Visible = !lstDir.Visible;
            toggleButtonText(btnToggleDir);
        }

        private void lstDir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (lstDir.SelectedNode != null) { // we have something selected

                if (!lstDir.hasDir) { // no dir
                    lstDir.openDir(); // show folder dialog

                } else if (!lstDir.SelectedNode.Text.EndsWith("\\")) { // file selected
                    try {
                        BoinFile bf = new BoinFile(lstDir.SelectedNode.Tag as FileInfo);
                        FileItem fi = new FileItem(bf);

                        addFile(fi);

                    } catch (Exception ex) { // failed to open file
                        MessageBox.Show(
                            "Failed to open " + lstDir.SelectedNode.Text + " with the following message:\r\n " +
                            ex.Message,
                            Constants.CAPTION_ERROR
                        );
                    }
                }
            }
        }

        // Closed a file
        private void pnlOpenFiles_ControlRemoved(object sender, ControlEventArgs e) {
            if (e.Control == activeFileItem) {
                txtMain.Clear();
            }
        }

        #endregion

        #endregion

        #region File/Folder Methods

        private void addFile(FileItem file, bool open = true) {
            foreach (Control c in pnlOpenFiles.Controls) {
                var f = c as FileItem;
                if (f != null && f.file.path == file.file.path) { // Already open
                    openFileItem(f); // open it into the editor
                    return;
                }
            }

            pnlOpenFiles.Controls.Add(file);
            file.Dock = DockStyle.Top;

            if (open) {
                openFileItem(file);
            }
        }

        private void openFileItem(FileItem fi) {
            if (activeFileItem != null) {
                activeFileItem.close();
            }

            fi.open(txtMain);
            activeFileItem = fi;

            txtMain.Focus();

            // set sytnax higlighting
            string ext = Path.GetExtension(activeFileItem.file.name);
            if (Dicts.extensionMap.ContainsKey(ext)) {
                changeLanguage(Dicts.extensionMap[ext]);
            } else {
                changeLanguage("");
            }
        }

        private void openFolder() {
            string prompt = "Opening a new folder will close the current one. Continue?";

            if (lstDir.hasDir && // if we have a directory open, and the user doesn't want to open a new one
                MessageBox.Show(prompt, Constants.CAPTION_DEFAULT, MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                return;
            }

            lstDir.openDir();
        }

        private void setScratch(FileItem fi) {
            fi.file.scratchFile = new FileInfo(scratchDirectory.FullName + "\\" + fi.btnFile.Text);
        }

        private void saveScratch(FileItem fi) {
            try {
                if (!Directory.Exists(scratchDirectory.FullName)) {
                    scratchDirectory.Create();
                }

                if (fi.file.scratchFile == null) {
                    setScratch(fi);
                }

                fi.file.saveToScratch();

            } catch (Exception ex) {
                MessageBox.Show(
                    "Failed to perform IO in BoinEdit's root directory. More specifically:\r\n  " +
                    ex.Message, 
                    Constants.CAPTION_ERROR
                );
            }
        }

        private void saveAll() {
            foreach (Control c in pnlOpenFiles.Controls) {
                FileItem fi = c as FileItem;

                if (!checkSave(fi)) {
                    break; // Stop if we encounter an error
                }
            }
        }

        #endregion
    }
}
