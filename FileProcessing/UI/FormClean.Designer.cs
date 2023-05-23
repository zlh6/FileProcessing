namespace FileProcessing
{
    partial class FormClean
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClean));
            this.textBox目标目录 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button浏览 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox清理列表 = new System.Windows.Forms.CheckedListBox();
            this.button扫描 = new System.Windows.Forms.Button();
            this.checkBox全选 = new System.Windows.Forms.CheckBox();
            this.button反选 = new System.Windows.Forms.Button();
            this.button一键清理 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel状态指示 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开文件夹位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox目标目录
            // 
            this.textBox目标目录.AllowDrop = true;
            this.textBox目标目录.Location = new System.Drawing.Point(147, 48);
            this.textBox目标目录.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox目标目录.Name = "textBox目标目录";
            this.textBox目标目录.Size = new System.Drawing.Size(389, 25);
            this.textBox目标目录.TabIndex = 0;
            this.textBox目标目录.TextChanged += new System.EventHandler(this.TextBox目标目录_TextChanged);
            this.textBox目标目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox目标目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // button浏览
            // 
            this.button浏览.Location = new System.Drawing.Point(543, 48);
            this.button浏览.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button浏览.Name = "button浏览";
            this.button浏览.Size = new System.Drawing.Size(41, 22);
            this.button浏览.TabIndex = 1;
            this.button浏览.Text = "...";
            this.button浏览.UseVisualStyleBackColor = true;
            this.button浏览.Click += new System.EventHandler(this.Button浏览_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标目录：";
            // 
            // checkedListBox清理列表
            // 
            this.checkedListBox清理列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox清理列表.CheckOnClick = true;
            this.checkedListBox清理列表.ColumnWidth = 440;
            this.checkedListBox清理列表.FormattingEnabled = true;
            this.checkedListBox清理列表.Location = new System.Drawing.Point(47, 142);
            this.checkedListBox清理列表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox清理列表.Name = "checkedListBox清理列表";
            this.checkedListBox清理列表.Size = new System.Drawing.Size(813, 444);
            this.checkedListBox清理列表.TabIndex = 4;
            this.checkedListBox清理列表.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox清理列表_ItemCheck);
            this.checkedListBox清理列表.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBox清理列表_MouseUp);
            // 
            // button扫描
            // 
            this.button扫描.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button扫描.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button扫描.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button扫描.Location = new System.Drawing.Point(649, 35);
            this.button扫描.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button扫描.Name = "button扫描";
            this.button扫描.Size = new System.Drawing.Size(91, 45);
            this.button扫描.TabIndex = 5;
            this.button扫描.Text = "开始扫描";
            this.button扫描.UseVisualStyleBackColor = true;
            this.button扫描.Click += new System.EventHandler(this.Button扫描_Click);
            // 
            // checkBox全选
            // 
            this.checkBox全选.AutoSize = true;
            this.checkBox全选.Checked = true;
            this.checkBox全选.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox全选.Location = new System.Drawing.Point(47, 118);
            this.checkBox全选.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox全选.Name = "checkBox全选";
            this.checkBox全选.Size = new System.Drawing.Size(59, 19);
            this.checkBox全选.TabIndex = 6;
            this.checkBox全选.Text = "全选";
            this.checkBox全选.UseVisualStyleBackColor = true;
            this.checkBox全选.CheckedChanged += new System.EventHandler(this.CheckBox全选_CheckedChanged);
            // 
            // button反选
            // 
            this.button反选.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button反选.Location = new System.Drawing.Point(111, 115);
            this.button反选.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button反选.Name = "button反选";
            this.button反选.Size = new System.Drawing.Size(52, 22);
            this.button反选.TabIndex = 7;
            this.button反选.Text = "反选";
            this.button反选.UseVisualStyleBackColor = true;
            this.button反选.Click += new System.EventHandler(this.Button反选_Click);
            // 
            // button一键清理
            // 
            this.button一键清理.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button一键清理.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button一键清理.Enabled = false;
            this.button一键清理.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button一键清理.Location = new System.Drawing.Point(769, 35);
            this.button一键清理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button一键清理.Name = "button一键清理";
            this.button一键清理.Size = new System.Drawing.Size(91, 45);
            this.button一键清理.TabIndex = 8;
            this.button一键清理.Text = "一键清理";
            this.button一键清理.UseVisualStyleBackColor = true;
            this.button一键清理.Click += new System.EventHandler(this.Button一键清理_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(268, 20);
            this.toolStripStatusLabel1.Text = "一共有 0 个空目录，选中了 0 个空目录";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(440, 18);
            // 
            // toolStripStatusLabel状态指示
            // 
            this.toolStripStatusLabel状态指示.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel状态指示.Name = "toolStripStatusLabel状态指示";
            this.toolStripStatusLabel状态指示.Size = new System.Drawing.Size(171, 20);
            this.toolStripStatusLabel状态指示.Spring = true;
            this.toolStripStatusLabel状态指示.Text = "未开始";
            this.toolStripStatusLabel状态指示.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel状态指示});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(901, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件夹位置ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // 打开文件夹位置ToolStripMenuItem
            // 
            this.打开文件夹位置ToolStripMenuItem.Name = "打开文件夹位置ToolStripMenuItem";
            this.打开文件夹位置ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.打开文件夹位置ToolStripMenuItem.Text = "打开文件夹位置";
            this.打开文件夹位置ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹位置ToolStripMenuItem_Click);
            // 
            // FormClean
            // 
            this.AcceptButton = this.button扫描;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 642);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button一键清理);
            this.Controls.Add(this.button反选);
            this.Controls.Add(this.checkBox全选);
            this.Controls.Add(this.button扫描);
            this.Controls.Add(this.checkedListBox清理列表);
            this.Controls.Add(this.button浏览);
            this.Controls.Add(this.textBox目标目录);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "清理空目录";
            this.Load += new System.EventHandler(this.FormClean_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox目标目录;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button浏览;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox清理列表;
        private System.Windows.Forms.Button button扫描;
        private System.Windows.Forms.CheckBox checkBox全选;
        private System.Windows.Forms.Button button反选;
        private System.Windows.Forms.Button button一键清理;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel状态指示;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹位置ToolStripMenuItem;
    }
}

