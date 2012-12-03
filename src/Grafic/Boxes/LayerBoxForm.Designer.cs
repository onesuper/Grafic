namespace Grafic.Boxes
{
    partial class LayerBoxForm
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
            this.lstLayerList = new System.Windows.Forms.ListView();
            this.colLayer = new System.Windows.Forms.ColumnHeader();
            this.colType = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lstLayerList
            // 
            this.lstLayerList.CheckBoxes = true;
            this.lstLayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLayer,
            this.colType});
            this.lstLayerList.Location = new System.Drawing.Point(2, 5);
            this.lstLayerList.Name = "lstLayerList";
            this.lstLayerList.Size = new System.Drawing.Size(188, 146);
            this.lstLayerList.TabIndex = 0;
            this.lstLayerList.UseCompatibleStateImageBehavior = false;
            this.lstLayerList.View = System.Windows.Forms.View.Details;
            this.lstLayerList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstLayerList_ItemChecked);
            this.lstLayerList.SelectedIndexChanged += new System.EventHandler(this.lstLayerList_SelectedIndexChanged);
            // 
            // colLayer
            // 
            this.colLayer.Text = "[V] 图层";
            this.colLayer.Width = 110;
            // 
            // colType
            // 
            this.colType.Text = "类型";
            this.colType.Width = 70;
            // 
            // LayerBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 163);
            this.Controls.Add(this.lstLayerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1000, 536);
            this.Name = "LayerBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "图层窗";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayerBoxForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLayerList;
        private System.Windows.Forms.ColumnHeader colLayer;
        private System.Windows.Forms.ColumnHeader colType;
    }
}