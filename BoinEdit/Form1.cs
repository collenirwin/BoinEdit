using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using FastColoredTextBoxNS;
using System.IO;

namespace BoinEditNS {
    public partial class Form1 : Form {

        #region Vars

        FileItem activeFileItem;

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

        private void openFileItem(FileItem fi) {
            if (activeFileItem != null) {
                activeFileItem.close();
            }

            fi.open(txtMain);
            activeFileItem = fi;
        }

        private void lstDir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (lstDir.SelectedNode != null) { // we have something selected

                if (!lstDir.hasDir) { // no dir
                    lstDir.openDir(); // show folder dialog

                } else if (!lstDir.SelectedNode.Text.EndsWith("\\")) { // file selected
                    try {
                        BoinFile bf = new BoinFile(lstDir.SelectedNode.Tag as FileInfo);
                        FileItem fi = new FileItem(bf);

                        foreach (Control c in pnlOpenFiles.Controls) {
                            var f = c as FileItem;
                            if (f != null && f.file.path == fi.file.path) { // Already open
                                openFileItem(f); // open it into the editor
                                return;
                            }
                        }

                        pnlOpenFiles.Controls.Add(fi);
                        fi.Dock = DockStyle.Top;

                        openFileItem(fi);

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

        #endregion

        #endregion
    }
}
