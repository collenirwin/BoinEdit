using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BoinEditNS {
    public partial class DirTreeView : TreeView {

        #region Private Vars
        
        bool _hasDir = false;
        DirectoryInfo _directory;
        Color _dirColor  = Color.FromArgb(255, 60, 60, 60);
        Color _fileColor = Color.FromArgb(255, 74, 74, 74);
        
        string ioErrorMsg = "";
        const string _UNINITIALIZED = "uninit";

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
                
                this.ioErrorMsg = "";

                if (!search(this.directory, this.Nodes)) { // Start the DirSearcher
                    this.ioErrorMsg += " " + this.directory.Name + "\r\n";
                }
                
                if (this.ioErrorMsg != "") { // we had an error along the way
                    MessageBox.Show(
                        "Failed to open items in the following directories:\r\n" + 
                        ioErrorMsg,
                        Constants.CAPTION_ERROR
                    );
                }

                this._hasDir = true;
                return true;

            } else { // No directory yet
                this._hasDir = false;

                return false;
            }
        }

        /// <summary>
        /// Clears the current directory, setting DirTreeView.directory to null
        /// </summary>
        public void closeDir() {
            this.Nodes.Clear();
            this.directory = null;
            loadDir();
        }

        #endregion

        #region Private/Protected

        protected override void OnBeforeExpand(TreeViewCancelEventArgs e) {
            base.OnBeforeExpand(e);

            // if we have an uninitialized folder
            if (e.Node.Nodes.Count != 0 && e.Node.Nodes[0].Tag.ToString() == _UNINITIALIZED) {
                e.Node.Nodes.Clear();
                search(e.Node.Tag as DirectoryInfo, e.Node.Nodes); // populate subdir
            }
        }

        private bool search(DirectoryInfo dir, TreeNodeCollection nodes, bool recursive = false) {
            try {
                foreach (DirectoryInfo di in dir.GetDirectories()) {
                    if (di.Exists) {
                        TreeNode itm = new TreeNode();
                        itm.NodeFont = new Font(this.Font, FontStyle.Bold);
                        itm.ForeColor = Color.FromArgb(255, 150, 150, 150);
                        itm.Text = di.Name + "\\";
                        itm.Tag = di;
                        itm.BackColor = _dirColor;
                        

                        nodes.Add(itm);

                        itm.Text = di.Name + "\\"; // Hack required to redraw node correctly after making it bold

                        if (recursive) {
                            foreach (DirectoryInfo subDir in di.GetDirectories()) {
                                if (!search(subDir, itm.Nodes, true)) {
                                    ioErrorMsg += " " + subDir.Name + "\r\n";
                                }
                            }

                        } else {
                            addTempItem(di, itm.Nodes);
                        }
                    }
                }

                foreach (FileInfo fi in dir.GetFiles()) {
                    if (fi.Exists) {
                        TreeNode itm = new TreeNode();
                        itm.Text = fi.Name;
                        itm.Tag = fi;
                        itm.BackColor = _fileColor;

                        nodes.Add(itm);
                    }
                }

                return true;
            } catch {
                return false;
            }
        }

        // so we get the + button to indicate non-empty directory
        private void addTempItem(DirectoryInfo dir, TreeNodeCollection nodes) {
            try {
                // if the dir is not empty
                if (dir.GetDirectories().Length != 0 || dir.GetFiles().Length != 0) {
                    TreeNode node = new TreeNode();
                    node.Tag = _UNINITIALIZED;
                    node.Text = "...";
                    nodes.Add(node);
                }

            } catch {
                ioErrorMsg += " " + dir.Name + "\r\n";
            }
        }

        #endregion

        #endregion
    }
}
