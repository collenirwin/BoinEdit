using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BoinBoxNS {

    [ToolboxItem(true)]
    public partial class BoinBox : Button {

        bool antiAliased = false;

        public int BorderSize {
            get { return  this.FlatAppearance.BorderSize; }
            set { this.FlatAppearance.BorderSize = value; }
        }

        public Color BorderColor {
            get { return  this.FlatAppearance.BorderColor; }
            set { this.FlatAppearance.BorderColor = value; }
        }

        public Color MouseOverBackColor {
            get { return  this.FlatAppearance.MouseOverBackColor; }
            set { this.FlatAppearance.MouseOverBackColor = value; }
        }

        public Color MouseDownBackColor {
            get { return  this.FlatAppearance.MouseDownBackColor; }
            set { this.FlatAppearance.MouseDownBackColor = value; }
        }

        public bool AntiAliased {
            get { return  this.antiAliased; }
            set { this.antiAliased = value; }
        }

        public BoinBox() : base() {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(255, 45, 45, 45);
            this.ForeColor = Color.FromArgb(255, 250, 250, 250);
            this.Font = new Font("Calibri", 9, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (AntiAliased) {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            }

            base.OnPaint(e);
        }
    }
}
