using FastColoredTextBoxNS;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class BoinEditBox : UserControl {

        #region Private Vars

        FileItem _fileItem;
        bool changeSaved = false;

        #endregion

        #region Public Vars

        FileItem fileItem {
            get { return  this._fileItem; }
            set { 
                this._fileItem = value;
                this.init();
            }
        }

        #endregion

        #region Constructor & init

        public BoinEditBox(FileItem fileItem) {
            InitializeComponent();
            this.fileItem = fileItem;
            this.changeSaved = true;

            // Bracket highlight backcolor for when the caret is touching brackets
            textBox.BracketsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));
            textBox.BracketsStyle2 = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));
            
            // For multiline comments
            textBox.HighlightingRangeType = HighlightingRangeType.AllTextRange;
        }

        public void init() {
            if (this.fileItem != null) {
                lblFileName.Text = this.fileItem.btnFile.Text;

                if (this.fileItem.file != null && File.Exists(this.fileItem.file.FullName)) {
                    btnPath.Text = this.fileItem.file.FullName; //this.fileItem.file.FullName.Replace("\\", " \\ ");
                } else {
                    btnPath.Text = "No directory yet";
                }

                // put the path button in the correct location based on the width of the file label
                btnPath.Left = lblFileName.Left + lblFileName.Width + 2;

                this.fileItem.setSaved(this.fileItem.isSaved);

                // show unsaved symbol if unsaved
                btnSave.Text = (fileItem.isSaved) ? "" : Constants.UNSAVED_SYMBOL;

                // set sytnax higlighting
                string ext = Path.GetExtension(fileItem.btnFile.Text);
                if (Dicts.extensionMap.ContainsKey(ext)) {
                    changeLanguage(Dicts.extensionMap[ext]);
                }

                textBox.Focus();
            }
        }

        #endregion

        #region TopBar

        private void btnPath_Click(object sender, EventArgs e) {
            string directory;
            if (this.fileItem.file != null && File.Exists(this.fileItem.file.FullName)) {
                directory = Path.GetDirectoryName(this.fileItem.file.FullName);

                try {
                    Process.Start("explorer.exe", directory);
                } catch (Exception ex) {
                    MessageBox.Show(
                        "Failed to open the specified directory with the following message:\r\n  " +
                        ex.Message,
                        Constants.CAPTION_ERROR
                    );
                }
            }

            textBox.Focus();
        }

        #endregion

        #region bottomBar

        #region Zoom

        private void tsiZoomItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem tsi = sender as ToolStripMenuItem;

            tsiZoom.Text = tsi.Text;
            textBox.Zoom = Convert.ToInt32(tsi.Text.Replace("%", ""));

            textBox.Focus();
        }

        private void textBox_ZoomChanged(object sender, EventArgs e) {
            tsiZoom.Text = textBox.Zoom.ToString() + "%";
        }

        #endregion

        #region Language

        // Change the language of the FCTB
        public void changeLanguage(string newLanguage) {
            bool hasLanguage = Dicts.languageMap.ContainsKey(newLanguage);

            if (hasLanguage) { // language supported
                textBox.Language = Dicts.languageMap[newLanguage];
                tsiLanguage.Text = newLanguage;
            } else { // set to plain text (no highlighting)
                textBox.Language = Language.Custom;
                tsiLanguage.Text = "Plain Text";
            }

            textBox.ClearStylesBuffer();
            textBox.OnSyntaxHighlight(new TextChangedEventArgs(textBox.Range));
        }

        private void tsiLanguageItem_Click(object sender, EventArgs e) {
            changeLanguage((sender as ToolStripMenuItem).Text);
            textBox.Focus();
        }

        #endregion

        #region TabSize

        private void tsiTabsItem_Click(object sender, EventArgs e) {
            string tabsize = (sender as ToolStripMenuItem).Text;
            tsiTabs.Text = "Tabsize: " + tabsize;
            this.textBox.TabLength = Convert.ToInt32(tabsize);
        }

        #endregion

        #endregion

        #region Context MenuStrip (Main)

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.ShowFindDialog();
        }

        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.ShowReplaceDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e) {
            this.textBox.ShowGoToDialog();
        }

        private void commentBlockToolStripMenuItem_Click(object sender, EventArgs e) {
            commentBlock();
        }

        private void uncommentBlockToolStripMenuItem_Click(object sender, EventArgs e) {
            unCommentBlock();
        }

        private void tabBlockInToolStripMenuItem_Click(object sender, EventArgs e) {
            tabBlockIn();
        }

        private void tabBlockOutToolStripMenuItem_Click(object sender, EventArgs e) {
            tabBlockOut();
        }

        #endregion

        #region btnSave

        private void btnSave_Click(object sender, EventArgs e) {
            fileItem.save(true);
            init();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e) {
            btnSave.Text = "";
            btnSave.BackgroundImage = Properties.Resources.appbar_save;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e) {
            btnSave.BackgroundImage = null;
            btnSave.Text = (fileItem.isSaved) ? "" : Constants.UNSAVED_SYMBOL;
        }

        #endregion

        #region textBox Stuff

        public void openFile(string path) {
            this.changeSaved = false;
            textBox.OpenFile(path);
            this.changeSaved = true;
        }

        private string replaceFirst(string text, string find, string replace) {
            int pos = text.IndexOf(find);
            if (pos < 0) {
                return text;
            }

            return text.Substring(0, pos) + replace + text.Substring(pos + find.Length);
        }

        private void prependSelected(string text, bool remove) {
            int selectStart = textBox.SelectionStart;
            string[] selectedText = textBox.SelectedText.Split('\n');
            string newText = "";
            for (int x = 0; x < selectedText.Length; x++) {
                if (remove) {
                    selectedText[x] = replaceFirst(selectedText[x], text, "");
                } else {
                    selectedText[x] = text + selectedText[x];
                }
                
                newText += selectedText[x];
            }

            newText = newText.Replace("\r", "\r\n");
            textBox.SelectedText = newText;
            textBox.SelectionStart = selectStart - ((remove) ? text.Length : 0);
            textBox.SelectionLength = newText.Length;
        }

        private string getTab() {
            string tab = "";
            for (int x = 0; x < textBox.TabLength; x++) {
                tab += " ";
            }

            return tab;
        }

        public void commentBlock() {
            prependSelected(textBox.CommentPrefix, false);
        }

        public void unCommentBlock() {
            prependSelected(textBox.CommentPrefix, true);
        }

        public void tabBlockIn() {
            prependSelected(getTab(), false);
        }

        public void tabBlockOut() {
            prependSelected(getTab(), true);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            if (changeSaved) {
                this.fileItem.setSaved(false);

                // show unsaved symbol if unsaved
                btnSave.Text = (fileItem.isSaved) ? "" : Constants.UNSAVED_SYMBOL;
            }
        }

        #endregion
    }
}
