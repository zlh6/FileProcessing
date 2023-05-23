namespace FileProcessing
{
    partial class Form批量更名
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form批量更名));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton加在后面 = new System.Windows.Forms.RadioButton();
            this.radioButton加在前面 = new System.Windows.Forms.RadioButton();
            this.textBox关键字 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox操作目录 = new System.Windows.Forms.TextBox();
            this.radioButton从名称中删除 = new System.Windows.Forms.RadioButton();
            this.button开始执行 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox文件名 = new System.Windows.Forms.CheckBox();
            this.checkBox子目录名 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(71, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "关键字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(71, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "操作目录：";
            // 
            // radioButton加在后面
            // 
            this.radioButton加在后面.AutoSize = true;
            this.radioButton加在后面.Location = new System.Drawing.Point(24, 65);
            this.radioButton加在后面.Name = "radioButton加在后面";
            this.radioButton加在后面.Size = new System.Drawing.Size(88, 19);
            this.radioButton加在后面.TabIndex = 12;
            this.radioButton加在后面.Text = "加在后面";
            this.radioButton加在后面.UseVisualStyleBackColor = true;
            // 
            // radioButton加在前面
            // 
            this.radioButton加在前面.AutoSize = true;
            this.radioButton加在前面.Location = new System.Drawing.Point(24, 27);
            this.radioButton加在前面.Name = "radioButton加在前面";
            this.radioButton加在前面.Size = new System.Drawing.Size(88, 19);
            this.radioButton加在前面.TabIndex = 11;
            this.radioButton加在前面.Text = "加在前面";
            this.radioButton加在前面.UseVisualStyleBackColor = true;
            // 
            // textBox关键字
            // 
            this.textBox关键字.AllowDrop = true;
            this.textBox关键字.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox关键字.Location = new System.Drawing.Point(75, 238);
            this.textBox关键字.Multiline = true;
            this.textBox关键字.Name = "textBox关键字";
            this.textBox关键字.Size = new System.Drawing.Size(431, 40);
            this.textBox关键字.TabIndex = 10;
            this.textBox关键字.TextChanged += new System.EventHandler(this.TextBox关键字_TextChanged);
            this.textBox关键字.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox关键字_DragDrop);
            this.textBox关键字.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(191, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "批量更名";
            // 
            // textBox操作目录
            // 
            this.textBox操作目录.AllowDrop = true;
            this.textBox操作目录.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox操作目录.Location = new System.Drawing.Point(75, 149);
            this.textBox操作目录.Multiline = true;
            this.textBox操作目录.Name = "textBox操作目录";
            this.textBox操作目录.Size = new System.Drawing.Size(431, 40);
            this.textBox操作目录.TabIndex = 8;
            this.textBox操作目录.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox操作目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox操作目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // radioButton从名称中删除
            // 
            this.radioButton从名称中删除.AutoSize = true;
            this.radioButton从名称中删除.Checked = true;
            this.radioButton从名称中删除.Location = new System.Drawing.Point(24, 104);
            this.radioButton从名称中删除.Name = "radioButton从名称中删除";
            this.radioButton从名称中删除.Size = new System.Drawing.Size(118, 19);
            this.radioButton从名称中删除.TabIndex = 16;
            this.radioButton从名称中删除.TabStop = true;
            this.radioButton从名称中删除.Text = "从名称中删除";
            this.radioButton从名称中删除.UseVisualStyleBackColor = true;
            // 
            // button开始执行
            // 
            this.button开始执行.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button开始执行.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始执行.Location = new System.Drawing.Point(437, 349);
            this.button开始执行.Name = "button开始执行";
            this.button开始执行.Size = new System.Drawing.Size(69, 67);
            this.button开始执行.TabIndex = 17;
            this.button开始执行.Text = "开始执行";
            this.button开始执行.UseVisualStyleBackColor = true;
            this.button开始执行.Click += new System.EventHandler(this.Button开始执行_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton加在前面);
            this.groupBox2.Controls.Add(this.radioButton从名称中删除);
            this.groupBox2.Controls.Add(this.radioButton加在后面);
            this.groupBox2.Location = new System.Drawing.Point(230, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 143);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改方式";
            // 
            // checkBox文件名
            // 
            this.checkBox文件名.AutoSize = true;
            this.checkBox文件名.Checked = true;
            this.checkBox文件名.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox文件名.Location = new System.Drawing.Point(13, 42);
            this.checkBox文件名.Name = "checkBox文件名";
            this.checkBox文件名.Size = new System.Drawing.Size(74, 19);
            this.checkBox文件名.TabIndex = 19;
            this.checkBox文件名.Text = "文件名";
            this.checkBox文件名.UseVisualStyleBackColor = true;
            // 
            // checkBox子目录名
            // 
            this.checkBox子目录名.AutoSize = true;
            this.checkBox子目录名.Location = new System.Drawing.Point(13, 90);
            this.checkBox子目录名.Name = "checkBox子目录名";
            this.checkBox子目录名.Size = new System.Drawing.Size(89, 19);
            this.checkBox子目录名.TabIndex = 20;
            this.checkBox子目录名.Text = "子目录名";
            this.checkBox子目录名.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox文件名);
            this.groupBox1.Controls.Add(this.checkBox子目录名);
            this.groupBox1.Location = new System.Drawing.Point(75, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 143);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改对象";
            // 
            // Form批量更名
            // 
            this.AcceptButton = this.button开始执行;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 481);
            this.Controls.Add(this.button开始执行);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox关键字);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox操作目录);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form批量更名";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "批量更名";
            this.Load += new System.EventHandler(this.Form批量改名_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton加在后面;
        private System.Windows.Forms.RadioButton radioButton加在前面;
        private System.Windows.Forms.TextBox textBox关键字;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox操作目录;
        private System.Windows.Forms.RadioButton radioButton从名称中删除;
        private System.Windows.Forms.Button button开始执行;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox文件名;
        private System.Windows.Forms.CheckBox checkBox子目录名;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}