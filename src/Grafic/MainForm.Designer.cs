namespace Grafic
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRuler = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAdjust = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemToolBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemInfoBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemColorBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLayerBox = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItatic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripOption = new System.Windows.Forms.ToolStripButton();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.picRubberBandLayer = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRubberBandLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.GraphicToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(582, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemNew,
            this.mnuItemOpen,
            this.toolStripSeparator3,
            this.mnuItemSave,
            this.mnuItemSaveAs,
            this.mnuItemPrint,
            this.toolStripSeparator2,
            this.mnuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            // 
            // mnuItemNew
            // 
            this.mnuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemNew.Image")));
            this.mnuItemNew.Name = "mnuItemNew";
            this.mnuItemNew.ShortcutKeyDisplayString = "";
            this.mnuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuItemNew.Size = new System.Drawing.Size(219, 22);
            this.mnuItemNew.Text = "新建(&N)";
            this.mnuItemNew.Click += new System.EventHandler(this.mnuItemNew_Click);
            // 
            // mnuItemOpen
            // 
            this.mnuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemOpen.Image")));
            this.mnuItemOpen.Name = "mnuItemOpen";
            this.mnuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuItemOpen.Size = new System.Drawing.Size(219, 22);
            this.mnuItemOpen.Text = "打开(&O)...";
            this.mnuItemOpen.Click += new System.EventHandler(this.mnuItemOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // mnuItemSave
            // 
            this.mnuItemSave.Enabled = false;
            this.mnuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemSave.Image")));
            this.mnuItemSave.Name = "mnuItemSave";
            this.mnuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuItemSave.Size = new System.Drawing.Size(219, 22);
            this.mnuItemSave.Text = "保存(&S)";
            this.mnuItemSave.Click += new System.EventHandler(this.mnuItemSave_Click);
            // 
            // mnuItemSaveAs
            // 
            this.mnuItemSaveAs.Enabled = false;
            this.mnuItemSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemSaveAs.Image")));
            this.mnuItemSaveAs.Name = "mnuItemSaveAs";
            this.mnuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.mnuItemSaveAs.Size = new System.Drawing.Size(219, 22);
            this.mnuItemSaveAs.Text = "储存为(&A)...";
            this.mnuItemSaveAs.Click += new System.EventHandler(this.mnuItemSaveAs_Click);
            // 
            // mnuItemPrint
            // 
            this.mnuItemPrint.Enabled = false;
            this.mnuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemPrint.Image")));
            this.mnuItemPrint.Name = "mnuItemPrint";
            this.mnuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuItemPrint.Size = new System.Drawing.Size(219, 22);
            this.mnuItemPrint.Text = "打印(&P)...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuItemExit.Size = new System.Drawing.Size(219, 22);
            this.mnuItemExit.Text = "退出(&X)";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemUndo,
            this.mnuItemRedo,
            this.toolStripSeparator4,
            this.mnuItemCut,
            this.mnuItemCopy,
            this.mnuItemPaste,
            this.mnuItemDelete,
            this.toolStripSeparator8,
            this.mnuItemOptions});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "编辑(&E)";
            // 
            // mnuItemUndo
            // 
            this.mnuItemUndo.Enabled = false;
            this.mnuItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemUndo.Image")));
            this.mnuItemUndo.Name = "mnuItemUndo";
            this.mnuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuItemUndo.Size = new System.Drawing.Size(189, 22);
            this.mnuItemUndo.Text = "撤销(&U)";
            // 
            // mnuItemRedo
            // 
            this.mnuItemRedo.Enabled = false;
            this.mnuItemRedo.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemRedo.Image")));
            this.mnuItemRedo.Name = "mnuItemRedo";
            this.mnuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Z)));
            this.mnuItemRedo.Size = new System.Drawing.Size(189, 22);
            this.mnuItemRedo.Text = "恢复(&R)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // mnuItemCut
            // 
            this.mnuItemCut.Enabled = false;
            this.mnuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemCut.Image")));
            this.mnuItemCut.Name = "mnuItemCut";
            this.mnuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuItemCut.Size = new System.Drawing.Size(189, 22);
            this.mnuItemCut.Text = "剪切(&T)";
            // 
            // mnuItemCopy
            // 
            this.mnuItemCopy.Enabled = false;
            this.mnuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemCopy.Image")));
            this.mnuItemCopy.Name = "mnuItemCopy";
            this.mnuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuItemCopy.Size = new System.Drawing.Size(189, 22);
            this.mnuItemCopy.Text = "复制(&C)";
            // 
            // mnuItemPaste
            // 
            this.mnuItemPaste.Enabled = false;
            this.mnuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemPaste.Image")));
            this.mnuItemPaste.Name = "mnuItemPaste";
            this.mnuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuItemPaste.Size = new System.Drawing.Size(189, 22);
            this.mnuItemPaste.Text = "粘贴(&P)";
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Enabled = false;
            this.mnuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemDelete.Image")));
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.Size = new System.Drawing.Size(189, 22);
            this.mnuItemDelete.Text = "删除(&D)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(186, 6);
            // 
            // mnuItemOptions
            // 
            this.mnuItemOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemOptions.Image")));
            this.mnuItemOptions.Name = "mnuItemOptions";
            this.mnuItemOptions.Size = new System.Drawing.Size(189, 22);
            this.mnuItemOptions.Text = "选项(&N)...";
            this.mnuItemOptions.Click += new System.EventHandler(this.mnuItemOptions_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemZoomIn,
            this.mnuItemZoomOut,
            this.mnuItemRuler});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.viewToolStripMenuItem.Text = "视图(&V)";
            // 
            // mnuItemZoomIn
            // 
            this.mnuItemZoomIn.Enabled = false;
            this.mnuItemZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemZoomIn.Image")));
            this.mnuItemZoomIn.Name = "mnuItemZoomIn";
            this.mnuItemZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.mnuItemZoomIn.Size = new System.Drawing.Size(171, 22);
            this.mnuItemZoomIn.Text = "放大(&I)";
            this.mnuItemZoomIn.Click += new System.EventHandler(this.mnuItemZoomIn_Click);
            // 
            // mnuItemZoomOut
            // 
            this.mnuItemZoomOut.Enabled = false;
            this.mnuItemZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemZoomOut.Image")));
            this.mnuItemZoomOut.Name = "mnuItemZoomOut";
            this.mnuItemZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.mnuItemZoomOut.Size = new System.Drawing.Size(171, 22);
            this.mnuItemZoomOut.Text = "缩小(&O)";
            this.mnuItemZoomOut.Click += new System.EventHandler(this.mnuItemZoomOut_Click);
            // 
            // mnuItemRuler
            // 
            this.mnuItemRuler.Enabled = false;
            this.mnuItemRuler.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemRuler.Image")));
            this.mnuItemRuler.Name = "mnuItemRuler";
            this.mnuItemRuler.Size = new System.Drawing.Size(171, 22);
            this.mnuItemRuler.Text = "标尺(&R)";
            // 
            // GraphicToolStripMenuItem
            // 
            this.GraphicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAdjust,
            this.toolStripSeparator10});
            this.GraphicToolStripMenuItem.Name = "GraphicToolStripMenuItem";
            this.GraphicToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.GraphicToolStripMenuItem.Text = "图像(&G)";
            // 
            // mnuItemAdjust
            // 
            this.mnuItemAdjust.Enabled = false;
            this.mnuItemAdjust.Name = "mnuItemAdjust";
            this.mnuItemAdjust.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuItemAdjust.Size = new System.Drawing.Size(152, 22);
            this.mnuItemAdjust.Text = "调整";
            this.mnuItemAdjust.Click += new System.EventHandler(this.mnuItemAdjust_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(149, 6);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemToolBox,
            this.mnuItemInfoBox,
            this.mnuItemColorBox,
            this.mnuItemLayerBox});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.windowToolStripMenuItem.Text = "窗口(&W)";
            // 
            // mnuItemToolBox
            // 
            this.mnuItemToolBox.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemToolBox.Image")));
            this.mnuItemToolBox.Name = "mnuItemToolBox";
            this.mnuItemToolBox.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuItemToolBox.Size = new System.Drawing.Size(152, 22);
            this.mnuItemToolBox.Text = "工具箱";
            this.mnuItemToolBox.Click += new System.EventHandler(this.mnuToolBoxIsShow_Click);
            // 
            // mnuItemInfoBox
            // 
            this.mnuItemInfoBox.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemInfoBox.Image")));
            this.mnuItemInfoBox.Name = "mnuItemInfoBox";
            this.mnuItemInfoBox.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuItemInfoBox.Size = new System.Drawing.Size(152, 22);
            this.mnuItemInfoBox.Text = "信息栏";
            this.mnuItemInfoBox.Click += new System.EventHandler(this.mnuInfoBoxIsShow_Click);
            // 
            // mnuItemColorBox
            // 
            this.mnuItemColorBox.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemColorBox.Image")));
            this.mnuItemColorBox.Name = "mnuItemColorBox";
            this.mnuItemColorBox.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuItemColorBox.Size = new System.Drawing.Size(152, 22);
            this.mnuItemColorBox.Text = "颜料盒";
            this.mnuItemColorBox.Click += new System.EventHandler(this.mnuColorBoxIsShow_Click);
            // 
            // mnuItemLayerBox
            // 
            this.mnuItemLayerBox.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemLayerBox.Image")));
            this.mnuItemLayerBox.Name = "mnuItemLayerBox";
            this.mnuItemLayerBox.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mnuItemLayerBox.Size = new System.Drawing.Size(152, 22);
            this.mnuItemLayerBox.Text = "图层窗";
            this.mnuItemLayerBox.Click += new System.EventHandler(this.mnuLayerBoxIsShow_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHelper,
            this.mnuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.helpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // mnuItemHelper
            // 
            this.mnuItemHelper.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemHelper.Image")));
            this.mnuItemHelper.Name = "mnuItemHelper";
            this.mnuItemHelper.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuItemHelper.Size = new System.Drawing.Size(172, 22);
            this.mnuItemHelper.Text = "帮助";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemAbout.Image")));
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(172, 22);
            this.mnuItemAbout.Text = "关于 Grafic(&A)...";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripRedo,
            this.toolStripUndo,
            this.toolStripSeparator5,
            this.toolStripCut,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripSeparator6,
            this.toolStripBold,
            this.toolStripItatic,
            this.toolStripUnderline,
            this.toolStripFontFamily,
            this.toolStripFontSize,
            this.toolStripSeparator9,
            this.toolStripHelp,
            this.toolStripOption});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(582, 25);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripNew.Text = "toolStripButton1";
            this.toolStripNew.ToolTipText = "新建";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "toolStripButton1";
            this.toolStripOpen.ToolTipText = "打开";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Enabled = false;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripSave.Text = "toolStripButton2";
            this.toolStripSave.ToolTipText = "保存";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Enabled = false;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripRedo.Text = "toolStripButton1";
            this.toolStripRedo.ToolTipText = "恢复";
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Enabled = false;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripUndo.Text = "toolStripButton1";
            this.toolStripUndo.ToolTipText = "撤销";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Enabled = false;
            this.toolStripCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCut.Image")));
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripCut.Text = "toolStripButton1";
            this.toolStripCut.ToolTipText = "剪切";
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Enabled = false;
            this.toolStripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopy.Image")));
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopy.Text = "toolStripButton1";
            this.toolStripCopy.ToolTipText = "复制";
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Enabled = false;
            this.toolStripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaste.Image")));
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripPaste.Text = "toolStripButton1";
            this.toolStripPaste.ToolTipText = "粘贴";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Enabled = false;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBold.Text = "toolStripButton1";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            // 
            // toolStripItatic
            // 
            this.toolStripItatic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItatic.Enabled = false;
            this.toolStripItatic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItatic.Image")));
            this.toolStripItatic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItatic.Name = "toolStripItatic";
            this.toolStripItatic.Size = new System.Drawing.Size(23, 22);
            this.toolStripItatic.Text = "toolStripButton2";
            this.toolStripItatic.Click += new System.EventHandler(this.toolStripItatic_Click);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Enabled = false;
            this.toolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderline.Image")));
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripUnderline.Text = "toolStripButton3";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            // 
            // toolStripFontFamily
            // 
            this.toolStripFontFamily.AutoSize = false;
            this.toolStripFontFamily.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFontFamily.DropDownWidth = 180;
            this.toolStripFontFamily.Enabled = false;
            this.toolStripFontFamily.Name = "toolStripFontFamily";
            this.toolStripFontFamily.Size = new System.Drawing.Size(120, 20);
            this.toolStripFontFamily.SelectedIndexChanged += new System.EventHandler(this.toolStripFontFamily_SelectedIndexChanged);
            // 
            // toolStripFontSize
            // 
            this.toolStripFontSize.AutoSize = false;
            this.toolStripFontSize.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFontSize.DropDownWidth = 40;
            this.toolStripFontSize.Enabled = false;
            this.toolStripFontSize.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "20",
            "22",
            "24",
            "26",
            "28",
            "32",
            "40",
            "48",
            "56",
            "64"});
            this.toolStripFontSize.Name = "toolStripFontSize";
            this.toolStripFontSize.Size = new System.Drawing.Size(40, 20);
            this.toolStripFontSize.SelectedIndexChanged += new System.EventHandler(this.toolStripFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelp.Image")));
            this.toolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripHelp.Text = "toolStripButton4";
            this.toolStripHelp.ToolTipText = "帮助";
            // 
            // toolStripOption
            // 
            this.toolStripOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOption.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOption.Image")));
            this.toolStripOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.Size = new System.Drawing.Size(23, 22);
            this.toolStripOption.Text = "toolStripButton5";
            this.toolStripOption.ToolTipText = "选项";
            this.toolStripOption.Click += new System.EventHandler(this.toolStripOption_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Controls.Add(this.picRubberBandLayer);
            this.pnlBackground.Location = new System.Drawing.Point(2, 55);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(494, 210);
            this.pnlBackground.TabIndex = 3;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackground_Paint);
            // 
            // picRubberBandLayer
            // 
            this.picRubberBandLayer.BackColor = System.Drawing.Color.Transparent;
            this.picRubberBandLayer.Location = new System.Drawing.Point(0, 0);
            this.picRubberBandLayer.Name = "picRubberBandLayer";
            this.picRubberBandLayer.Size = new System.Drawing.Size(491, 207);
            this.picRubberBandLayer.TabIndex = 0;
            this.picRubberBandLayer.TabStop = false;
            this.picRubberBandLayer.MouseLeave += new System.EventHandler(this.picRubberBandLayer_MouseLeave);
            this.picRubberBandLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRubberBandLayer_MouseMove);
            this.picRubberBandLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRubberBandLayer_MouseDown);
            this.picRubberBandLayer.Paint += new System.Windows.Forms.PaintEventHandler(this.picRubberBandLayer_Paint);
            this.picRubberBandLayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picRubberBandLayer_MouseUp);
            this.picRubberBandLayer.MouseEnter += new System.EventHandler(this.picRubberBandLayer_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(582, 480);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.pnlBackground);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRubberBandLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNew;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSave;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCut;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem mnuItemZoomOut;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemToolBox;
        private System.Windows.Forms.ToolStripMenuItem mnuItemInfoBox;
        private System.Windows.Forms.ToolStripMenuItem mnuItemColorBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelper;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripHelp;
        private System.Windows.Forms.ToolStripButton toolStripOption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem GraphicToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRuler;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLayerBox;
        public System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItatic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        public System.Windows.Forms.ToolStripComboBox toolStripFontSize;
        public System.Windows.Forms.ToolStripComboBox toolStripFontFamily;
        public System.Windows.Forms.PictureBox picRubberBandLayer;
        public System.Windows.Forms.ToolStripMenuItem mnuItemAdjust;
    }
}

