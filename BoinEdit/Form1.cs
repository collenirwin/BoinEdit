using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using FastColoredTextBoxNS;
using System.IO;

namespace BoinEditNS {
    public partial class Form1 : Form {

        #region Vars

        Dictionary<string, string> extensionMap = new Dictionary<string, string>();
        Dictionary<string, Language> languageMap = new Dictionary<string, Language>();

        #endregion

        #region Constructor & Form Events

        public Form1() {
            InitializeComponent();

            // Bracket highlight backcolor for when the caret is touching brackets
            txtMain.BracketsStyle  = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));
            txtMain.BracketsStyle2 = new MarkerStyle(new SolidBrush(Color.FromArgb(100, 86, 156, 214)));

            // Pairing file extensions with languages
            extensionMap.Add(".cs", "C#");
            extensionMap.Add(".html", "HTML");
            extensionMap.Add(".htm", "HTML");
            extensionMap.Add(".js", "JavaScript");
            extensionMap.Add(".lua", "Lua");
            extensionMap.Add(".php", "PHP");
            extensionMap.Add(".phtml", "PHP");
            extensionMap.Add(".phps", "PHP");
            extensionMap.Add(".sql", "SQL");
            extensionMap.Add(".vb", "Visual Basic");
            extensionMap.Add(".vbs", "Visual Basic");
            extensionMap.Add(".xml", "XML");
            extensionMap.Add(".rss", "XML");
            extensionMap.Add(".xsd", "XML");
            extensionMap.Add(".xslt", "XML");

            // For textbox language selection
            languageMap.Add("Plain Text", Language.Custom);
            languageMap.Add("C#", Language.CSharp);
            languageMap.Add("HTML", Language.HTML);
            languageMap.Add("JavaScript", Language.JS);
            languageMap.Add("Lua", Language.Lua);
            languageMap.Add("PHP", Language.PHP);
            languageMap.Add("SQL", Language.SQL);
            languageMap.Add("Visual Basic", Language.VB);
            languageMap.Add("XML", Language.XML);


            FileItem f = new FileItem();
            pnlOpenFiles.Controls.Add(f);
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;

            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;
            pnlOpenFiles.Controls.Add(new FileItem());
            pnlOpenFiles.Controls[pnlOpenFiles.Controls.Count - 1].Dock = DockStyle.Top;

        }

        #endregion

        #region SplitContainer Events & Related Methods

        private void splitContainerFull_SplitterMoved(object sender, SplitterEventArgs e) {
            txtMain.Focus();
        }

        #endregion

        #region ToolStrip Events & Related Methods

        #region File

        // Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            PrintDialogSettings pds = new PrintDialogSettings();
            pds.ShowPageSetupDialog = true; // Show a print preview dialog before printing
            txtMain.Print(pds);
        }

        // Exit
        private void tsiExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        #region Edit

        // Undo
        private void tsiUndo_Click(object sender, EventArgs e) {
            txtMain.Undo();
        }

        // Redo
        private void tsiRedo_Click(object sender, EventArgs e) {
            txtMain.Redo();
        }

        // Cut
        private void tsiCut_Click(object sender, EventArgs e) {
            txtMain.Cut();
        }

        // Copy
        private void tsiCopy_Click(object sender, EventArgs e) {
            txtMain.Copy();
        }

        // Paste
        private void tsiPaste_Click(object sender, EventArgs e) {
            txtMain.Paste();
        }

        #endregion

        #region View

        // Toggle SideBar
        private void tsiSideBar_Click(object sender, EventArgs e) {
            splitContainerFull.Panel1Collapsed = !tsiSideBar.Checked;
        }

        // Toggle Console
        private void tsiConsole_Click(object sender, EventArgs e) {
            splitContainerEditConsole.Panel2Collapsed = !tsiConsole.Checked;
        }

        #endregion

        #region FilePath

        // Attempt to open the path in windows explorer
        private void tsiFilePath_Click(object sender, EventArgs e) {
            string path = tsiFilePath.Tag.ToString();

            try {
                Process.Start("explorer.exe", path);
            } catch (Exception ex) {
                MessageBox.Show(
                    "Failed to open folder with the following message:\n  " +
                    ex.Message,
                    Constants.CAPTION_ERROR);
            }
        }

        #endregion

        #region Language

        // Change the language of the FCTB
        private void changeLanguage(string newLanguage) {
            bool hasLanguage = languageMap.ContainsKey(newLanguage);
            txtMain.Language = (hasLanguage) ? languageMap[newLanguage] : Language.Custom;
            tsiLanguage.Text = (hasLanguage) ? newLanguage : "Plain Text";

            txtMain.ClearStylesBuffer();
            txtMain.OnSyntaxHighlight(new TextChangedEventArgs(txtMain.Range));
        }

        private void languageTSI_Click(object sender, EventArgs e) {
            changeLanguage((sender as ToolStripMenuItem).Text);
        }

        #endregion

        #endregion

        private void toggleButtonText(BoinBoxNS.BoinBox button) {
            string buttonText = button.Text.Substring(1);
            button.Text = (button.Text.StartsWith("v")) ? ">" + buttonText : "v" + buttonText;
        }

        private void btnToggleOpenFiles_Click(object sender, EventArgs e) {
            pnlOpenFiles.Visible = !pnlOpenFiles.Visible;
            toggleButtonText(btnToggleOpenFiles);
        }

        private void btnToggleDir_Click(object sender, EventArgs e) {
            // TODO: Toggle listview here
            toggleButtonText(btnToggleDir);
        }
    }
}
