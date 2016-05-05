using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BoinEditNS {
    public class MenuColorTable : ProfessionalColorTable {

        Color lightGray = Color.FromArgb(255, 45, 45, 45);
        Color darkGray = Color.FromArgb(255, 25, 25, 25);

        public override Color MenuItemBorder {
            get { return lightGray; }
        }

        public override Color MenuItemSelectedGradientBegin {
            get { return lightGray; }
        }

        public override Color MenuItemSelectedGradientEnd {
            get { return lightGray; }
        }

        public override Color MenuItemPressedGradientBegin {
            get { return darkGray; }
        }

        public override Color MenuItemPressedGradientEnd {
            get { return darkGray; }
        }

        public override Color MenuBorder {
            get { return lightGray; }
        }
    }
}
