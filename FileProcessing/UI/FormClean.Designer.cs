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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClean));
            this.textBox目标目录 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button浏览 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox清理列表 = new System.Windows.Forms.CheckedListBox();
            this.button执行 = new System.Windows.Forms.Button();
            this.checkBox全选 = new System.Windows.Forms.CheckBox();
            this.button反选 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox目标目录
            // 
            this.textBox目标目录.AllowDrop = true;
            this.textBox目标目录.Location = new System.Drawing.Point(151, 47);
            this.textBox目标目录.Name = "textBox目标目录";
            this.textBox目标目录.Size = new System.Drawing.Size(524, 25);
            this.textBox目标目录.TabIndex = 0;
            this.textBox目标目录.TextChanged += new System.EventHandler(this.TextBox目标目录_TextChanged);
            this.textBox目标目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox目标目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // button浏览
            // 
            this.button浏览.Location = new System.Drawing.Point(681, 50);
            this.button浏览.Name = "button浏览";
            this.button浏览.Size = new System.Drawing.Size(41, 23);
            this.button浏览.TabIndex = 1;
            this.button浏览.Text = "...";
            this.button浏览.UseVisualStyleBackColor = true;
            this.button浏览.Click += new System.EventHandler(this.Button浏览_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标目录：";
            // 
            // checkedListBox清理列表
            // 
            this.checkedListBox清理列表.CheckOnClick = true;
            this.checkedListBox清理列表.FormattingEnabled = true;
            this.checkedListBox清理列表.Location = new System.Drawing.Point(50, 152);
            this.checkedListBox清理列表.Name = "checkedListBox清理列表";
            this.checkedListBox清理列表.Size = new System.Drawing.Size(1165, 484);
            this.checkedListBox清理列表.TabIndex = 4;
            // 
            // button执行
            // 
            this.button执行.Location = new System.Drawing.Point(1125, 35);
            this.button执行.Name = "button执行";
            this.button执行.Size = new System.Drawing.Size(90, 45);
            this.button执行.TabIndex = 5;
            this.button执行.Text = "开始扫描";
            this.button执行.UseVisualStyleBackColor = true;
            this.button执行.Click += new System.EventHandler(this.Button执行_Click);
            // 
            // checkBox全选
            // 
            this.checkBox全选.AutoSize = true;
            this.checkBox全选.Checked = true;
            this.checkBox全选.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox全选.Location = new System.Drawing.Point(50, 127);
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
            this.button反选.Location = new System.Drawing.Point(115, 125);
            this.button反选.Name = "button反选";
            this.button反选.Size = new System.Drawing.Size(52, 23);
            this.button反选.TabIndex = 7;
            this.button反选.Text = "反选";
            this.button反选.UseVisualStyleBackColor = true;
            this.button反选.Click += new System.EventHandler(this.Button反选_Click);
            // 
            // FormClean
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button反选);
            this.Controls.Add(this.checkBox全选);
            this.Controls.Add(this.button执行);
            this.Controls.Add(this.checkedListBox清理列表);
            this.Controls.Add(this.button浏览);
            this.Controls.Add(this.textBox目标目录);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "清理空目录";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox目标目录;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button浏览;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox清理列表;
        private System.Windows.Forms.Button button执行;
        private System.Windows.Forms.CheckBox checkBox全选;
        private System.Windows.Forms.Button button反选;
    }
}

