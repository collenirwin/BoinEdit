namespace BoinEditNS {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Open Directory");
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCloseFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFindReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSideBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPlainText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiJS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPHP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiVB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMainBase = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsTextEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerFull = new System.Windows.Forms.SplitContainer();
            this.lstDir = new BoinEditNS.DirTreeView();
            this.btnToggleDir = new BoinBoxNS.BoinBox();
            this.pnlOpenFiles = new System.Windows.Forms.Panel();
            this.btnToggleOpenFiles = new BoinBoxNS.BoinBox();
            this.splitContainerEditConsole = new System.Windows.Forms.SplitContainer();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainBase)).BeginInit();
            this.cmsTextEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).BeginInit();
            this.splitContainerFull.Panel1.SuspendLayout();
            this.splitContainerFull.Panel2.SuspendLayout();
            this.splitContainerFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditConsole)).BeginInit();
            this.splitContainerEditConsole.Panel1.SuspendLayout();
            this.splitContainerEditConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiEdit,
            this.tsiView,
            this.tsiSettings,
            this.tsiAbout,
            this.tsiLanguage,
            this.tsiFilePath});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.ShowItemToolTips = true;
            this.msMain.Size = new System.Drawing.Size(752, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNew,
            this.tsiOpen,
            this.tsiOpenFolder,
            this.tsiCloseFolder,
            this.toolStripSeparator1,
            this.tsiSave,
            this.tsiSaveAs,
            this.tsiSaveAll,
            this.toolStripSeparator5,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsiExit});
            this.tsiFile.ForeColor = System.Drawing.Color.Black;
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(37, 20);
            this.tsiFile.Text = "File";
            // 
            // tsiNew
            // 
            this.tsiNew.Name = "tsiNew";
            this.tsiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsiNew.Size = new System.Drawing.Size(214, 22);
            this.tsiNew.Text = "New File";
            // 
            // tsiOpen
            // 
            this.tsiOpen.Name = "tsiOpen";
            this.tsiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsiOpen.Size = new System.Drawing.Size(214, 22);
            this.tsiOpen.Text = "Open File";
            this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
            // 
            // tsiOpenFolder
            // 
            this.tsiOpenFolder.Name = "tsiOpenFolder";
            this.tsiOpenFolder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.tsiOpenFolder.Size = new System.Drawing.Size(214, 22);
            this.tsiOpenFolder.Text = "Open Folder";
            this.tsiOpenFolder.Click += new System.EventHandler(this.tsiOpenFolder_Click);
            // 
            // tsiCloseFolder
            // 
            this.tsiCloseFolder.Name = "tsiCloseFolder";
            this.tsiCloseFolder.Size = new System.Drawing.Size(214, 22);
            this.tsiCloseFolder.Text = "Close Folder";
            this.tsiCloseFolder.Click += new System.EventHandler(this.tsiCloseFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // tsiSave
            // 
            this.tsiSave.Name = "tsiSave";
            this.tsiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsiSave.Size = new System.Drawing.Size(214, 22);
            this.tsiSave.Text = "Save";
            this.tsiSave.Click += new System.EventHandler(this.tsiSave_Click);
            // 
            // tsiSaveAs
            // 
            this.tsiSaveAs.Name = "tsiSaveAs";
            this.tsiSaveAs.Size = new System.Drawing.Size(214, 22);
            this.tsiSaveAs.Text = "Save As...";
            this.tsiSaveAs.Click += new System.EventHandler(this.tsiSaveAs_Click);
            // 
            // tsiSaveAll
            // 
            this.tsiSaveAll.Name = "tsiSaveAll";
            this.tsiSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsiSaveAll.Size = new System.Drawing.Size(214, 22);
            this.tsiSaveAll.Text = "Save All";
            this.tsiSaveAll.Click += new System.EventHandler(this.tsiSaveAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(211, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(214, 22);
            this.tsiExit.Text = "Exit BoinEdit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // tsiEdit
            // 
            this.tsiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUndo,
            this.tsiRedo,
            this.toolStripSeparator4,
            this.tsiCut,
            this.tsiCopy,
            this.tsiPaste,
            this.toolStripSeparator3,
            this.tsiFind,
            this.tsiFindReplace,
            this.tsiGoTo});
            this.tsiEdit.ForeColor = System.Drawing.Color.Black;
            this.tsiEdit.Name = "tsiEdit";
            this.tsiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsiEdit.Text = "Edit";
            // 
            // tsiUndo
            // 
            this.tsiUndo.Name = "tsiUndo";
            this.tsiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsiUndo.Size = new System.Drawing.Size(195, 22);
            this.tsiUndo.Text = "Undo";
            this.tsiUndo.Click += new System.EventHandler(this.tsiUndo_Click);
            // 
            // tsiRedo
            // 
            this.tsiRedo.Name = "tsiRedo";
            this.tsiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsiRedo.Size = new System.Drawing.Size(195, 22);
            this.tsiRedo.Text = "Redo";
            this.tsiRedo.Click += new System.EventHandler(this.tsiRedo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // tsiCut
            // 
            this.tsiCut.Name = "tsiCut";
            this.tsiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsiCut.Size = new System.Drawing.Size(195, 22);
            this.tsiCut.Text = "Cut";
            this.tsiCut.Click += new System.EventHandler(this.tsiCut_Click);
            // 
            // tsiCopy
            // 
            this.tsiCopy.Name = "tsiCopy";
            this.tsiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsiCopy.Size = new System.Drawing.Size(195, 22);
            this.tsiCopy.Text = "Copy";
            this.tsiCopy.Click += new System.EventHandler(this.tsiCopy_Click);
            // 
            // tsiPaste
            // 
            this.tsiPaste.Name = "tsiPaste";
            this.tsiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsiPaste.Size = new System.Drawing.Size(195, 22);
            this.tsiPaste.Text = "Paste";
            this.tsiPaste.Click += new System.EventHandler(this.tsiPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // tsiFind
            // 
            this.tsiFind.Name = "tsiFind";
            this.tsiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsiFind.Size = new System.Drawing.Size(195, 22);
            this.tsiFind.Text = "Find";
            // 
            // tsiFindReplace
            // 
            this.tsiFindReplace.Name = "tsiFindReplace";
            this.tsiFindReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsiFindReplace.Size = new System.Drawing.Size(195, 22);
            this.tsiFindReplace.Text = "Find + Replace";
            // 
            // tsiGoTo
            // 
            this.tsiGoTo.Name = "tsiGoTo";
            this.tsiGoTo.Size = new System.Drawing.Size(195, 22);
            this.tsiGoTo.Text = "Go To...";
            // 
            // tsiView
            // 
            this.tsiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSideBar,
            this.tsiConsole});
            this.tsiView.ForeColor = System.Drawing.Color.Black;
            this.tsiView.Name = "tsiView";
            this.tsiView.Size = new System.Drawing.Size(44, 20);
            this.tsiView.Text = "View";
            // 
            // tsiSideBar
            // 
            this.tsiSideBar.Checked = true;
            this.tsiSideBar.CheckOnClick = true;
            this.tsiSideBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsiSideBar.Name = "tsiSideBar";
            this.tsiSideBar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsiSideBar.Size = new System.Drawing.Size(182, 22);
            this.tsiSideBar.Text = "Side Bar";
            this.tsiSideBar.Click += new System.EventHandler(this.tsiSideBar_Click);
            // 
            // tsiConsole
            // 
            this.tsiConsole.Checked = true;
            this.tsiConsole.CheckOnClick = true;
            this.tsiConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsiConsole.Name = "tsiConsole";
            this.tsiConsole.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.tsiConsole.Size = new System.Drawing.Size(182, 22);
            this.tsiConsole.Text = "Console";
            this.tsiConsole.Click += new System.EventHandler(this.tsiConsole_Click);
            // 
            // tsiSettings
            // 
            this.tsiSettings.ForeColor = System.Drawing.Color.Black;
            this.tsiSettings.Name = "tsiSettings";
            this.tsiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsiSettings.Text = "Settings";
            // 
            // tsiAbout
            // 
            this.tsiAbout.ForeColor = System.Drawing.Color.Black;
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsiAbout.Text = "About";
            // 
            // tsiLanguage
            // 
            this.tsiLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tsiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPlainText,
            this.tsiCSharp,
            this.tsiHTML,
            this.tsiJS,
            this.tsiLua,
            this.tsiPHP,
            this.tsiSQL,
            this.tsiVB,
            this.tsiXML});
            this.tsiLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.tsiLanguage.Name = "tsiLanguage";
            this.tsiLanguage.Size = new System.Drawing.Size(70, 20);
            this.tsiLanguage.Text = "Plain Text";
            this.tsiLanguage.ToolTipText = "Syntax Highlighting";
            // 
            // tsiPlainText
            // 
            this.tsiPlainText.Name = "tsiPlainText";
            this.tsiPlainText.Size = new System.Drawing.Size(135, 22);
            this.tsiPlainText.Text = "Plain Text";
            this.tsiPlainText.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiCSharp
            // 
            this.tsiCSharp.Name = "tsiCSharp";
            this.tsiCSharp.Size = new System.Drawing.Size(135, 22);
            this.tsiCSharp.Text = "C#";
            this.tsiCSharp.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiHTML
            // 
            this.tsiHTML.Name = "tsiHTML";
            this.tsiHTML.Size = new System.Drawing.Size(135, 22);
            this.tsiHTML.Text = "HTML";
            this.tsiHTML.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiJS
            // 
            this.tsiJS.Name = "tsiJS";
            this.tsiJS.Size = new System.Drawing.Size(135, 22);
            this.tsiJS.Text = "JavaScript";
            this.tsiJS.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiLua
            // 
            this.tsiLua.Name = "tsiLua";
            this.tsiLua.Size = new System.Drawing.Size(135, 22);
            this.tsiLua.Text = "Lua";
            this.tsiLua.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiPHP
            // 
            this.tsiPHP.Name = "tsiPHP";
            this.tsiPHP.Size = new System.Drawing.Size(135, 22);
            this.tsiPHP.Text = "PHP";
            this.tsiPHP.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiSQL
            // 
            this.tsiSQL.Name = "tsiSQL";
            this.tsiSQL.Size = new System.Drawing.Size(135, 22);
            this.tsiSQL.Text = "SQL";
            this.tsiSQL.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiVB
            // 
            this.tsiVB.Name = "tsiVB";
            this.tsiVB.Size = new System.Drawing.Size(135, 22);
            this.tsiVB.Text = "Visual Basic";
            this.tsiVB.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiXML
            // 
            this.tsiXML.Name = "tsiXML";
            this.tsiXML.Size = new System.Drawing.Size(135, 22);
            this.tsiXML.Text = "XML";
            this.tsiXML.Click += new System.EventHandler(this.languageTSI_Click);
            // 
            // tsiFilePath
            // 
            this.tsiFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tsiFilePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsiFilePath.ForeColor = System.Drawing.Color.Black;
            this.tsiFilePath.Name = "tsiFilePath";
            this.tsiFilePath.Size = new System.Drawing.Size(189, 20);
            this.tsiFilePath.Tag = "C:\\Users\\irwicj\\Desktop\\";
            this.tsiFilePath.Text = "C:\\Users\\irwicj\\Desktop\\File1.txt";
            this.tsiFilePath.ToolTipText = "Open in Windows Explorer";
            this.tsiFilePath.Click += new System.EventHandler(this.tsiFilePath_Click);
            // 
            // txtMainBase
            // 
            this.txtMainBase.AutoCompleteBrackets = true;
            this.txtMainBase.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtMainBase.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
            this.txtMainBase.AutoScrollMinSize = new System.Drawing.Size(27, 17);
            this.txtMainBase.BackBrush = null;
            this.txtMainBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtMainBase.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtMainBase.CharHeight = 17;
            this.txtMainBase.CharWidth = 8;
            this.txtMainBase.ContextMenuStrip = this.cmsTextEdit;
            this.txtMainBase.CurrentLineColor = System.Drawing.Color.Silver;
            this.txtMainBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainBase.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtMainBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMainBase.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtMainBase.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.txtMainBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtMainBase.IndentBackColor = System.Drawing.Color.Transparent;
            this.txtMainBase.IsReplaceMode = false;
            this.txtMainBase.LeftBracket = '(';
            this.txtMainBase.LeftBracket2 = '{';
            this.txtMainBase.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.txtMainBase.Location = new System.Drawing.Point(0, 0);
            this.txtMainBase.Name = "txtMainBase";
            this.txtMainBase.Paddings = new System.Windows.Forms.Padding(0);
            this.txtMainBase.PreferredLineWidth = 30;
            this.txtMainBase.RightBracket = ')';
            this.txtMainBase.RightBracket2 = '}';
            this.txtMainBase.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txtMainBase.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtMainBase.ServiceColors")));
            this.txtMainBase.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.txtMainBase.Size = new System.Drawing.Size(598, 266);
            this.txtMainBase.TabIndex = 0;
            this.txtMainBase.Visible = false;
            this.txtMainBase.Zoom = 100;
            // 
            // cmsTextEdit
            // 
            this.cmsTextEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator7,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.findToolStripMenuItem,
            this.findReplaceToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.cmsTextEdit.Name = "cmsTextEdit";
            this.cmsTextEdit.ShowImageMargin = false;
            this.cmsTextEdit.Size = new System.Drawing.Size(128, 192);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.tsiUndo_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.tsiRedo_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(124, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.tsiCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.tsiCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.tsiPaste_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(124, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findReplaceToolStripMenuItem
            // 
            this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
            this.findReplaceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.findReplaceToolStripMenuItem.Text = "Find + Replace";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.goToToolStripMenuItem.Text = "Go To...";
            // 
            // splitContainerFull
            // 
            this.splitContainerFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.splitContainerFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFull.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFull.Location = new System.Drawing.Point(0, 24);
            this.splitContainerFull.Name = "splitContainerFull";
            // 
            // splitContainerFull.Panel1
            // 
            this.splitContainerFull.Panel1.Controls.Add(this.lstDir);
            this.splitContainerFull.Panel1.Controls.Add(this.btnToggleDir);
            this.splitContainerFull.Panel1.Controls.Add(this.pnlOpenFiles);
            this.splitContainerFull.Panel1.Controls.Add(this.btnToggleOpenFiles);
            this.splitContainerFull.Panel1MinSize = 100;
            // 
            // splitContainerFull.Panel2
            // 
            this.splitContainerFull.Panel2.Controls.Add(this.splitContainerEditConsole);
            this.splitContainerFull.Panel2MinSize = 200;
            this.splitContainerFull.Size = new System.Drawing.Size(752, 370);
            this.splitContainerFull.SplitterDistance = 150;
            this.splitContainerFull.TabIndex = 2;
            this.splitContainerFull.TabStop = false;
            this.splitContainerFull.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerFull_SplitterMoved);
            // 
            // lstDir
            // 
            this.lstDir.BackColor = System.Drawing.SystemColors.Control;
            this.lstDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDir.dirColor = System.Drawing.SystemColors.Control;
            this.lstDir.directory = null;
            this.lstDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDir.fileColor = System.Drawing.SystemColors.Control;
            this.lstDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lstDir.Indent = 15;
            this.lstDir.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.lstDir.Location = new System.Drawing.Point(0, 45);
            this.lstDir.Name = "lstDir";
            treeNode1.Name = "nodOpenDir";
            treeNode1.Text = "Open Directory";
            this.lstDir.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.lstDir.Size = new System.Drawing.Size(150, 325);
            this.lstDir.TabIndex = 2;
            this.lstDir.TabStop = false;
            this.lstDir.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstDir_NodeMouseDoubleClick);
            // 
            // btnToggleDir
            // 
            this.btnToggleDir.AutoSize = true;
            this.btnToggleDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnToggleDir.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleDir.BorderSize = 0;
            this.btnToggleDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleDir.FlatAppearance.BorderSize = 0;
            this.btnToggleDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnToggleDir.Location = new System.Drawing.Point(0, 22);
            this.btnToggleDir.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.Name = "btnToggleDir";
            this.btnToggleDir.Size = new System.Drawing.Size(150, 23);
            this.btnToggleDir.TabIndex = 0;
            this.btnToggleDir.Text = "v Directory";
            this.btnToggleDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleDir.UseVisualStyleBackColor = false;
            this.btnToggleDir.Click += new System.EventHandler(this.btnToggleDir_Click);
            // 
            // pnlOpenFiles
            // 
            this.pnlOpenFiles.AutoScroll = true;
            this.pnlOpenFiles.AutoSize = true;
            this.pnlOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpenFiles.Location = new System.Drawing.Point(0, 22);
            this.pnlOpenFiles.Name = "pnlOpenFiles";
            this.pnlOpenFiles.Size = new System.Drawing.Size(150, 0);
            this.pnlOpenFiles.TabIndex = 1;
            this.pnlOpenFiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlOpenFiles_ControlRemoved);
            // 
            // btnToggleOpenFiles
            // 
            this.btnToggleOpenFiles.AutoEllipsis = true;
            this.btnToggleOpenFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnToggleOpenFiles.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.BorderSize = 0;
            this.btnToggleOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleOpenFiles.FlatAppearance.BorderSize = 0;
            this.btnToggleOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleOpenFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnToggleOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.btnToggleOpenFiles.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.Name = "btnToggleOpenFiles";
            this.btnToggleOpenFiles.Size = new System.Drawing.Size(150, 22);
            this.btnToggleOpenFiles.TabIndex = 0;
            this.btnToggleOpenFiles.Text = "v Open Files";
            this.btnToggleOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleOpenFiles.UseVisualStyleBackColor = false;
            this.btnToggleOpenFiles.Click += new System.EventHandler(this.btnToggleOpenFiles_Click);
            // 
            // splitContainerEditConsole
            // 
            this.splitContainerEditConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.splitContainerEditConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEditConsole.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEditConsole.Name = "splitContainerEditConsole";
            this.splitContainerEditConsole.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEditConsole.Panel1
            // 
            this.splitContainerEditConsole.Panel1.Controls.Add(this.txtMainBase);
            // 
            // splitContainerEditConsole.Panel2
            // 
            this.splitContainerEditConsole.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.splitContainerEditConsole.Size = new System.Drawing.Size(598, 370);
            this.splitContainerEditConsole.SplitterDistance = 266;
            this.splitContainerEditConsole.TabIndex = 3;
            this.splitContainerEditConsole.TabStop = false;
            this.splitContainerEditConsole.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerFull_SplitterMoved);
            // 
            // ofdOpen
            // 
            this.ofdOpen.Title = "Open File - BoinEdit";
            this.ofdOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpen_FileOk);
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.IncludeSubdirectories = true;
            this.fsWatcher.SynchronizingObject = this;
            // 
            // sfdSave
            // 
            this.sfdSave.Title = "Save As... - BoinEdit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.splitContainerFull);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "BoinEdit";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainBase)).EndInit();
            this.cmsTextEdit.ResumeLayout(false);
            this.splitContainerFull.Panel1.ResumeLayout(false);
            this.splitContainerFull.Panel1.PerformLayout();
            this.splitContainerFull.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).EndInit();
            this.splitContainerFull.ResumeLayout(false);
            this.splitContainerEditConsole.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditConsole)).EndInit();
            this.splitContainerEditConsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripMenuItem tsiNew;
        private System.Windows.Forms.ToolStripMenuItem tsiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem tsiCloseFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiSave;
        private System.Windows.Forms.ToolStripMenuItem tsiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsiSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.ToolStripMenuItem tsiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsiSettings;
        private FastColoredTextBoxNS.FastColoredTextBox txtMainBase;
        private System.Windows.Forms.ToolStripMenuItem tsiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsiRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsiCut;
        private System.Windows.Forms.ToolStripMenuItem tsiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsiFind;
        private System.Windows.Forms.ToolStripMenuItem tsiFindReplace;
        private System.Windows.Forms.ToolStripMenuItem tsiGoTo;
        private System.Windows.Forms.SplitContainer splitContainerFull;
        private System.Windows.Forms.ToolStripMenuItem tsiView;
        private System.Windows.Forms.ToolStripMenuItem tsiSideBar;
        private System.Windows.Forms.ToolStripMenuItem tsiConsole;
        private System.Windows.Forms.ToolStripMenuItem tsiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsiFilePath;
        private System.Windows.Forms.ToolStripMenuItem tsiLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsiCSharp;
        private System.Windows.Forms.ToolStripMenuItem tsiHTML;
        private System.Windows.Forms.ToolStripMenuItem tsiJS;
        private System.Windows.Forms.ToolStripMenuItem tsiLua;
        private System.Windows.Forms.ToolStripMenuItem tsiPHP;
        private System.Windows.Forms.ToolStripMenuItem tsiSQL;
        private System.Windows.Forms.ToolStripMenuItem tsiVB;
        private System.Windows.Forms.ToolStripMenuItem tsiXML;
        private System.Windows.Forms.SplitContainer splitContainerEditConsole;
        private System.Windows.Forms.ToolStripMenuItem tsiPlainText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTextEdit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private BoinBoxNS.BoinBox btnToggleOpenFiles;
        private BoinBoxNS.BoinBox btnToggleDir;
        private System.Windows.Forms.Panel pnlOpenFiles;
        private DirTreeView lstDir;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.IO.FileSystemWatcher fsWatcher;
        private System.Windows.Forms.SaveFileDialog sfdSave;
    }
}

