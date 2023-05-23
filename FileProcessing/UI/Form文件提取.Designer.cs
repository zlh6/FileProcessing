namespace FileProcessing
{
    partial class Form文件提取
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form文件提取));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton提取所有 = new System.Windows.Forms.RadioButton();
            this.radioButton提取下下级 = new System.Windows.Forms.RadioButton();
            this.button开始提取 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(80, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(196, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件提取";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(80, 242);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(431, 40);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            // 
            // radioButton提取所有
            // 
            this.radioButton提取所有.AutoSize = true;
            this.radioButton提取所有.Location = new System.Drawing.Point(80, 321);
            this.radioButton提取所有.Name = "radioButton提取所有";
            this.radioButton提取所有.Size = new System.Drawing.Size(118, 19);
            this.radioButton提取所有.TabIndex = 3;
            this.radioButton提取所有.Text = "提取所有文件";
            this.radioButton提取所有.UseVisualStyleBackColor = true;
            // 
            // radioButton提取下下级
            // 
            this.radioButton提取下下级.AutoSize = true;
            this.radioButton提取下下级.Checked = true;
            this.radioButton提取下下级.Location = new System.Drawing.Point(80, 371);
            this.radioButton提取下下级.Name = "radioButton提取下下级";
            this.radioButton提取下下级.Size = new System.Drawing.Size(193, 19);
            this.radioButton提取下下级.TabIndex = 4;
            this.radioButton提取下下级.TabStop = true;
            this.radioButton提取下下级.Text = "仅提取下下级目录和文件";
            this.radioButton提取下下级.UseVisualStyleBackColor = true;
            // 
            // button开始提取
            // 
            this.button开始提取.AutoSize = true;
            this.button开始提取.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始提取.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button开始提取.Location = new System.Drawing.Point(396, 331);
            this.button开始提取.Name = "button开始提取";
            this.button开始提取.Size = new System.Drawing.Size(115, 50);
            this.button开始提取.TabIndex = 5;
            this.button开始提取.Text = "开始提取";
            this.button开始提取.UseVisualStyleBackColor = true;
            this.button开始提取.Click += new System.EventHandler(this.Button开始提取_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "待提取的目录：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(76, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "存放的目录：";
            // 
            // Form文件提取
            // 
            this.AcceptButton = this.button开始提取;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button开始提取);
            this.Controls.Add(this.radioButton提取下下级);
            this.Controls.Add(this.radioButton提取所有);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form文件提取";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件提取";
            this.Load += new System.EventHandler(this.Form文件提取_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.公用_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton提取所有;
        private System.Windows.Forms.RadioButton radioButton提取下下级;
        private System.Windows.Forms.Button button开始提取;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}