using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class Form主窗口 : Form
    {
        public Form主窗口()
        {
            InitializeComponent();
        }

        private void Button文件提取_Click(object sender, EventArgs e)
        {
            new Form文件提取().ShowDialog(); 
        }

        private void Button删空目录_Click(object sender, EventArgs e)
        {
            new FormClean().ShowDialog();
        }

        private void Button文件插入_Click(object sender, EventArgs e)
        {
            new Form文件插入().ShowDialog();
        }

        private void Button文件删除_Click(object sender, EventArgs e)
        {
            new Form文件删除().ShowDialog();
        }

        private void Button文件更名_Click(object sender, EventArgs e)
        {
            new Form批量更名().ShowDialog();
        }


        private void Button文件改名_Click(object sender, EventArgs e)
        {
            new Form批量改名().ShowDialog();
        }

        private void Form主窗口_Load(object sender, EventArgs e)
        {
            
        }

    }
}
