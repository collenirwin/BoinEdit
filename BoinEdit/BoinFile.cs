using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FastColoredTextBoxNS;
using System.Windows.Forms;

namespace BoinEditNS {
    public class BoinFile {

        #region Private Vars

        string _name;
        string _path;
        string _content;
        bool _isSaved;
        bool _isOpen;

        //DirectoryInfo _parentDirInfo;
        FileInfo _fileInfo;

        #endregion

        #region Public Vars

        /// <summary>
        /// The filename
        /// </summary>
        public string name {
            get { return this._name; }
        }

        /// <summary>
        /// The path of the file
        /// </summary>
        public string path {
            get { return this._path; }
        }
        
        /// <summary>
        /// DirectoryInfo bject containing information on the file's parent directory
        /// </summary>
        public DirectoryInfo parentDirInfo {
            get { return this.parentDirInfo; }
        }

        /// <summary>
        /// FileInfo bject containing information on the file
        /// </summary>
        public FileInfo fileInfo {
            get { return this._fileInfo; }
        }

        /// <summary>
        /// The contents of the file
        /// </summary>
        public string content {
            get { return this._content; }
            set { this._content = value; }
        }

        /// <summary>
        /// Whether or not the file has new text
        /// </summary>
        public bool isSaved {
            get { return this._isSaved; }
            set { this._isSaved = value; }
        }

        /// <summary>
        /// Whether or not the content property is populated
        /// </summary>
        public bool isOpen {
            get { return this._isOpen; }
        }

        #endregion

        #region Constructor & Methods

        // Constructor
        public BoinFile(FileInfo fileInfo) {
            this._fileInfo = fileInfo;

            this._name = _fileInfo.Name;
            this._path = _fileInfo.FullName;
            this._content = ""; // Default to empty string

            this._isOpen = false;
            this._isSaved = true;
        }

        #region Saving


        /// <summary>
        /// Attempts to save the specified text to the BoinFile's path. No error handling done.
        /// </summary>
        /// <param name="text">Text to save</param>
        public void saveQuiet(string text) {
            using (StreamWriter W = File.CreateText(this._path)) {
                W.Write(text);
            }
        }

        /// <summary>
        /// Attempts to save the specified text to the BoinFile's path. Upon failure, hows a MessageBox with the exception.
        /// </summary>
        /// <param name="text">Text to save</param>
        /// <returns>false upon failure</returns>
        public bool saveAlert(string text) {
            string msg = "Failed to save " + _name + " with the following message:\r\n  ";

            try {
                saveQuiet(text);

                return true;

            } catch (IOException ex) { // IO specific exception
                msg += ex.Message;
            } catch (Exception ex) { // Any other error
                msg += ex.Message;
            }

            MessageBox.Show(msg, Constants.CAPTION_ERROR);
            return false;
        }

        #endregion

        #region Opening

        /// <summary>
        /// Opens the file and set BoinFile.content to its contents
        /// </summary>
        /// <returns>true if opened successfully (file exists)</returns>
        public bool open() {
            if (this._fileInfo.Exists) {
                using (StreamReader R = File.OpenText(this._fileInfo.FullName)) {
                    this._content = R.ReadToEnd();
                }

                this._isOpen = true;
                return true;
            } else {
                return false;
            }
        }

        #endregion

        #endregion
    }
}
