﻿namespace BoinEditNS {
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
            this.txtMain = new FastColoredTextBoxNS.FastColoredTextBox();
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
            this.splitContainerFiles = new System.Windows.Forms.SplitContainer();
            this.splitContainerEditConsole = new System.Windows.Forms.SplitContainer();
            this.pnlToggleOpenFiles = new System.Windows.Forms.Panel();
            this.btnToggleOpenFiles = new BoinBoxNS.BoinBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToggleDir = new BoinBoxNS.BoinBox();
            this.pnlOpenFiles = new System.Windows.Forms.Panel();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain)).BeginInit();
            this.cmsTextEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).BeginInit();
            this.splitContainerFull.Panel1.SuspendLayout();
            this.splitContainerFull.Panel2.SuspendLayout();
            this.splitContainerFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).BeginInit();
            this.splitContainerFiles.Panel1.SuspendLayout();
            this.splitContainerFiles.Panel2.SuspendLayout();
            this.splitContainerFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditConsole)).BeginInit();
            this.splitContainerEditConsole.Panel1.SuspendLayout();
            this.splitContainerEditConsole.SuspendLayout();
            this.pnlToggleOpenFiles.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tsiNew.Text = "New";
            // 
            // tsiOpen
            // 
            this.tsiOpen.Name = "tsiOpen";
            this.tsiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsiOpen.Size = new System.Drawing.Size(214, 22);
            this.tsiOpen.Text = "Open";
            // 
            // tsiOpenFolder
            // 
            this.tsiOpenFolder.Name = "tsiOpenFolder";
            this.tsiOpenFolder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.tsiOpenFolder.Size = new System.Drawing.Size(214, 22);
            this.tsiOpenFolder.Text = "Open Folder";
            // 
            // tsiCloseFolder
            // 
            this.tsiCloseFolder.Name = "tsiCloseFolder";
            this.tsiCloseFolder.Size = new System.Drawing.Size(214, 22);
            this.tsiCloseFolder.Text = "Close Folder";
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
            // 
            // tsiSaveAs
            // 
            this.tsiSaveAs.Name = "tsiSaveAs";
            this.tsiSaveAs.Size = new System.Drawing.Size(214, 22);
            this.tsiSaveAs.Text = "Save As...";
            // 
            // tsiSaveAll
            // 
            this.tsiSaveAll.Name = "tsiSaveAll";
            this.tsiSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsiSaveAll.Size = new System.Drawing.Size(214, 22);
            this.tsiSaveAll.Text = "Save All";
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
            // txtMain
            // 
            this.txtMain.AutoCompleteBrackets = true;
            this.txtMain.AutoCompleteBracketsList = new char[] {
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
            this.txtMain.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
            this.txtMain.AutoScrollMinSize = new System.Drawing.Size(395, 119);
            this.txtMain.BackBrush = null;
            this.txtMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtMain.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtMain.CharHeight = 17;
            this.txtMain.CharWidth = 8;
            this.txtMain.ContextMenuStrip = this.cmsTextEdit;
            this.txtMain.CurrentLineColor = System.Drawing.Color.Silver;
            this.txtMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMain.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtMain.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.txtMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtMain.IndentBackColor = System.Drawing.Color.Transparent;
            this.txtMain.IsReplaceMode = false;
            this.txtMain.Language = FastColoredTextBoxNS.Language.JS;
            this.txtMain.LeftBracket = '(';
            this.txtMain.LeftBracket2 = '{';
            this.txtMain.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.txtMain.Location = new System.Drawing.Point(0, 0);
            this.txtMain.Name = "txtMain";
            this.txtMain.Paddings = new System.Windows.Forms.Padding(0);
            this.txtMain.PreferredLineWidth = 30;
            this.txtMain.RightBracket = ')';
            this.txtMain.RightBracket2 = '}';
            this.txtMain.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txtMain.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtMain.ServiceColors")));
            this.txtMain.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.txtMain.ShowFoldingLines = true;
            this.txtMain.Size = new System.Drawing.Size(598, 266);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "// test.js\r\n// Collen Irwin\r\n\r\nfunction test(arg1, arg2) {\r\n    document.write(ar" +
    "g1.toString() + \"Hello\");\r\n    alert(1028);\r\n}";
            this.txtMain.Zoom = 100;
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
            this.splitContainerFull.Panel1.Controls.Add(this.splitContainerFiles);
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
            // splitContainerFiles
            // 
            this.splitContainerFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFiles.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFiles.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFiles.Name = "splitContainerFiles";
            this.splitContainerFiles.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFiles.Panel1
            // 
            this.splitContainerFiles.Panel1.AutoScroll = true;
            this.splitContainerFiles.Panel1.Controls.Add(this.pnlOpenFiles);
            this.splitContainerFiles.Panel1.Controls.Add(this.pnlToggleOpenFiles);
            this.splitContainerFiles.Panel1MinSize = 22;
            // 
            // splitContainerFiles.Panel2
            // 
            this.splitContainerFiles.Panel2.Controls.Add(this.panel1);
            this.splitContainerFiles.Panel2MinSize = 22;
            this.splitContainerFiles.Size = new System.Drawing.Size(150, 370);
            this.splitContainerFiles.SplitterDistance = 127;
            this.splitContainerFiles.TabIndex = 0;
            this.splitContainerFiles.TabStop = false;
            this.splitContainerFiles.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerFull_SplitterMoved);
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
            this.splitContainerEditConsole.Panel1.Controls.Add(this.txtMain);
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
            // pnlToggleOpenFiles
            // 
            this.pnlToggleOpenFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlToggleOpenFiles.Controls.Add(this.btnToggleOpenFiles);
            this.pnlToggleOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToggleOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.pnlToggleOpenFiles.Name = "pnlToggleOpenFiles";
            this.pnlToggleOpenFiles.Size = new System.Drawing.Size(150, 22);
            this.pnlToggleOpenFiles.TabIndex = 0;
            // 
            // btnToggleOpenFiles
            // 
            this.btnToggleOpenFiles.AutoEllipsis = true;
            this.btnToggleOpenFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnToggleOpenFiles.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.BorderSize = 0;
            this.btnToggleOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnToggleDir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 22);
            this.panel1.TabIndex = 1;
            // 
            // btnToggleDir
            // 
            this.btnToggleDir.AutoEllipsis = true;
            this.btnToggleDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnToggleDir.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleDir.BorderSize = 0;
            this.btnToggleDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleDir.FlatAppearance.BorderSize = 0;
            this.btnToggleDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnToggleDir.Location = new System.Drawing.Point(0, 0);
            this.btnToggleDir.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.Name = "btnToggleDir";
            this.btnToggleDir.Size = new System.Drawing.Size(150, 22);
            this.btnToggleDir.TabIndex = 0;
            this.btnToggleDir.Text = "v No Directory Selected";
            this.btnToggleDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleDir.UseVisualStyleBackColor = false;
            this.btnToggleDir.Click += new System.EventHandler(this.btnToggleDir_Click);
            // 
            // pnlOpenFiles
            // 
            this.pnlOpenFiles.AutoScroll = true;
            this.pnlOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpenFiles.Location = new System.Drawing.Point(0, 22);
            this.pnlOpenFiles.Name = "pnlOpenFiles";
            this.pnlOpenFiles.Size = new System.Drawing.Size(150, 105);
            this.pnlOpenFiles.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtMain)).EndInit();
            this.cmsTextEdit.ResumeLayout(false);
            this.splitContainerFull.Panel1.ResumeLayout(false);
            this.splitContainerFull.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).EndInit();
            this.splitContainerFull.ResumeLayout(false);
            this.splitContainerFiles.Panel1.ResumeLayout(false);
            this.splitContainerFiles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).EndInit();
            this.splitContainerFiles.ResumeLayout(false);
            this.splitContainerEditConsole.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditConsole)).EndInit();
            this.splitContainerEditConsole.ResumeLayout(false);
            this.pnlToggleOpenFiles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private FastColoredTextBoxNS.FastColoredTextBox txtMain;
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
        private System.Windows.Forms.SplitContainer splitContainerFiles;
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
        private System.Windows.Forms.Panel pnlToggleOpenFiles;
        private BoinBoxNS.BoinBox btnToggleOpenFiles;
        private System.Windows.Forms.Panel panel1;
        private BoinBoxNS.BoinBox btnToggleDir;
        private System.Windows.Forms.Panel pnlOpenFiles;
    }
}
