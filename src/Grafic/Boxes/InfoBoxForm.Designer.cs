namespace Grafic.Boxes
{
    partial class InfoBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoBoxForm));
            this.picCursorXY = new System.Windows.Forms.PictureBox();
            this.picImageSize = new System.Windows.Forms.PictureBox();
            this.lblCursorX = new System.Windows.Forms.Label();
            this.lblCursorY = new System.Windows.Forms.Label();
            this.lblImageWidth = new System.Windows.Forms.Label();
            this.lblImageHeight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblColorR = new System.Windows.Forms.Label();
            this.lblColorG = new System.Windows.Forms.Label();
            this.lblColorB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCursorXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picCursorXY
            // 
            this.picCursorXY.Image = ((System.Drawing.Image)(resources.GetObject("picCursorXY.Image")));
            this.picCursorXY.Location = new System.Drawing.Point(13, 91);
            this.picCursorXY.Name = "picCursorXY";
            this.picCursorXY.Size = new System.Drawing.Size(16, 16);
            this.picCursorXY.TabIndex = 0;
            this.picCursorXY.TabStop = false;
            // 
            // picImageSize
            // 
            this.picImageSize.Image = ((System.Drawing.Image)(resources.GetObject("picImageSize.Image")));
            this.picImageSize.Location = new System.Drawing.Point(94, 91);
            this.picImageSize.Name = "picImageSize";
            this.picImageSize.Size = new System.Drawing.Size(16, 16);
            this.picImageSize.TabIndex = 1;
            this.picImageSize.TabStop = false;
            // 
            // lblCursorX
            // 
            this.lblCursorX.AutoSize = true;
            this.lblCursorX.Location = new System.Drawing.Point(44, 91);
            this.lblCursorX.Name = "lblCursorX";
            this.lblCursorX.Size = new System.Drawing.Size(17, 12);
            this.lblCursorX.TabIndex = 2;
            this.lblCursorX.Text = "X:";
            // 
            // lblCursorY
            // 
            this.lblCursorY.AutoSize = true;
            this.lblCursorY.Location = new System.Drawing.Point(44, 103);
            this.lblCursorY.Name = "lblCursorY";
            this.lblCursorY.Size = new System.Drawing.Size(17, 12);
            this.lblCursorY.TabIndex = 3;
            this.lblCursorY.Text = "Y:";
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.Location = new System.Drawing.Point(128, 91);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(17, 12);
            this.lblImageWidth.TabIndex = 4;
            this.lblImageWidth.Text = "W:";
            // 
            // lblImageHeight
            // 
            this.lblImageHeight.AutoSize = true;
            this.lblImageHeight.Location = new System.Drawing.Point(128, 103);
            this.lblImageHeight.Name = "lblImageHeight";
            this.lblImageHeight.Size = new System.Drawing.Size(17, 12);
            this.lblImageHeight.TabIndex = 5;
            this.lblImageHeight.Text = "H:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblColorR
            // 
            this.lblColorR.AutoSize = true;
            this.lblColorR.Location = new System.Drawing.Point(44, 17);
            this.lblColorR.Name = "lblColorR";
            this.lblColorR.Size = new System.Drawing.Size(17, 12);
            this.lblColorR.TabIndex = 7;
            this.lblColorR.Text = "R:";
            // 
            // lblColorG
            // 
            this.lblColorG.AutoSize = true;
            this.lblColorG.Location = new System.Drawing.Point(44, 29);
            this.lblColorG.Name = "lblColorG";
            this.lblColorG.Size = new System.Drawing.Size(17, 12);
            this.lblColorG.TabIndex = 8;
            this.lblColorG.Text = "G:";
            // 
            // lblColorB
            // 
            this.lblColorB.AutoSize = true;
            this.lblColorB.Location = new System.Drawing.Point(44, 41);
            this.lblColorB.Name = "lblColorB";
            this.lblColorB.Size = new System.Drawing.Size(17, 12);
            this.lblColorB.TabIndex = 9;
            this.lblColorB.Text = "B:";
            // 
            // InfoBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 176);
            this.Controls.Add(this.lblColorB);
            this.Controls.Add(this.lblColorG);
            this.Controls.Add(this.lblColorR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblImageHeight);
            this.Controls.Add(this.lblImageWidth);
            this.Controls.Add(this.lblCursorY);
            this.Controls.Add(this.lblCursorX);
            this.Controls.Add(this.picImageSize);
            this.Controls.Add(this.picCursorXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1000, 150);
            this.Name = "InfoBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "信息栏";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoBoxForm_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCursorXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCursorXY;
        private System.Windows.Forms.PictureBox picImageSize;
        private System.Windows.Forms.Label lblCursorX;
        private System.Windows.Forms.Label lblCursorY;
        private System.Windows.Forms.Label lblImageWidth;
        private System.Windows.Forms.Label lblImageHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblColorR;
        private System.Windows.Forms.Label lblColorG;
        private System.Windows.Forms.Label lblColorB;
    }
}