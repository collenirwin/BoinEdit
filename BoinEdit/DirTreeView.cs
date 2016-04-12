using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.ComponentModel;

namespace BoinEditNS {
    public partial class DirTreeView : TreeView {

        #region Private Vars

        bool _hasDir = false;
        DirectoryInfo _directory;
        Color _dirColor  = Color.FromArgb(255, 60, 60, 60);
        Color _fileColor = Color.FromArgb(255, 74, 74, 74);

        #endregion

        #region Public Vars

        public bool hasDir {
            get { return this._hasDir; }
        }

        public DirectoryInfo directory {
            get { return this._directory; }
            set {
                this._directory = value;
                if (value != null && value.Exists) {
                    this._hasDir = true;
                }
            }
        }

        public Color dirColor {
            get { return  this._dirColor; }
            set { this._dirColor = value; }
        }

        public Color fileColor {
            get { return  this._fileColor; }
            set { this._fileColor = value; }
        }

        #endregion

        #region Methods

        #region Public

        /// <summary>
        /// Shows a FolderBrowserDialog to select a directory, then calls loadDir() with selected directory
        /// </summary>
        public void openDir() {
            var fbDailog = new Ionic.Utils.FolderBrowserDialogEx();
            fbDailog.Description = "Select a directory to open";
            fbDailog.ShowNewFolderButton = true;
            fbDailog.ShowEditBox = true;
            fbDailog.ShowFullPathInEditBox = true;

            DialogResult result = fbDailog.ShowDialog();

            if (result == DialogResult.OK) {
                this.directory = new DirectoryInfo(fbDailog.SelectedPath);
                loadDir();
            }
        }

        /// <summary>
        /// Loads all directories and files in DirTreeView.directory into the DirTreeView. 
        /// </summary>
        /// <returns>true if DirTreeView.directory is a valid DirectoryInfo</returns>
        public bool loadDir() {
            if (this.directory != null && this.directory.Exists) { // If we have a directory

                this.Nodes.Clear(); // Clear all nodes (we'll be adding some)

                search(this.directory, this.Nodes); // Start the DirSearcher
                this._hasDir = true;
                return true;

            } else { // No directory yet
                this._hasDir = false;

                return false;
            }
        }

        #endregion

        #region Private

        private bool search(DirectoryInfo dir, TreeNodeCollection nodes) {
            try {
                foreach (DirectoryInfo di in dir.GetDirectories()) {
                    if (di.Exists) {
                        TreeNode itm = new TreeNode();
                        itm.NodeFont = new Font(this.Font, FontStyle.Bold);
                        itm.Text = di.Name + "\\";
                        itm.Tag = di;
                        itm.BackColor = _dirColor;
                        

                        nodes.Add(itm);

                        itm.Text = di.Name + "\\"; // Hack required to redraw node correctly after making it bold

                        foreach (DirectoryInfo subDir in di.GetDirectories()) {
                            try {
                                search(subDir, itm.Nodes);
                            } catch { } // Fail silently; just don't add the directory
                        }
                    }
                }

                foreach (FileInfo fi in dir.GetFiles()) {
                    TreeNode itm = new TreeNode();
                    itm.Text = fi.Name;
                    itm.Tag = fi;
                    itm.BackColor = _fileColor;

                    nodes.Add(itm);
                }

                return true;

            } catch (Exception ex) {
                //MessageBox.Show(
                //    "Failed to open " + dir.Name + " with the following message:\r\n  " +
                //    ex.Message,
                //    Constants.CAPTION_ERROR
                //);

                return false;
            }
        }

        #endregion

        #endregion
    }
}
