namespace FileProcessing
{
    partial class Form文件插入
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form文件插入));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button开始插入 = new System.Windows.Forms.Button();
            this.textBox目标文件 = new System.Windows.Forms.TextBox();
            this.textBox操作目录 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(69, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "要插入的文件或文件夹：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(69, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "目标目录：";
            // 
            // button开始插入
            // 
            this.button开始插入.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button开始插入.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始插入.Location = new System.Drawing.Point(378, 338);
            this.button开始插入.Name = "button开始插入";
            this.button开始插入.Size = new System.Drawing.Size(130, 54);
            this.button开始插入.TabIndex = 24;
            this.button开始插入.Text = "开始插入";
            this.button开始插入.UseVisualStyleBackColor = true;
            this.button开始插入.Click += new System.EventHandler(this.Button开始插入_Click);
            // 
            // textBox目标文件
            // 
            this.textBox目标文件.AllowDrop = true;
            this.textBox目标文件.Location = new System.Drawing.Point(77, 249);
            this.textBox目标文件.Multiline = true;
            this.textBox目标文件.Name = "textBox目标文件";
            this.textBox目标文件.Size = new System.Drawing.Size(431, 40);
            this.textBox目标文件.TabIndex = 23;
            this.textBox目标文件.TextChanged += new System.EventHandler(this.TextBox目标文件_TextChanged);
            this.textBox目标文件.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox目标文件.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // textBox操作目录
            // 
            this.textBox操作目录.AllowDrop = true;
            this.textBox操作目录.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox操作目录.Location = new System.Drawing.Point(77, 154);
            this.textBox操作目录.Multiline = true;
            this.textBox操作目录.Name = "textBox操作目录";
            this.textBox操作目录.Size = new System.Drawing.Size(431, 40);
            this.textBox操作目录.TabIndex = 21;
            this.textBox操作目录.TextChanged += new System.EventHandler(this.TextBox操作目录_TextChanged);
            this.textBox操作目录.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox操作目录.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 22;
            this.label1.Text = "文件插入";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 19);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "插入夹里的文件";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 19);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "插入整个文件夹";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(77, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "若要插入的是文件夹：";
            // 
            // Form文件插入
            // 
            this.AcceptButton = this.button开始插入;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button开始插入);
            this.Controls.Add(this.textBox目标文件);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox操作目录);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form文件插入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件插入";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button开始插入;
        private System.Windows.Forms.TextBox textBox目标文件;
        private System.Windows.Forms.TextBox textBox操作目录;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}