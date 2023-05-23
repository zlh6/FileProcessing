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
    public partial class Form批量改名 : Form
    {
        String _操作路径;
        String _欲替换字;
        String _作替换字;
        int 已修改文件名数 = 0;
        int 已修改目录名数 = 0;
        public Form批量改名()
        {
            InitializeComponent();
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
        private void TextBox关键字_DragDrop(object sender, DragEventArgs e)//拖放完成时发生
        {
            String path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();   //      获取路径
            //获取不包含后缀的文件名
            if (File.Exists(path))
            {
                ((TextBox)sender).Text = System.IO.Path.GetFileNameWithoutExtension(path);
            }
            else
            {
                ((TextBox)sender).Text = System.IO.Path.GetFileName(path);

            }

        }


        private void Form_DragDrop(object sender, DragEventArgs e)//拖放完成时发生
        {
            //这里显示文件名
            textBox操作目录.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void TextBox操作目录_TextChanged(object sender, EventArgs e)
        {
            _操作路径 = ((TextBox)sender).Text;
        }
        private void TextBox欲替换字_TextChanged(object sender, EventArgs e)
        {
            _欲替换字=((TextBox)sender).Text;
        }

        private void TextBox作替换字_TextChanged(object sender, EventArgs e)
        {
            _作替换字=(((TextBox)sender).Text);
        }

        private void Button开始执行_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(_操作路径))  //判断文件夹是否存在
            {
                MessageBox.Show("请检查操作目录是否正确！");
                return;
            }
            else if (textBox欲替换字.Text == "")
            {
                MessageBox.Show("请检查欲替换字是否正确！");
                return;
            }
            else if (textBox作替换字.Text == "")
            {
                MessageBox.Show("请检查作替换字是否正确！");
                return;
            }
            else if (!checkBox文件名.Checked && !checkBox子目录名.Checked)
            {
                MessageBox.Show("至少选择一种修改对象！");
                return;
            }
            button开始执行.Enabled = false;
            button开始执行.Text = "处理中..";
            String[] 文件_路径;
            if (radioButton全名一致.Checked)
            {
                文件_路径 = Directory.GetFiles(_操作路径, _欲替换字 + ".*", SearchOption.AllDirectories);
                if (checkBox文件名.Checked)
                {
                    FileNameReplace(文件_路径);
                }
                if (checkBox子目录名.Checked)
                {
                    DirectorySameNameReplace(_操作路径);
                }
            }
            else
            {
                文件_路径 = Directory.GetFiles(_操作路径,"*"+ _欲替换字 + "*.*", SearchOption.AllDirectories);
                if (checkBox文件名.Checked)
                {
                    FileNameReplace(文件_路径);

                }
                if (checkBox子目录名.Checked)
                {
                    DirectoryNameReplace(_操作路径);

                }
            }
            button开始执行.Text = "修改完成";
            MessageBox.Show("修改完成！共修改了" + 已修改目录名数 + "个目录，" + 已修改文件名数 + "个文件");
            button开始执行.Enabled = true;
            button开始执行.Text = "开始执行";
            已修改文件名数 = 0;
            已修改目录名数 = 0;

        }

        private void FileNameReplace(String[] 文件_路径)
        {
            for (int i = 0; i < 文件_路径.Length; i++)
            {
                String 文件前名 = System.IO.Path.GetFileNameWithoutExtension(文件_路径[i]);
                String newFileName = 文件前名.Replace(_欲替换字,_作替换字); 
                DirectoryInfo diInfo = new DirectoryInfo(文件_路径[i]);
                String 上级路径 = diInfo.Parent.FullName + "\\";  //获取父目录的路径
                String 扩展名 = System.IO.Path.GetExtension(文件_路径[i]); //获取扩展名
                String 新路径 = 上级路径 + newFileName + 扩展名;
                if (!File.Exists(新路径))
                {
                    File.Move(文件_路径[i], 新路径);  //修改原文件名
                    已修改文件名数 += 1;
                }
            }
        }

        private void DirectoryNameReplace(String path)
        {
            String[] 子目录_路径 = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);


            for (int i = 0; i < 子目录_路径.Length; i++)
            {
                if (Directory.GetDirectories(子目录_路径[i]).Length > 0)
                {
                    DirectoryNameReplace(子目录_路径[i]);
                }

                String 目录名 = System.IO.Path.GetFileName(子目录_路径[i]);
                if (目录名.IndexOf(_欲替换字) >= 0)
                {
                    String newDirectoryName = 目录名.Replace(_欲替换字, _作替换字); //新字符串替换原名字内含有的关键字，赋给新名字
                    DirectoryInfo diInfo = new DirectoryInfo(子目录_路径[i]);
                    String 上级路径 = diInfo.Parent.FullName + "\\";  //获取父目录的路径
                    String 新路径 = 上级路径 + newDirectoryName;
                    if (!Directory.Exists(新路径))
                    {
                        Directory.Move(子目录_路径[i], 新路径);
                        已修改目录名数 += 1;
                    }
                }
            }
        }

        private void DirectorySameNameReplace(String path)
        {
            String[] 子目录_路径 = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);


            for (int i = 0; i < 子目录_路径.Length; i++)
            {
                if (Directory.GetDirectories(子目录_路径[i]).Length > 0)
                {
                    DirectorySameNameReplace(子目录_路径[i]);
                }

                String 目录名 = System.IO.Path.GetFileName(子目录_路径[i]);
                if (目录名==_欲替换字)
                {
                    DirectoryInfo diInfo = new DirectoryInfo(子目录_路径[i]);
                    String 上级路径 = diInfo.Parent.FullName + "\\";  //获取父目录的路径
                    String 新路径 = 上级路径 + _欲替换字;
                    if (!Directory.Exists(新路径))
                    {
                        Directory.Move(子目录_路径[i], 新路径);
                        已修改目录名数 += 1;
                    }

                }

            }


        }



    }
}
