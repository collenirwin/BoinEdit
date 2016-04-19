using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class FileItem : UserControl {

        #region Private Vars

        BoinFile _file;
        bool _isOpen;

        Color _closeForeColor = Color.FromArgb(255, 74, 74, 74);
        Color _closeActiveForeColor = Color.FromArgb(255, 250, 250, 250);
        //Color _activeBackColor = Color.FromArgb(255, 86, 156, 214);
        Color _activeBackColor = Color.FromArgb(255, 74, 74, 74);

        Color _actualBackColor = Color.FromArgb(255, 60, 60, 60);

        #endregion

        #region Public Vars

        public BoinFile file {
            get { return this._file; }
        }

        public bool isOpen {
            get { return this._isOpen; }
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

        public FileItem(BoinFile file) {
            InitializeComponent();

            this._file = file;
            this.btnFile.Text = _file.name;

            this._actualBackColor = this.BackColor; // temp backcolor
        }

        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);

            this._actualBackColor = this.BackColor;
            this.btnClose.BackColor = this.BackColor;
            this.btnFile.BackColor = this.BackColor;
        }

        /// <summary>
        /// Opens the file into the specified FastColoredTextBox
        /// </summary>
        /// <param name="txtbox"></param>
        public void open(FastColoredTextBoxNS.FastColoredTextBox txtbox) {
            if (!this._file.isOpen) {
                this._file.open();
            }

            txtbox.Clear();
            txtbox.AppendText(this._file.content);

            this._isOpen = true;

            this.btnClose.BackColor = this._activeBackColor;
            this.btnFile.BackColor = this._activeBackColor;
        }

        /// <summary>
        /// Sets the backColor back to normal
        /// </summary>
        public void close() {
            if (this._isOpen) {
                this._isOpen = false;

                this.btnClose.BackColor = _actualBackColor;
                this.btnFile.BackColor = _actualBackColor;
            }
        }

        #endregion

        #region Private

        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.Text = "X";
            btnClose.ForeColor = closeActiveForeColor;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.Text = (_file.isSaved) ? "" : "■";
            btnClose.ForeColor = closeForeColor;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            if (!_file.isSaved) { // ask
                DialogResult result = MessageBox.Show(
                    "Save " + _file.name + " before closing?",
                    Constants.CAPTION_DEFAULT,
                    MessageBoxButtons.YesNoCancel
                );

                if (result == DialogResult.Yes) {

                    // close if file saved properly
                    if (_file.saveAlert()) {
                        this.Dispose();
                    }

                } else if (result == DialogResult.No) {
                    this.Dispose();
                } // else, don't do anything
            } else { // close
                this.Dispose();
            }
        }

        #endregion

        #endregion
    }
}
