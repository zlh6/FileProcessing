namespace FileProcessing
{
    partial class Form文件删除
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form文件删除));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button开始删除 = new System.Windows.Forms.Button();
            this.textBox目标文件 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox操作目录 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox文件大小 = new System.Windows.Forms.TextBox();
            this.textBoxMD5值 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(71, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "目标文件：";
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
            // button开始删除
            // 
            this.button开始删除.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button开始删除.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始删除.Location = new System.Drawing.Point(441, 315);
            this.button开始删除.Name = "button开始删除";
            this.button开始删除.Size = new System.Drawing.Size(69, 67);
            this.button开始删除.TabIndex = 13;
            this.button开始删除.Text = "开始删除";
            this.button开始删除.UseVisualStyleBackColor = true;
            this.button开始删除.Click += new System.EventHandler(this.Button开始提取_Click);
            // 
            // textBox目标文件
            // 
            this.textBox目标文件.AllowDrop = true;
            this.textBox目标文件.Location = new System.Drawing.Point(79, 244);
            this.textBox目标文件.Multiline = true;
            this.textBox目标文件.Name = "textBox目标文件";
            this.textBox目标文件.Size = new System.Drawing.Size(431, 40);
            this.textBox目标文件.TabIndex = 10;
            this.textBox目标文件.TextChanged += new System.EventHandler(this.目标文件_TextChanged);
            this.textBox目标文件.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox目标文件.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(195, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "文件删除";
            // 
            // textBox操作目录
            // 
            this.textBox操作目录.AllowDrop = true;
            this.textBox操作目录.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox操作目录.Location = new System.Drawing.Point(79, 149);
            this.textBox操作目录.Multiline = true;
            this.textBox操作目录.Name = "textBox操作目录";
            this.textBox操作目录.Size = new System.Drawing.Size(431, 40);
            this.textBox操作目录.TabIndex = 8;
            this.textBox操作目录.TextChanged += new System.EventHandler(this.操作目录_TextChanged);
            this.textBox操作目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox操作目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "文件大小：";
            // 
            // textBox文件大小
            // 
            this.textBox文件大小.Location = new System.Drawing.Point(151, 318);
            this.textBox文件大小.Name = "textBox文件大小";
            this.textBox文件大小.ReadOnly = true;
            this.textBox文件大小.Size = new System.Drawing.Size(79, 25);
            this.textBox文件大小.TabIndex = 17;
            this.textBox文件大小.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMD5值
            // 
            this.textBoxMD5值.Location = new System.Drawing.Point(132, 357);
            this.textBoxMD5值.Name = "textBoxMD5值";
            this.textBoxMD5值.ReadOnly = true;
            this.textBoxMD5值.Size = new System.Drawing.Size(271, 25);
            this.textBoxMD5值.TabIndex = 19;
            this.textBoxMD5值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "MD5值：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "KB";
            // 
            // Form文件删除
            // 
            this.AcceptButton = this.button开始删除;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMD5值);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox文件大小);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button开始删除);
            this.Controls.Add(this.textBox目标文件);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox操作目录);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form文件删除";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件删除";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox目标文件;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox操作目录;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox文件大小;
        private System.Windows.Forms.TextBox textBoxMD5值;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button开始删除;
    }
}