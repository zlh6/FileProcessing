using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class Form文件提取 : Form
    {
        String _操作路径;
        String _存放路径;
        //string 功能选择;


        public Form文件提取()
        {
            InitializeComponent();
        }
        private void Form文件提取_Load(object sender, EventArgs e)
        {

        }
        private void 公用_DragEnter(object sender, DragEventArgs e)//拖动到工作区时发生
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TextBox_DragDrop(object sender, DragEventArgs e)//拖放完成时发生
        {
            //这里显示文件名
            ((TextBox)sender).Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void Form_DragDrop(object sender, DragEventArgs e)//拖放完成时发生
        {
            //这里显示文件名
            textBox1.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            _操作路径 = textBox1.Text;
            textBox2.Text = _操作路径;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            _存放路径 = textBox2.Text+"\\";
        }

        private void Button开始提取_Click(object sender, EventArgs e)
        {
            
            if (!System.IO.Directory.Exists(_操作路径))  //判断文件夹是否存在
            {
                MessageBox.Show("请检查待提取路径是否正确！");
                return;
            }
            else if (!System.IO.Directory.Exists(_存放路径))
            {
                MessageBox.Show("请检查存放路径是否正确！");
                return;
            }

            if (radioButton提取所有.Checked)
            {
                button开始提取.Enabled = false;
                button开始提取.Text = "提取中..";
                ExtractAll();
                button开始提取.Text = "提取完成";
                MessageBox.Show("提取完成！");
                button开始提取.Enabled = true;
                button开始提取.Text = "开始提取";

            }
            else if (radioButton提取下下级.Checked)
            {
                button开始提取.Enabled = false;
                button开始提取.Text = "提取中..";
                ExtractLower();
                button开始提取.Text = "提取完成";
                MessageBox.Show("提取完成！");
                button开始提取.Enabled = true;
                button开始提取.Text = "开始提取";
            }
            else return;

        }

       private void ExtractAll()    //提取所有文件
        {
            String[] 文件_路径;
            文件_路径 = Directory.GetFiles(_操作路径, "*", System.IO.SearchOption.AllDirectories);  //  获取目录下的所有文件路径
            FileMove(文件_路径);
        }

        private void ExtractLower()     //提取下下级目录和文件
        {
            String[] 子目录_路径 = Directory.GetDirectories(_操作路径);
            String[][] 下下级目录_路径=new string[子目录_路径.Length][];
            String[][] 下下级文件_路径 = new string[子目录_路径.Length][];
            for (int i = 0; i < 子目录_路径.Length; i++)
            {
                下下级目录_路径[i] = Directory.GetDirectories(子目录_路径[i]);
                下下级文件_路径[i] = Directory.GetFiles(子目录_路径[i]);
                DirectoryMove(下下级目录_路径[i]);
                FileMove(下下级文件_路径[i]);
                Directory.Delete(子目录_路径[i]);
            }

        }
        private void DirectoryMove(String[] 目录_路径)  //移动数组内的所有目录
        {
            String[] 目录_全名 = new String[目录_路径.Length];
            for (int i = 0; i < 目录_路径.Length; i++) //获取目录全名
            {
                目录_全名[i] = System.IO.Path.GetFileName(目录_路径[i]);

            }
            for (int i = 0; i < 目录_路径.Length; i++)  //逐个移动所有的目录
            {
                if (目录_路径[i] != _存放路径 + 目录_全名[i])   //判断当前目录是否不在存放目录
                {
                    if (Directory.Exists(_存放路径 + 目录_全名[i]) != false)    //判断存放目录是否有同名目录
                    {
                        int j = 1;
                        while (Directory.Exists(_存放路径 + 目录_全名[i] + + j) != false)  //不断添加后缀，直到找出不重复的目录名
                            j++;
                        Directory.Move(目录_路径[i], _存放路径 + 目录_全名[i] + j);    //移动并重命名
                    }
                    else
                    {
                        Directory.Move(目录_路径[i], _存放路径 + 目录_全名[i]);  //无同名文件则直接移动
                    }  
                }
            }
        }

        private void FileMove(String[] 文件_路径)   //移动数组内的所有文件
        {
            String[] 文件_全名 = new String[文件_路径.Length];
            for (int i = 0; i < 文件_路径.Length; i++) //获取文件全名
            {
                文件_全名[i] = System.IO.Path.GetFileName(文件_路径[i]);
                //System.Diagnostics.Debug.WriteLine(文件_全名[i]);

            }
            for (int i = 0; i < 文件_路径.Length; i++)  //逐个移动所有的文件
            {
                if (文件_路径[i] != _存放路径 + 文件_全名[i])   //判断当前文件是否不在存放目录
                {
                    if (File.Exists(_存放路径 + 文件_全名[i]) != false)    //判断存放目录是否有同名文件
                    {
                        String 文件_前名 = System.IO.Path.GetFileNameWithoutExtension(文件_全名[i]);
                        String 文件_扩展名 = System.IO.Path.GetExtension(文件_全名[i]);
                        int j = 1;
                        while (File.Exists(_存放路径 + 文件_前名 + "(" + j + ")" + 文件_扩展名) != false)  //不断添加后缀，直到找出不重复的文件名
                            j++;
                        File.Move(文件_路径[i], _存放路径 + 文件_前名 + "(" + j + ")" + 文件_扩展名);    //移动并重命名
                    }
                    else
                    {
                        Directory.Move(文件_路径[i], _存放路径 + 文件_全名[i]);  //无同名文件则直接移动
                    }
                }
            }
        }

    }
}
