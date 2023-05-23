namespace FileProcessing
{
    partial class Form主窗口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form主窗口));
            this.button文件提取 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button删空目录 = new System.Windows.Forms.Button();
            this.button文件插入 = new System.Windows.Forms.Button();
            this.button文件删除 = new System.Windows.Forms.Button();
            this.button文件更名 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button文件改名 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button文件提取
            // 
            this.button文件提取.Location = new System.Drawing.Point(64, 175);
            this.button文件提取.Name = "button文件提取";
            this.button文件提取.Size = new System.Drawing.Size(131, 46);
            this.button文件提取.TabIndex = 1;
            this.button文件提取.Text = "文件提取";
            this.toolTip1.SetToolTip(this.button文件提取, "将指定文件夹内的文件提取出来");
            this.button文件提取.UseVisualStyleBackColor = true;
            this.button文件提取.Click += new System.EventHandler(this.Button文件提取_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(96, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "文件处理";
            this.toolTip1.SetToolTip(this.label2, "QQ：417695121");
            // 
            // button删空目录
            // 
            this.button删空目录.Location = new System.Drawing.Point(204, 175);
            this.button删空目录.Name = "button删空目录";
            this.button删空目录.Size = new System.Drawing.Size(131, 46);
            this.button删空目录.TabIndex = 3;
            this.button删空目录.Text = "删空目录";
            this.toolTip1.SetToolTip(this.button删空目录, "删除指定目录内的空文件夹");
            this.button删空目录.UseVisualStyleBackColor = true;
            this.button删空目录.Click += new System.EventHandler(this.Button删空目录_Click);
            // 
            // button文件插入
            // 
            this.button文件插入.Location = new System.Drawing.Point(64, 251);
            this.button文件插入.Name = "button文件插入";
            this.button文件插入.Size = new System.Drawing.Size(131, 46);
            this.button文件插入.TabIndex = 4;
            this.button文件插入.Text = "文件插入";
            this.toolTip1.SetToolTip(this.button文件插入, "将指定文件插入到指定目录的所有子文件夹下");
            this.button文件插入.UseVisualStyleBackColor = true;
            this.button文件插入.Click += new System.EventHandler(this.Button文件插入_Click);
            // 
            // button文件删除
            // 
            this.button文件删除.Location = new System.Drawing.Point(204, 251);
            this.button文件删除.Name = "button文件删除";
            this.button文件删除.Size = new System.Drawing.Size(131, 46);
            this.button文件删除.TabIndex = 5;
            this.button文件删除.Text = "文件删除";
            this.toolTip1.SetToolTip(this.button文件删除, "将指定目录内与指定文件相同的文件删除到回收站");
            this.button文件删除.UseVisualStyleBackColor = true;
            this.button文件删除.Click += new System.EventHandler(this.Button文件删除_Click);
            // 
            // button文件更名
            // 
            this.button文件更名.Location = new System.Drawing.Point(64, 328);
            this.button文件更名.Name = "button文件更名";
            this.button文件更名.Size = new System.Drawing.Size(131, 46);
            this.button文件更名.TabIndex = 6;
            this.button文件更名.Text = "文件更名";
            this.toolTip1.SetToolTip(this.button文件更名, "根据选定规则对目录下的文件或子目录进行批量改名");
            this.button文件更名.UseVisualStyleBackColor = true;
            this.button文件更名.Click += new System.EventHandler(this.Button文件更名_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "作者：月影谦清";
            this.toolTip1.SetToolTip(this.label1, "QQ：417695121");
            // 
            // button文件改名
            // 
            this.button文件改名.Location = new System.Drawing.Point(204, 328);
            this.button文件改名.Name = "button文件改名";
            this.button文件改名.Size = new System.Drawing.Size(131, 46);
            this.button文件改名.TabIndex = 9;
            this.button文件改名.Text = "文件改名";
            this.toolTip1.SetToolTip(this.button文件改名, "将子目录和文件名称中包含的某一字符，更改为其他字符");
            this.button文件改名.UseVisualStyleBackColor = true;
            this.button文件改名.Click += new System.EventHandler(this.Button文件改名_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "注：悬停显示帮助，路径支持拖拽";
            // 
            // Form主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.button文件改名);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button文件更名);
            this.Controls.Add(this.button文件删除);
            this.Controls.Add(this.button文件插入);
            this.Controls.Add(this.button删空目录);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button文件提取);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件处理 v1.3";
            this.Load += new System.EventHandler(this.Form主窗口_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button文件提取;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button删空目录;
        private System.Windows.Forms.Button button文件插入;
        private System.Windows.Forms.Button button文件删除;
        private System.Windows.Forms.Button button文件更名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button文件改名;
    }
}

