using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace BoinEditNS {
    public partial class DirListView : ListView {

        public DirectoryInfo directory { get; set; }
        

        public DirListView() {

            // Setting defaults
            this.BorderStyle = BorderStyle.None;
            this.View = View.SmallIcon;
            this.AutoArrange = false;
            this.LabelWrap   = false;
            this.MultiSelect = false;
        }

        public void loadDir() {
            if (this.directory != null) { // If we have a directory

                search(this.directory);

            } else { // No directory yet
                this.Items.Add("Open Directory");
            }
        }

        private void search(DirectoryInfo dir) {
            try {

                foreach (DirectoryInfo di in dir.GetDirectories()) {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = di.Name;
                    itm.Tag = di;
                    itm.SubItems.Add("Hello");

                    this.Items.Add(itm);
                }

                foreach (FileInfo fi in dir.GetFiles()) {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = fi.Name;
                    itm.Tag = fi;
                    itm.BackColor = Color.Brown;

                    this.Items.Add(itm);
                }

            } catch (Exception ex) {
                MessageBox.Show(
                    "Failed to open " + dir.Name + " with the following message:\r\n  " +
                    ex.Message,
                    Constants.CAPTION_ERROR
                );
            }
        }

        private List<ListViewItem> subSearch(DirectoryInfo dir) {

            List<ListViewItem> lst = new List<ListViewItem>();

            foreach (DirectoryInfo di in dir.GetDirectories()) {
                ListViewItem itm = new ListViewItem();
                itm.Text = di.Name;
                itm.Tag = di;
                var subItems = subSearch(di);

                foreach (ListViewItem subItem in subItems) {
                    //itm.SubItems.Add(subItem);
                }
                

                lst.Add(itm);
            }

            foreach (FileInfo fi in dir.GetFiles()) {
                ListViewItem itm = new ListViewItem();
                itm.Text = fi.Name;
                itm.Tag = fi;
                itm.BackColor = Color.Brown;

                lst.Add(itm);
            }

            return lst;
        }
    }
}
