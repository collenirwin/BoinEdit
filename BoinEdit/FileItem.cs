using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class FileItem : UserControl {

        BoinFile _file;

        public BoinFile file {
            get { return this._file; }
        }

        public FileItem() {
            InitializeComponent();
        }

        public FileItem(BoinFile file) {
            InitializeComponent();

            this._file = file;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.Text = "X";
            btnClose.ForeColor = Color.FromArgb(255, 250, 250, 250);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            //btnClose.Text = (_file.isSaved) ? "" : "○";
        }
    }
}
