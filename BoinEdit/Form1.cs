using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class Form1 : Form {

        #region Vars

        FileItem activeFileItem;

        #endregion

        #region Constructor & Form Events

        public Form1() {
            InitializeComponent();

            // empty the new scratchfile dir
            Utils.purgeNewScratchFiles();

            // initialize all Dictionaries in Dict
            Dicts.init();

            // set colors for msMain
            msMain.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

            // add a new file
            addFile(newFile());
        }

        #region TextBox Events & Related Methods

        
        #endregion

        #region SplitContainer Events & Related Methods

        private void splitContainerFull_SplitterMoved(object sender, SplitterEventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Focus();
            }
        }

        #endregion

        #region ToolStrip Events & Related Methods

        #region File

        // New File
        private void tsiNew_Click(object sender, EventArgs e) {
            addFile(newFile());
        }

        // Open File
        private void tsiOpen_Click(object sender, EventArgs e) {
            ofdOpen.ShowDialog();
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

        // Save
        private void tsiSave_Click(object sender, EventArgs e) {
            checkSave(activeFileItem);
        }
        
        // Save As
        private void tsiSaveAs_Click(object sender, EventArgs e) {
            saveAsPrompt(activeFileItem);
        }

        // Save All
        private void tsiSaveAll_Click(object sender, EventArgs e) {
            saveAll();
        }

        // Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                PrintDialogSettings pds = new PrintDialogSettings();
                pds.ShowPageSetupDialog = true; // Show a print preview dialog before printing
                activeFileItem.editBox.textBox.Print(pds);
            }
           
        }

        // Exit
        private void tsiExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Edit

        // Undo
        private void tsiUndo_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Undo();
            }
        }

        // Redo
        private void tsiRedo_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Redo();
            }
        }

        // Cut
        private void tsiCut_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Cut();
            }
        }

        // Copy
        private void tsiCopy_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Copy();
            }
        }

        // Paste
        private void tsiPaste_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.Paste();
            }
        }

        // Find
        private void tsiFind_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.ShowFindDialog();
            }
        }

        // Find + Replace
        private void tsiFindReplace_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.ShowReplaceDialog();
            }
        }

        // Go To
        private void goToToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.textBox.ShowGoToDialog();
            }
        }

        // Comment Block
        private void commentBlockToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.commentBlock();
            }
        }

        // Uncomment Block
        private void uncommentBlockToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.unCommentBlock();
            }
        }

        // Tab Block In
        private void tabBlockInToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.tabBlockIn();
            }
        }

        // Tab Block Out
        private void tabBlockOutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (activeFileItem != null) {
                activeFileItem.editBox.tabBlockOut();
            }
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

                        FileItem fi = new FileItem(lstDir.SelectedNode.Tag as FileInfo, true);

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
                if (pnlOpenFiles.Controls.Count != 0) {
                    openFileItem(pnlOpenFiles.Controls[0] as FileItem);
                } else {
                    addFile(newFile());
                }
            }
        }

        #endregion

        #region FileItem Events

        private void fileItem_FileButtonClick(object sender, EventArgs e) {
            openFileItem(sender as FileItem);
        }

        #endregion

        #endregion

        #region File/Folder Methods

        #region Opening

        private void addFile(FileItem file, bool open = true) {
            if (file.isSaved) {
                foreach (Control c in pnlOpenFiles.Controls) {
                    var f = c as FileItem;
                    if ((f.file != null) && (file.file != null) && (f.file.FullName == file.file.FullName)) { // Already open
                        openFileItem(f); // open it into the editor
                        return;
                    }
                }
            }
            
            file.fileButtonClick += new EventHandler(fileItem_FileButtonClick);

            pnlOpenFiles.Controls.Add(file);
            file.Dock = DockStyle.Top;
            
            splitContainerEditConsole.Panel1.Controls.Add(file.editBox);
            file.editBox.Dock = DockStyle.Fill;

            if (open) {
                openFileItem(file);
            }
        }

        private void openFileItem(FileItem fi) {
            if (activeFileItem != null) {
                activeFileItem.close();
            }

            activeFileItem = fi;
            fi.open();
            fi.editBox.textBox.Select();
            fi.editBox.textBox.Focus();
        }

        private FileItem newFile() {
            return new FileItem(null, false);
        }

        private void ofdOpen_FileOk(object sender, CancelEventArgs e) {

            string error = "Could not open the following file(s):\r\n";
            bool errorFlag = false;
            int fileCount = pnlOpenFiles.Controls.Count;

            foreach (string path in ofdOpen.FileNames) {
                try {
                    addFile(new FileItem(new FileInfo(path), true));
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

        private void openFolder() {
            string prompt = "Opening a new folder will close the current one. Continue?";

            if (lstDir.hasDir && // if we have a directory open, and the user doesn't want to open a new one
                MessageBox.Show(prompt, Constants.CAPTION_DEFAULT, MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                return;
            }

            lstDir.openDir();
        }

        #endregion

        #region Saving

        private bool checkSave(FileItem fi) {
            if (fi != null && fi.file != null) { // save
                return fi.save(true);
            } else if (fi != null) { // save as
                return saveAsPrompt(fi);
            }

            return false;
        }

        private bool saveAsPrompt(FileItem fi) {
            if (fi != null) {
                sfdSave.FileName = fi.btnFile.Text;

                if (sfdSave.ShowDialog() == DialogResult.OK) {
                    return fi.saveAs(sfdSave.FileName, true);
                }
            }
            
            return false;
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

        #endregion
    }
}
