namespace FileProcessing
{
    partial class Form批量改名
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form批量改名));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton全名一致 = new System.Windows.Forms.RadioButton();
            this.radioButton包含其中 = new System.Windows.Forms.RadioButton();
            this.textBox操作目录 = new System.Windows.Forms.TextBox();
            this.button开始执行 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox文件名 = new System.Windows.Forms.CheckBox();
            this.checkBox子目录名 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox欲替换字 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox作替换字 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "操作目录：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(143, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "批量改名";
            // 
            // radioButton全名一致
            // 
            this.radioButton全名一致.AutoSize = true;
            this.radioButton全名一致.Location = new System.Drawing.Point(18, 33);
            this.radioButton全名一致.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton全名一致.Name = "radioButton全名一致";
            this.radioButton全名一致.Size = new System.Drawing.Size(71, 16);
            this.radioButton全名一致.TabIndex = 11;
            this.radioButton全名一致.Text = "全名一致";
            this.radioButton全名一致.UseVisualStyleBackColor = true;
            // 
            // radioButton包含其中
            // 
            this.radioButton包含其中.AutoSize = true;
            this.radioButton包含其中.Checked = true;
            this.radioButton包含其中.Location = new System.Drawing.Point(18, 67);
            this.radioButton包含其中.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton包含其中.Name = "radioButton包含其中";
            this.radioButton包含其中.Size = new System.Drawing.Size(71, 16);
            this.radioButton包含其中.TabIndex = 12;
            this.radioButton包含其中.TabStop = true;
            this.radioButton包含其中.Text = "包含其中";
            this.radioButton包含其中.UseVisualStyleBackColor = true;
            // 
            // textBox操作目录
            // 
            this.textBox操作目录.AllowDrop = true;
            this.textBox操作目录.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox操作目录.Location = new System.Drawing.Point(56, 115);
            this.textBox操作目录.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox操作目录.Multiline = true;
            this.textBox操作目录.Name = "textBox操作目录";
            this.textBox操作目录.Size = new System.Drawing.Size(324, 33);
            this.textBox操作目录.TabIndex = 22;
            this.textBox操作目录.TextChanged += new System.EventHandler(this.TextBox操作目录_TextChanged);
            this.textBox操作目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox操作目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // button开始执行
            // 
            this.button开始执行.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button开始执行.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始执行.Location = new System.Drawing.Point(328, 270);
            this.button开始执行.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button开始执行.Name = "button开始执行";
            this.button开始执行.Size = new System.Drawing.Size(52, 54);
            this.button开始执行.TabIndex = 27;
            this.button开始执行.Text = "开始执行";
            this.button开始执行.UseVisualStyleBackColor = true;
            this.button开始执行.Click += new System.EventHandler(this.Button开始执行_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton全名一致);
            this.groupBox2.Controls.Add(this.radioButton包含其中);
            this.groupBox2.Location = new System.Drawing.Point(172, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(120, 104);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "匹配条件";
            // 
            // checkBox文件名
            // 
            this.checkBox文件名.AutoSize = true;
            this.checkBox文件名.Checked = true;
            this.checkBox文件名.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox文件名.Location = new System.Drawing.Point(10, 34);
            this.checkBox文件名.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox文件名.Name = "checkBox文件名";
            this.checkBox文件名.Size = new System.Drawing.Size(60, 16);
            this.checkBox文件名.TabIndex = 19;
            this.checkBox文件名.Text = "文件名";
            this.checkBox文件名.UseVisualStyleBackColor = true;
            // 
            // checkBox子目录名
            // 
            this.checkBox子目录名.AutoSize = true;
            this.checkBox子目录名.Location = new System.Drawing.Point(10, 68);
            this.checkBox子目录名.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox子目录名.Name = "checkBox子目录名";
            this.checkBox子目录名.Size = new System.Drawing.Size(72, 16);
            this.checkBox子目录名.TabIndex = 20;
            this.checkBox子目录名.Text = "子目录名";
            this.checkBox子目录名.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox文件名);
            this.groupBox1.Controls.Add(this.checkBox子目录名);
            this.groupBox1.Location = new System.Drawing.Point(56, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(85, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改对象";
            // 
            // textBox欲替换字
            // 
            this.textBox欲替换字.AllowDrop = true;
            this.textBox欲替换字.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox欲替换字.Location = new System.Drawing.Point(56, 186);
            this.textBox欲替换字.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox欲替换字.Multiline = true;
            this.textBox欲替换字.Name = "textBox欲替换字";
            this.textBox欲替换字.Size = new System.Drawing.Size(147, 33);
            this.textBox欲替换字.TabIndex = 24;
            this.textBox欲替换字.TextChanged += new System.EventHandler(this.TextBox欲替换字_TextChanged);
            this.textBox欲替换字.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox关键字_DragDrop);
            this.textBox欲替换字.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "欲替换的字：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(229, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "用作替换的字：";
            // 
            // textBox作替换字
            // 
            this.textBox作替换字.AllowDrop = true;
            this.textBox作替换字.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox作替换字.Location = new System.Drawing.Point(232, 186);
            this.textBox作替换字.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox作替换字.Multiline = true;
            this.textBox作替换字.Name = "textBox作替换字";
            this.textBox作替换字.Size = new System.Drawing.Size(147, 33);
            this.textBox作替换字.TabIndex = 32;
            this.textBox作替换字.TextChanged += new System.EventHandler(this.TextBox作替换字_TextChanged);
            this.textBox作替换字.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox关键字_DragDrop);
            this.textBox作替换字.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // Form批量改名
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 378);
            this.Controls.Add(this.textBox作替换字);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox欲替换字);
            this.Controls.Add(this.textBox操作目录);
            this.Controls.Add(this.button开始执行);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form批量改名";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 批量改名";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton全名一致;
        private System.Windows.Forms.RadioButton radioButton包含其中;
        private System.Windows.Forms.TextBox textBox操作目录;
        private System.Windows.Forms.Button button开始执行;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox文件名;
        private System.Windows.Forms.CheckBox checkBox子目录名;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox欲替换字;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox作替换字;
    }
}