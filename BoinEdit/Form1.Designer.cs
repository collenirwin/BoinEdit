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
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.commentBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncommentBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBlockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBlockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSideBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).BeginInit();
            this.splitContainerFull.Panel1.SuspendLayout();
            this.splitContainerFull.Panel2.SuspendLayout();
            this.splitContainerFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEditConsole)).BeginInit();
            this.splitContainerEditConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiEdit,
            this.tsiView,
            this.tsiSettings,
            this.tsiAbout});
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
            this.tsiFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.tsiNew.Click += new System.EventHandler(this.tsiNew_Click);
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
            this.goToToolStripMenuItem,
            this.toolStripSeparator6,
            this.commentBlockToolStripMenuItem,
            this.uncommentBlockToolStripMenuItem,
            this.tabBlockInToolStripMenuItem,
            this.tabBlockOutToolStripMenuItem,
            this.convertCaseToolStripMenuItem});
            this.tsiEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tsiEdit.Name = "tsiEdit";
            this.tsiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsiEdit.Text = "Edit";
            // 
            // tsiUndo
            // 
            this.tsiUndo.Name = "tsiUndo";
            this.tsiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsiUndo.Size = new System.Drawing.Size(247, 22);
            this.tsiUndo.Text = "Undo";
            this.tsiUndo.Click += new System.EventHandler(this.tsiUndo_Click);
            // 
            // tsiRedo
            // 
            this.tsiRedo.Name = "tsiRedo";
            this.tsiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsiRedo.Size = new System.Drawing.Size(247, 22);
            this.tsiRedo.Text = "Redo";
            this.tsiRedo.Click += new System.EventHandler(this.tsiRedo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
            // 
            // tsiCut
            // 
            this.tsiCut.Name = "tsiCut";
            this.tsiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsiCut.Size = new System.Drawing.Size(247, 22);
            this.tsiCut.Text = "Cut";
            this.tsiCut.Click += new System.EventHandler(this.tsiCut_Click);
            // 
            // tsiCopy
            // 
            this.tsiCopy.Name = "tsiCopy";
            this.tsiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsiCopy.Size = new System.Drawing.Size(247, 22);
            this.tsiCopy.Text = "Copy";
            this.tsiCopy.Click += new System.EventHandler(this.tsiCopy_Click);
            // 
            // tsiPaste
            // 
            this.tsiPaste.Name = "tsiPaste";
            this.tsiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsiPaste.Size = new System.Drawing.Size(247, 22);
            this.tsiPaste.Text = "Paste";
            this.tsiPaste.Click += new System.EventHandler(this.tsiPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
            // 
            // tsiFind
            // 
            this.tsiFind.Name = "tsiFind";
            this.tsiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsiFind.Size = new System.Drawing.Size(247, 22);
            this.tsiFind.Text = "Find";
            this.tsiFind.Click += new System.EventHandler(this.tsiFind_Click);
            // 
            // tsiFindReplace
            // 
            this.tsiFindReplace.Name = "tsiFindReplace";
            this.tsiFindReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsiFindReplace.Size = new System.Drawing.Size(247, 22);
            this.tsiFindReplace.Text = "Find + Replace";
            this.tsiFindReplace.Click += new System.EventHandler(this.tsiFindReplace_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.goToToolStripMenuItem.Text = "Go To...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(244, 6);
            // 
            // commentBlockToolStripMenuItem
            // 
            this.commentBlockToolStripMenuItem.Name = "commentBlockToolStripMenuItem";
            this.commentBlockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.commentBlockToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.commentBlockToolStripMenuItem.Text = "Comment Block";
            this.commentBlockToolStripMenuItem.Click += new System.EventHandler(this.commentBlockToolStripMenuItem_Click);
            // 
            // uncommentBlockToolStripMenuItem
            // 
            this.uncommentBlockToolStripMenuItem.Name = "uncommentBlockToolStripMenuItem";
            this.uncommentBlockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.uncommentBlockToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.uncommentBlockToolStripMenuItem.Text = "Uncomment Block";
            this.uncommentBlockToolStripMenuItem.Click += new System.EventHandler(this.uncommentBlockToolStripMenuItem_Click);
            // 
            // tabBlockInToolStripMenuItem
            // 
            this.tabBlockInToolStripMenuItem.Name = "tabBlockInToolStripMenuItem";
            this.tabBlockInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.tabBlockInToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tabBlockInToolStripMenuItem.Text = "Tab Block In";
            this.tabBlockInToolStripMenuItem.Click += new System.EventHandler(this.tabBlockInToolStripMenuItem_Click);
            // 
            // tabBlockOutToolStripMenuItem
            // 
            this.tabBlockOutToolStripMenuItem.Name = "tabBlockOutToolStripMenuItem";
            this.tabBlockOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Tab)));
            this.tabBlockOutToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tabBlockOutToolStripMenuItem.Text = "Tab Block Out";
            this.tabBlockOutToolStripMenuItem.Click += new System.EventHandler(this.tabBlockOutToolStripMenuItem_Click);
            // 
            // convertCaseToolStripMenuItem
            // 
            this.convertCaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uppercaseToolStripMenuItem,
            this.uppercaseToolStripMenuItem1});
            this.convertCaseToolStripMenuItem.Name = "convertCaseToolStripMenuItem";
            this.convertCaseToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.convertCaseToolStripMenuItem.Text = "Convert Case";
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uppercaseToolStripMenuItem.Text = "Lowercase";
            // 
            // uppercaseToolStripMenuItem1
            // 
            this.uppercaseToolStripMenuItem1.Name = "uppercaseToolStripMenuItem1";
            this.uppercaseToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.uppercaseToolStripMenuItem1.Text = "Uppercase";
            // 
            // tsiView
            // 
            this.tsiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSideBar,
            this.tsiConsole});
            this.tsiView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.tsiSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tsiSettings.Name = "tsiSettings";
            this.tsiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsiSettings.Text = "Settings";
            // 
            // tsiAbout
            // 
            this.tsiAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsiAbout.Text = "About";
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
            this.lstDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lstDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDir.dirColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lstDir.directory = null;
            this.lstDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDir.fileColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lstDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lstDir.FullRowSelect = true;
            this.lstDir.Indent = 9;
            this.lstDir.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.lstDir.Location = new System.Drawing.Point(0, 48);
            this.lstDir.Name = "lstDir";
            treeNode1.Name = "nodOpenDir";
            treeNode1.Text = "Open Directory";
            this.lstDir.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.lstDir.ShowLines = false;
            this.lstDir.Size = new System.Drawing.Size(150, 322);
            this.lstDir.TabIndex = 2;
            this.lstDir.TabStop = false;
            this.lstDir.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstDir_NodeMouseDoubleClick);
            // 
            // btnToggleDir
            // 
            this.btnToggleDir.AntiAliased = false;
            this.btnToggleDir.AutoSize = true;
            this.btnToggleDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnToggleDir.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleDir.BorderSize = 0;
            this.btnToggleDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleDir.FlatAppearance.BorderSize = 0;
            this.btnToggleDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnToggleDir.Location = new System.Drawing.Point(0, 24);
            this.btnToggleDir.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnToggleDir.Name = "btnToggleDir";
            this.btnToggleDir.Size = new System.Drawing.Size(150, 24);
            this.btnToggleDir.TabIndex = 0;
            this.btnToggleDir.TabStop = false;
            this.btnToggleDir.Text = "v Directory";
            this.btnToggleDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleDir.UseVisualStyleBackColor = false;
            this.btnToggleDir.Click += new System.EventHandler(this.btnToggleDir_Click);
            // 
            // pnlOpenFiles
            // 
            this.pnlOpenFiles.AutoSize = true;
            this.pnlOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpenFiles.Location = new System.Drawing.Point(0, 24);
            this.pnlOpenFiles.Name = "pnlOpenFiles";
            this.pnlOpenFiles.Size = new System.Drawing.Size(150, 0);
            this.pnlOpenFiles.TabIndex = 1;
            this.pnlOpenFiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlOpenFiles_ControlRemoved);
            // 
            // btnToggleOpenFiles
            // 
            this.btnToggleOpenFiles.AntiAliased = false;
            this.btnToggleOpenFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnToggleOpenFiles.BorderColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.BorderSize = 0;
            this.btnToggleOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleOpenFiles.FlatAppearance.BorderSize = 0;
            this.btnToggleOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleOpenFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnToggleOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.btnToggleOpenFiles.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnToggleOpenFiles.Name = "btnToggleOpenFiles";
            this.btnToggleOpenFiles.Size = new System.Drawing.Size(150, 24);
            this.btnToggleOpenFiles.TabIndex = 0;
            this.btnToggleOpenFiles.TabStop = false;
            this.btnToggleOpenFiles.Text = "v Open Files";
            this.btnToggleOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleOpenFiles.UseVisualStyleBackColor = false;
            this.btnToggleOpenFiles.Click += new System.EventHandler(this.btnToggleOpenFiles_Click);
            // 
            // splitContainerEditConsole
            // 
            this.splitContainerEditConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.splitContainerEditConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEditConsole.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEditConsole.Name = "splitContainerEditConsole";
            this.splitContainerEditConsole.Orientation = System.Windows.Forms.Orientation.Horizontal;
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
            this.sfdSave.AddExtension = false;
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
            this.splitContainerFull.Panel1.ResumeLayout(false);
            this.splitContainerFull.Panel1.PerformLayout();
            this.splitContainerFull.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFull)).EndInit();
            this.splitContainerFull.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem tsiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsiRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsiCut;
        private System.Windows.Forms.ToolStripMenuItem tsiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsiFind;
        private System.Windows.Forms.ToolStripMenuItem tsiFindReplace;
        private System.Windows.Forms.SplitContainer splitContainerFull;
        private System.Windows.Forms.ToolStripMenuItem tsiView;
        private System.Windows.Forms.ToolStripMenuItem tsiSideBar;
        private System.Windows.Forms.ToolStripMenuItem tsiConsole;
        private System.Windows.Forms.ToolStripMenuItem tsiAbout;
        private System.Windows.Forms.SplitContainer splitContainerEditConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private BoinBoxNS.BoinBox btnToggleOpenFiles;
        private BoinBoxNS.BoinBox btnToggleDir;
        private System.Windows.Forms.Panel pnlOpenFiles;
        private DirTreeView lstDir;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.IO.FileSystemWatcher fsWatcher;
        public System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem commentBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabBlockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabBlockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncommentBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem1;
    }
}

