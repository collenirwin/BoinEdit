using FastColoredTextBoxNS;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class FileItem : UserControl {

        #region Private Vars

        FileInfo _file;
        FileInfo _scratchFile;

        BoinEditBox _editBox;

        bool _isOpen;
        bool _isSaved;

        bool _scratchIOFailed = false;

        Color _closeForeColor = Color.FromArgb(255, 150, 150, 150);
        Color _closeActiveForeColor = Color.FromArgb(255, 250, 250, 250);
        Color _activeBackColor = Color.FromArgb(255, 74, 74, 74);

        Color _actualBackColor = Color.FromArgb(255, 60, 60, 60);

        #endregion

        #region Public Vars

        public event EventHandler fileButtonClick;
        public event EventHandler closeButtonClick;

        public FileInfo file {
            get { return this._file; }
        }

        public FileInfo scratchFile {
            get { return this._scratchFile; }
        }

        public BoinEditBox editBox {
            get { return this._editBox; }
        }

        public bool isOpen {
            get { return this._isOpen; }
        }

        public bool isSaved {
            get { return  this._isSaved; }
        }

        public Color closeForeColor {
            get { return  this._closeForeColor; }
            set { this._closeForeColor = value; }
        }

        public Color closeActiveForeColor {
            get { return this._closeActiveForeColor; }
            set { this._closeActiveForeColor = value; }
        }

        public Color activeBackColor {
            get { return this._activeBackColor; }
            set { this._activeBackColor = value; }
        }

        #endregion

        #region Constructor & Methods

        #region Public

        public FileItem(FileInfo file, bool isSaved) {
            InitializeComponent();

            this._isSaved = isSaved;

            if (isSaved) {
                this._file = file;
                this.btnFile.Text = file.Name;
                this._editBox = new BoinEditBox(this);

                // dispose self if we can't open the file
                if (!this.openFile()) {
                    this._dispose();
                    return;
                }

            } else {
                genFile();
            }

            this._actualBackColor = this.BackColor; // temp backcolor
            this.open();

            btnClose.Text = (this.isSaved) ? "" : Constants.UNSAVED_SYMBOL;
        }

        /// <summary>
        /// Shows FileItem.textBox, sets colors to active
        /// </summary>
        public void open() {
            if (!this.isOpen) {
                this._isOpen = true;

                this.editBox.Show();
                this.editBox.BringToFront();
                this.editBox.textBox.Select();
                this.editBox.textBox.Focus();

                this.btnClose.BackColor = this._activeBackColor;
                this.btnFile.BackColor = this._activeBackColor;
            }
        }

        /// <summary>
        /// Hides FileItem.textBox, sets colors to normal
        /// </summary>
        public void close() {
            if (this._isOpen) {
                this._isOpen = false;

                this.editBox.Hide();

                this.btnClose.BackColor = _actualBackColor;
                this.btnFile.BackColor  = _actualBackColor;
            }
        }

        /// <summary>
        /// Attempts to open FileItem.file contents into FileItem.textBox.Text
        /// </summary>
        /// <returns>true if opened successfully</returns>
        public bool openFile() {
            try {
                this.editBox.openFile(this.file.FullName);

                return true;
            } catch (Exception ex) {
                MessageBox.Show("Failed to open " + this.file.Name + " with the following message:\r\n  " + ex.Message, Constants.CAPTION_ERROR);

                return false;
            }
        }

        /// <summary>
        /// Attempts to save the FileItem.file
        /// </summary>
        /// <param name="alert">If true, alerts at failure</param>
        /// <returns>true if saved successfully</returns>
        public bool save(bool alert = false) {
            if (this.file != null) {
                if (!this._save(this.file.FullName)) {
                    if (alert) {
                        MessageBox.Show("Failed to save " + this.file.Name + ".", Constants.CAPTION_ERROR);
                    }

                    return false;
                }

                this.editBox.init();

            } else {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save As... - BoinEdit";
                sfd.FileName = this.btnFile.Text;
                sfd.AddExtension = false;

                if (sfd.ShowDialog() == DialogResult.OK) {
                    saveAs(sfd.FileName, true);
                }
            }
            
            return true;
        }

        /// <summary>
        /// Attempts to save FileItem.textBox.Text to a new path, then sets FileItem.file to the new file
        /// </summary>
        /// <param name="newPath">Path for new file</param>
        /// <param name="alert">If true, alerts at failure</param>
        /// <returns>true if saved successfully</returns>
        public bool saveAs(string newPath, bool alert = false) {
            if (!this._save(newPath)) {
                if (alert) {
                    MessageBox.Show("Failed to save " + newPath + ".", Constants.CAPTION_ERROR);
                }

                return false;
            }

            this._file = new FileInfo(newPath);
            this.btnFile.Text = this.file.Name;
            this.editBox.init();
            return true;
        }

        /// <summary>
        /// Attempts to save to FileItem.scratchFile, creates one if not already there
        /// </summary>
        /// <returns>true if saved successfully</returns>
        public bool saveScratch() {
            return genScratchFile(this.file.FullName, false);
        }

        /// <summary>
        /// Sets FileItem.isSaved, updates FileItem.btnClose.Text with the proper symbol
        /// </summary>
        public void setSaved(bool saved) {
            this._isSaved = saved;

            // what a hack, wow
            // this is needed because btnClose.Text won't draw otherwise
            btnClose_MouseEnter(this, new EventArgs());
            btnClose_MouseLeave(this, new EventArgs());
        }

        #endregion

        #region Private

        private bool _save(string path, bool changeSaved = true) {
            try {
                this.editBox.textBox.SaveToFile(path, Encoding.UTF8);
                if (changeSaved) {
                    this._isSaved = true;
                    btnClose.Text = "";
                }
                
                return true;
            } catch {
                return false;
            }
        }

        private void genFile() {
            string name = "untitled" + Utils.getUnnamedFileCount();
            this.btnFile.Text = name;
            this._editBox = new BoinEditBox(this);

            genScratchFile(name, true);
        }

        private bool genScratchFile(string fileNameOrPath, bool isNew) {
            DirectoryInfo scdir = (isNew) ? Utils.scratchNewDir : Utils.scratchDir;

            // make sure directory is created
            if (Utils.safeGenDir(scdir)) {

                // create a hashed filename/path
                string hashPath = scdir.FullName + "\\" + Utils.getHash(fileNameOrPath);

                // save to scratch dir
                if (!this._save(hashPath, false)) {
                    warnScratchIOFailed();
                    return false;
                }

                this._scratchFile = new FileInfo(hashPath);
                return true;
            }

            warnScratchIOFailed();
            return false;
        }

        private void warnScratchIOFailed() {

            // only warn once
            if (_scratchIOFailed) {
                MessageBox.Show("Warning: failed to create a scratchfile. This could mean that BoinEdit does not have read/write access to " +
                    Utils.scratchDir.FullName,
                    Constants.CAPTION_DEFAULT
                );

                _scratchIOFailed = true;
            }
        }

        #endregion

        #region Events & Event Overrides

        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);

            this._actualBackColor   = this.BackColor;
            this.btnClose.BackColor = this.BackColor;
            this.btnFile.BackColor  = this.BackColor;
        }

        private void btnFile_MouseEnter(object sender, EventArgs e) {
            if (this.file != null && this.file.Exists) {
                ttPath.SetToolTip(btnFile, this.file.FullName);
            } else {
                ttPath.RemoveAll();
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.Text = "X";
            btnClose.ForeColor = closeActiveForeColor;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.Text = (this.isSaved) ? "" : Constants.UNSAVED_SYMBOL;
            btnClose.ForeColor = closeForeColor;
        }

        private void _dispose() {
            this.editBox.Dispose();
            this.Dispose();
        }

        protected void btnClose_Click(object sender, EventArgs e) {
            if (this.closeButtonClick != null) {
                this.closeButtonClick(this, e);
            }

            // new unedited file, just delete it
            if (!this.isSaved && this.file == null && this.editBox.textBox.Text.Trim() == "") {
                this._dispose();
                return;
            }

            if (!this.isSaved) { // ask
                DialogResult result = MessageBox.Show(
                    "Save " + this.btnFile.Text + " before closing?",
                    Constants.CAPTION_DEFAULT,
                    MessageBoxButtons.YesNoCancel
                );

                if (result == DialogResult.Yes) {

                    // close if file saved properly
                    if (save(true)) {
                        this._dispose();
                    }

                } else if (result == DialogResult.No) {
                    this._dispose();
                } // else, don't do anything
            } else { // close
                this._dispose();
            }
        }

        protected void btnFile_Click(object sender, EventArgs e) {
            if (this.fileButtonClick != null) {
                this.fileButtonClick(this, e);
            }
        }

        #endregion

        #endregion
    }
}
