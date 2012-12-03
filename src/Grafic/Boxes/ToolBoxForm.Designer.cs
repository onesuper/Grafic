namespace Grafic.Boxes
{
    partial class ToolBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEraserStyle = new System.Windows.Forms.Label();
            this.lblLineAndCurve = new System.Windows.Forms.Label();
            this.cboEraserWidth = new System.Windows.Forms.ComboBox();
            this.cboLineWidth = new System.Windows.Forms.ComboBox();
            this.lblEraser = new System.Windows.Forms.Label();
            this.lblLineWidth = new System.Windows.Forms.Label();
            this.cboBrushWidth = new System.Windows.Forms.ComboBox();
            this.lblBrush = new System.Windows.Forms.Label();
            this.lblBrushWidth = new System.Windows.Forms.Label();
            this.lblBrushStyle = new System.Windows.Forms.Label();
            this.cboBrushStyle = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToolText = new System.Windows.Forms.RadioButton();
            this.btnToolFillBorder = new System.Windows.Forms.RadioButton();
            this.btnPaintBucket = new System.Windows.Forms.RadioButton();
            this.btnToolColorPicker = new System.Windows.Forms.RadioButton();
            this.btnToolEraser = new System.Windows.Forms.RadioButton();
            this.btnToolBrush = new System.Windows.Forms.RadioButton();
            this.btnToolPencil = new System.Windows.Forms.RadioButton();
            this.btnToolFreeFormShape = new System.Windows.Forms.RadioButton();
            this.btnToolLine = new System.Windows.Forms.RadioButton();
            this.btnToolRoundedRectangle = new System.Windows.Forms.RadioButton();
            this.btnToolEllipse = new System.Windows.Forms.RadioButton();
            this.btnToolCloneStamp = new System.Windows.Forms.RadioButton();
            this.btnToolMagicWand = new System.Windows.Forms.RadioButton();
            this.btnToolLassoSelect = new System.Windows.Forms.RadioButton();
            this.btnToolEllipseSelect = new System.Windows.Forms.RadioButton();
            this.btnToolAdjust = new System.Windows.Forms.RadioButton();
            this.btnRectangleSelect = new System.Windows.Forms.RadioButton();
            this.btnToolCurve = new System.Windows.Forms.RadioButton();
            this.btnToolRectangle = new System.Windows.Forms.RadioButton();
            this.btnToolSelectAndMove = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 20);
            this.tabControl1.Location = new System.Drawing.Point(19, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(171, 219);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEraserStyle);
            this.tabPage1.Controls.Add(this.lblLineAndCurve);
            this.tabPage1.Controls.Add(this.cboEraserWidth);
            this.tabPage1.Controls.Add(this.cboLineWidth);
            this.tabPage1.Controls.Add(this.lblEraser);
            this.tabPage1.Controls.Add(this.lblLineWidth);
            this.tabPage1.Controls.Add(this.cboBrushWidth);
            this.tabPage1.Controls.Add(this.lblBrush);
            this.tabPage1.Controls.Add(this.lblBrushWidth);
            this.tabPage1.Controls.Add(this.lblBrushStyle);
            this.tabPage1.Controls.Add(this.cboBrushStyle);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(163, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "背景";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEraserStyle
            // 
            this.lblEraserStyle.AutoSize = true;
            this.lblEraserStyle.Location = new System.Drawing.Point(38, 155);
            this.lblEraserStyle.Name = "lblEraserStyle";
            this.lblEraserStyle.Size = new System.Drawing.Size(29, 12);
            this.lblEraserStyle.TabIndex = 28;
            this.lblEraserStyle.Text = "大小";
            // 
            // lblLineAndCurve
            // 
            this.lblLineAndCurve.AutoSize = true;
            this.lblLineAndCurve.Location = new System.Drawing.Point(23, 10);
            this.lblLineAndCurve.Name = "lblLineAndCurve";
            this.lblLineAndCurve.Size = new System.Drawing.Size(29, 12);
            this.lblLineAndCurve.TabIndex = 1;
            this.lblLineAndCurve.Text = "线条";
            // 
            // cboEraserWidth
            // 
            this.cboEraserWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEraserWidth.FormattingEnabled = true;
            this.cboEraserWidth.Items.AddRange(new object[] {
            "小",
            "中",
            "大"});
            this.cboEraserWidth.Location = new System.Drawing.Point(71, 152);
            this.cboEraserWidth.Name = "cboEraserWidth";
            this.cboEraserWidth.Size = new System.Drawing.Size(56, 20);
            this.cboEraserWidth.TabIndex = 27;
            this.cboEraserWidth.SelectedIndexChanged += new System.EventHandler(this.cboEraserWidth_SelectedIndexChanged);
            // 
            // cboLineWidth
            // 
            this.cboLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineWidth.FormattingEnabled = true;
            this.cboLineWidth.Items.AddRange(new object[] {
            "细",
            "中",
            "粗",
            "极粗"});
            this.cboLineWidth.Location = new System.Drawing.Point(71, 28);
            this.cboLineWidth.Name = "cboLineWidth";
            this.cboLineWidth.Size = new System.Drawing.Size(56, 20);
            this.cboLineWidth.TabIndex = 0;
            this.cboLineWidth.SelectedIndexChanged += new System.EventHandler(this.cboLineWidth_SelectedIndexChanged);
            // 
            // lblEraser
            // 
            this.lblEraser.AutoSize = true;
            this.lblEraser.Location = new System.Drawing.Point(23, 135);
            this.lblEraser.Name = "lblEraser";
            this.lblEraser.Size = new System.Drawing.Size(29, 12);
            this.lblEraser.TabIndex = 26;
            this.lblEraser.Text = "橡皮";
            // 
            // lblLineWidth
            // 
            this.lblLineWidth.AutoSize = true;
            this.lblLineWidth.Location = new System.Drawing.Point(38, 31);
            this.lblLineWidth.Name = "lblLineWidth";
            this.lblLineWidth.Size = new System.Drawing.Size(29, 12);
            this.lblLineWidth.TabIndex = 2;
            this.lblLineWidth.Text = "粗细";
            // 
            // cboBrushWidth
            // 
            this.cboBrushWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrushWidth.FormattingEnabled = true;
            this.cboBrushWidth.Items.AddRange(new object[] {
            "细",
            "中",
            "粗",
            "极粗"});
            this.cboBrushWidth.Location = new System.Drawing.Point(71, 104);
            this.cboBrushWidth.Name = "cboBrushWidth";
            this.cboBrushWidth.Size = new System.Drawing.Size(56, 20);
            this.cboBrushWidth.TabIndex = 25;
            this.cboBrushWidth.SelectedIndexChanged += new System.EventHandler(this.cboBrushWidth_SelectedIndexChanged);
            // 
            // lblBrush
            // 
            this.lblBrush.AutoSize = true;
            this.lblBrush.Location = new System.Drawing.Point(23, 60);
            this.lblBrush.Name = "lblBrush";
            this.lblBrush.Size = new System.Drawing.Size(29, 12);
            this.lblBrush.TabIndex = 21;
            this.lblBrush.Text = "笔刷";
            // 
            // lblBrushWidth
            // 
            this.lblBrushWidth.AutoSize = true;
            this.lblBrushWidth.Location = new System.Drawing.Point(38, 107);
            this.lblBrushWidth.Name = "lblBrushWidth";
            this.lblBrushWidth.Size = new System.Drawing.Size(29, 12);
            this.lblBrushWidth.TabIndex = 24;
            this.lblBrushWidth.Text = "粗细";
            // 
            // lblBrushStyle
            // 
            this.lblBrushStyle.AutoSize = true;
            this.lblBrushStyle.Location = new System.Drawing.Point(38, 81);
            this.lblBrushStyle.Name = "lblBrushStyle";
            this.lblBrushStyle.Size = new System.Drawing.Size(29, 12);
            this.lblBrushStyle.TabIndex = 22;
            this.lblBrushStyle.Text = "风格";
            // 
            // cboBrushStyle
            // 
            this.cboBrushStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrushStyle.FormattingEnabled = true;
            this.cboBrushStyle.Items.AddRange(new object[] {
            "实心",
            "阴影",
            "梯度"});
            this.cboBrushStyle.Location = new System.Drawing.Point(71, 78);
            this.cboBrushStyle.Name = "cboBrushStyle";
            this.cboBrushStyle.Size = new System.Drawing.Size(56, 20);
            this.cboBrushStyle.TabIndex = 23;
            this.cboBrushStyle.SelectedIndexChanged += new System.EventHandler(this.cboBrushStyle_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(163, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文本";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(155, 172);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "请在文本中输入文字";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.btnToolText);
            this.groupBox1.Controls.Add(this.btnToolFillBorder);
            this.groupBox1.Controls.Add(this.btnPaintBucket);
            this.groupBox1.Controls.Add(this.btnToolColorPicker);
            this.groupBox1.Controls.Add(this.btnToolEraser);
            this.groupBox1.Controls.Add(this.btnToolBrush);
            this.groupBox1.Controls.Add(this.btnToolPencil);
            this.groupBox1.Controls.Add(this.btnToolFreeFormShape);
            this.groupBox1.Controls.Add(this.btnToolLine);
            this.groupBox1.Controls.Add(this.btnToolRoundedRectangle);
            this.groupBox1.Controls.Add(this.btnToolEllipse);
            this.groupBox1.Controls.Add(this.btnToolCloneStamp);
            this.groupBox1.Controls.Add(this.btnToolMagicWand);
            this.groupBox1.Controls.Add(this.btnToolLassoSelect);
            this.groupBox1.Controls.Add(this.btnToolEllipseSelect);
            this.groupBox1.Controls.Add(this.btnToolAdjust);
            this.groupBox1.Controls.Add(this.btnRectangleSelect);
            this.groupBox1.Controls.Add(this.btnToolCurve);
            this.groupBox1.Controls.Add(this.btnToolRectangle);
            this.groupBox1.Controls.Add(this.btnToolSelectAndMove);
            this.groupBox1.Location = new System.Drawing.Point(-13, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 448);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnToolText
            // 
            this.btnToolText.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolText.Image = ((System.Drawing.Image)(resources.GetObject("btnToolText.Image")));
            this.btnToolText.Location = new System.Drawing.Point(158, 52);
            this.btnToolText.Name = "btnToolText";
            this.btnToolText.Size = new System.Drawing.Size(32, 32);
            this.btnToolText.TabIndex = 10;
            this.btnToolText.UseVisualStyleBackColor = true;
            this.btnToolText.CheckedChanged += new System.EventHandler(this.btnToolText_CheckedChanged);
            // 
            // btnToolFillBorder
            // 
            this.btnToolFillBorder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolFillBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolFillBorder.Image = ((System.Drawing.Image)(resources.GetObject("btnToolFillBorder.Image")));
            this.btnToolFillBorder.Location = new System.Drawing.Point(123, 88);
            this.btnToolFillBorder.Name = "btnToolFillBorder";
            this.btnToolFillBorder.Size = new System.Drawing.Size(32, 32);
            this.btnToolFillBorder.TabIndex = 14;
            this.btnToolFillBorder.UseVisualStyleBackColor = true;
            this.btnToolFillBorder.CheckedChanged += new System.EventHandler(this.btnToolFillBorder_CheckedChanged);
            // 
            // btnPaintBucket
            // 
            this.btnPaintBucket.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPaintBucket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaintBucket.Image = ((System.Drawing.Image)(resources.GetObject("btnPaintBucket.Image")));
            this.btnPaintBucket.Location = new System.Drawing.Point(88, 88);
            this.btnPaintBucket.Name = "btnPaintBucket";
            this.btnPaintBucket.Size = new System.Drawing.Size(32, 32);
            this.btnPaintBucket.TabIndex = 13;
            this.btnPaintBucket.UseVisualStyleBackColor = true;
            this.btnPaintBucket.CheckedChanged += new System.EventHandler(this.btnPaintBucket_CheckedChanged);
            // 
            // btnToolColorPicker
            // 
            this.btnToolColorPicker.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnToolColorPicker.Image")));
            this.btnToolColorPicker.Location = new System.Drawing.Point(53, 88);
            this.btnToolColorPicker.Name = "btnToolColorPicker";
            this.btnToolColorPicker.Size = new System.Drawing.Size(32, 32);
            this.btnToolColorPicker.TabIndex = 12;
            this.btnToolColorPicker.UseVisualStyleBackColor = true;
            this.btnToolColorPicker.CheckedChanged += new System.EventHandler(this.btnToolColorPicker_CheckedChanged);
            // 
            // btnToolEraser
            // 
            this.btnToolEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnToolEraser.Image")));
            this.btnToolEraser.Location = new System.Drawing.Point(123, 52);
            this.btnToolEraser.Name = "btnToolEraser";
            this.btnToolEraser.Size = new System.Drawing.Size(32, 32);
            this.btnToolEraser.TabIndex = 9;
            this.btnToolEraser.UseVisualStyleBackColor = true;
            this.btnToolEraser.CheckedChanged += new System.EventHandler(this.btnToolEraser_CheckedChanged);
            // 
            // btnToolBrush
            // 
            this.btnToolBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolBrush.Image = ((System.Drawing.Image)(resources.GetObject("btnToolBrush.Image")));
            this.btnToolBrush.Location = new System.Drawing.Point(88, 52);
            this.btnToolBrush.Name = "btnToolBrush";
            this.btnToolBrush.Size = new System.Drawing.Size(32, 32);
            this.btnToolBrush.TabIndex = 8;
            this.btnToolBrush.UseVisualStyleBackColor = true;
            this.btnToolBrush.CheckedChanged += new System.EventHandler(this.btnToolBrush_CheckedChanged);
            // 
            // btnToolPencil
            // 
            this.btnToolPencil.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnToolPencil.Image")));
            this.btnToolPencil.Location = new System.Drawing.Point(54, 52);
            this.btnToolPencil.Name = "btnToolPencil";
            this.btnToolPencil.Size = new System.Drawing.Size(32, 32);
            this.btnToolPencil.TabIndex = 7;
            this.btnToolPencil.UseVisualStyleBackColor = true;
            this.btnToolPencil.CheckedChanged += new System.EventHandler(this.btnToolPencil_CheckedChanged);
            // 
            // btnToolFreeFormShape
            // 
            this.btnToolFreeFormShape.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolFreeFormShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolFreeFormShape.Image = ((System.Drawing.Image)(resources.GetObject("btnToolFreeFormShape.Image")));
            this.btnToolFreeFormShape.Location = new System.Drawing.Point(158, 16);
            this.btnToolFreeFormShape.Name = "btnToolFreeFormShape";
            this.btnToolFreeFormShape.Size = new System.Drawing.Size(32, 32);
            this.btnToolFreeFormShape.TabIndex = 5;
            this.btnToolFreeFormShape.UseVisualStyleBackColor = true;
            this.btnToolFreeFormShape.CheckedChanged += new System.EventHandler(this.btnToolFreeFormShape_CheckedChanged);
            // 
            // btnToolLine
            // 
            this.btnToolLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolLine.Image = ((System.Drawing.Image)(resources.GetObject("btnToolLine.Image")));
            this.btnToolLine.Location = new System.Drawing.Point(18, 86);
            this.btnToolLine.Name = "btnToolLine";
            this.btnToolLine.Size = new System.Drawing.Size(32, 32);
            this.btnToolLine.TabIndex = 2;
            this.btnToolLine.UseVisualStyleBackColor = true;
            this.btnToolLine.CheckedChanged += new System.EventHandler(this.rdbtnToolLine_CheckedChanged);
            // 
            // btnToolRoundedRectangle
            // 
            this.btnToolRoundedRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolRoundedRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolRoundedRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnToolRoundedRectangle.Image")));
            this.btnToolRoundedRectangle.Location = new System.Drawing.Point(123, 16);
            this.btnToolRoundedRectangle.Name = "btnToolRoundedRectangle";
            this.btnToolRoundedRectangle.Size = new System.Drawing.Size(32, 32);
            this.btnToolRoundedRectangle.TabIndex = 15;
            this.btnToolRoundedRectangle.UseVisualStyleBackColor = true;
            this.btnToolRoundedRectangle.CheckedChanged += new System.EventHandler(this.btnToolRoundedRectangle_CheckedChanged);
            // 
            // btnToolEllipse
            // 
            this.btnToolEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnToolEllipse.Image")));
            this.btnToolEllipse.Location = new System.Drawing.Point(88, 16);
            this.btnToolEllipse.Name = "btnToolEllipse";
            this.btnToolEllipse.Size = new System.Drawing.Size(32, 32);
            this.btnToolEllipse.TabIndex = 3;
            this.btnToolEllipse.UseVisualStyleBackColor = true;
            this.btnToolEllipse.CheckedChanged += new System.EventHandler(this.rdbtnToolModeCircle_CheckedChanged);
            // 
            // btnToolCloneStamp
            // 
            this.btnToolCloneStamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolCloneStamp.Enabled = false;
            this.btnToolCloneStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolCloneStamp.Image = ((System.Drawing.Image)(resources.GetObject("btnToolCloneStamp.Image")));
            this.btnToolCloneStamp.Location = new System.Drawing.Point(158, 124);
            this.btnToolCloneStamp.Name = "btnToolCloneStamp";
            this.btnToolCloneStamp.Size = new System.Drawing.Size(32, 32);
            this.btnToolCloneStamp.TabIndex = 20;
            this.btnToolCloneStamp.UseVisualStyleBackColor = true;
            this.btnToolCloneStamp.CheckedChanged += new System.EventHandler(this.btnToolCloneStamp_CheckedChanged);
            // 
            // btnToolMagicWand
            // 
            this.btnToolMagicWand.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolMagicWand.Enabled = false;
            this.btnToolMagicWand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolMagicWand.Image = ((System.Drawing.Image)(resources.GetObject("btnToolMagicWand.Image")));
            this.btnToolMagicWand.Location = new System.Drawing.Point(123, 124);
            this.btnToolMagicWand.Name = "btnToolMagicWand";
            this.btnToolMagicWand.Size = new System.Drawing.Size(32, 32);
            this.btnToolMagicWand.TabIndex = 19;
            this.btnToolMagicWand.UseVisualStyleBackColor = true;
            this.btnToolMagicWand.CheckedChanged += new System.EventHandler(this.btnToolMagicWand_CheckedChanged);
            // 
            // btnToolLassoSelect
            // 
            this.btnToolLassoSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolLassoSelect.Enabled = false;
            this.btnToolLassoSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolLassoSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnToolLassoSelect.Image")));
            this.btnToolLassoSelect.Location = new System.Drawing.Point(88, 124);
            this.btnToolLassoSelect.Name = "btnToolLassoSelect";
            this.btnToolLassoSelect.Size = new System.Drawing.Size(32, 32);
            this.btnToolLassoSelect.TabIndex = 18;
            this.btnToolLassoSelect.UseVisualStyleBackColor = true;
            this.btnToolLassoSelect.CheckedChanged += new System.EventHandler(this.btnToolLassoSelect_CheckedChanged);
            // 
            // btnToolEllipseSelect
            // 
            this.btnToolEllipseSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolEllipseSelect.Enabled = false;
            this.btnToolEllipseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolEllipseSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnToolEllipseSelect.Image")));
            this.btnToolEllipseSelect.Location = new System.Drawing.Point(53, 124);
            this.btnToolEllipseSelect.Name = "btnToolEllipseSelect";
            this.btnToolEllipseSelect.Size = new System.Drawing.Size(32, 32);
            this.btnToolEllipseSelect.TabIndex = 17;
            this.btnToolEllipseSelect.UseVisualStyleBackColor = true;
            this.btnToolEllipseSelect.CheckedChanged += new System.EventHandler(this.btnToolEllipseSelect_CheckedChanged);
            // 
            // btnToolAdjust
            // 
            this.btnToolAdjust.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolAdjust.Enabled = false;
            this.btnToolAdjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolAdjust.Image = ((System.Drawing.Image)(resources.GetObject("btnToolAdjust.Image")));
            this.btnToolAdjust.Location = new System.Drawing.Point(18, 52);
            this.btnToolAdjust.Name = "btnToolAdjust";
            this.btnToolAdjust.Size = new System.Drawing.Size(32, 32);
            this.btnToolAdjust.TabIndex = 16;
            this.btnToolAdjust.UseVisualStyleBackColor = true;
            this.btnToolAdjust.CheckedChanged += new System.EventHandler(this.btnToolPan_CheckedChanged);
            // 
            // btnRectangleSelect
            // 
            this.btnRectangleSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRectangleSelect.Enabled = false;
            this.btnRectangleSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangleSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangleSelect.Image")));
            this.btnRectangleSelect.Location = new System.Drawing.Point(18, 124);
            this.btnRectangleSelect.Name = "btnRectangleSelect";
            this.btnRectangleSelect.Size = new System.Drawing.Size(32, 32);
            this.btnRectangleSelect.TabIndex = 11;
            this.btnRectangleSelect.UseVisualStyleBackColor = true;
            this.btnRectangleSelect.CheckedChanged += new System.EventHandler(this.btnRectangleSelect_CheckedChanged);
            // 
            // btnToolCurve
            // 
            this.btnToolCurve.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolCurve.Image = ((System.Drawing.Image)(resources.GetObject("btnToolCurve.Image")));
            this.btnToolCurve.Location = new System.Drawing.Point(158, 88);
            this.btnToolCurve.Name = "btnToolCurve";
            this.btnToolCurve.Size = new System.Drawing.Size(32, 32);
            this.btnToolCurve.TabIndex = 6;
            this.btnToolCurve.UseVisualStyleBackColor = true;
            this.btnToolCurve.CheckedChanged += new System.EventHandler(this.btnToolSparyPaint_CheckedChanged);
            // 
            // btnToolRectangle
            // 
            this.btnToolRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnToolRectangle.Image")));
            this.btnToolRectangle.Location = new System.Drawing.Point(53, 16);
            this.btnToolRectangle.Name = "btnToolRectangle";
            this.btnToolRectangle.Size = new System.Drawing.Size(32, 32);
            this.btnToolRectangle.TabIndex = 4;
            this.btnToolRectangle.UseVisualStyleBackColor = true;
            this.btnToolRectangle.CheckedChanged += new System.EventHandler(this.rdbtnToolModeRectangle_CheckedChanged);
            // 
            // btnToolSelectAndMove
            // 
            this.btnToolSelectAndMove.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToolSelectAndMove.Checked = true;
            this.btnToolSelectAndMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolSelectAndMove.Image = ((System.Drawing.Image)(resources.GetObject("btnToolSelectAndMove.Image")));
            this.btnToolSelectAndMove.Location = new System.Drawing.Point(18, 16);
            this.btnToolSelectAndMove.Name = "btnToolSelectAndMove";
            this.btnToolSelectAndMove.Size = new System.Drawing.Size(32, 32);
            this.btnToolSelectAndMove.TabIndex = 1;
            this.btnToolSelectAndMove.TabStop = true;
            this.btnToolSelectAndMove.UseVisualStyleBackColor = true;
            this.btnToolSelectAndMove.CheckedChanged += new System.EventHandler(this.btnToolSelectAndMove_CheckedChanged);
            // 
            // ToolBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 380);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "工具箱";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ToolBoxForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblEraserStyle;
        private System.Windows.Forms.Label lblLineAndCurve;
        private System.Windows.Forms.ComboBox cboEraserWidth;
        private System.Windows.Forms.ComboBox cboLineWidth;
        private System.Windows.Forms.Label lblEraser;
        private System.Windows.Forms.Label lblLineWidth;
        private System.Windows.Forms.ComboBox cboBrushWidth;
        private System.Windows.Forms.Label lblBrush;
        private System.Windows.Forms.Label lblBrushWidth;
        private System.Windows.Forms.Label lblBrushStyle;
        private System.Windows.Forms.ComboBox cboBrushStyle;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnToolText;
        private System.Windows.Forms.RadioButton btnToolFillBorder;
        private System.Windows.Forms.RadioButton btnPaintBucket;
        private System.Windows.Forms.RadioButton btnToolColorPicker;
        private System.Windows.Forms.RadioButton btnToolEraser;
        private System.Windows.Forms.RadioButton btnToolBrush;
        private System.Windows.Forms.RadioButton btnToolPencil;
        private System.Windows.Forms.RadioButton btnToolFreeFormShape;
        private System.Windows.Forms.RadioButton btnToolLine;
        private System.Windows.Forms.RadioButton btnToolRoundedRectangle;
        private System.Windows.Forms.RadioButton btnToolEllipse;
        private System.Windows.Forms.RadioButton btnToolCloneStamp;
        private System.Windows.Forms.RadioButton btnToolMagicWand;
        private System.Windows.Forms.RadioButton btnToolLassoSelect;
        private System.Windows.Forms.RadioButton btnToolEllipseSelect;
        private System.Windows.Forms.RadioButton btnToolAdjust;
        private System.Windows.Forms.RadioButton btnRectangleSelect;
        private System.Windows.Forms.RadioButton btnToolCurve;
        private System.Windows.Forms.RadioButton btnToolRectangle;
        private System.Windows.Forms.RadioButton btnToolSelectAndMove;






    }
}