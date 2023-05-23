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
    public partial class Form文件插入 : Form
    {
        String _目标目录;
        String _待插入;
        int 已插入的文件数;
        int 已插入的文件夹数;
        public Form文件插入()
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

        private void Form_DragDrop(object sender, DragEventArgs e)//拖放完成时发生
        {
            //这里显示文件名
            textBox操作目录.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void TextBox操作目录_TextChanged(object sender, EventArgs e)
        {
            _目标目录 = ((TextBox)sender).Text;
        }

        private void TextBox目标文件_TextChanged(object sender, EventArgs e)
        {
            _待插入 = ((TextBox)sender).Text;
        }

        private void Button开始插入_Click(object sender, EventArgs e) {

            if (!System.IO.Directory.Exists(_目标目录))  //判断文件夹是否存在
            {
                MessageBox.Show("请检查操作目录是否正确！");
                return;
            }
            else if (!System.IO.File.Exists(_待插入) && !System.IO.Directory.Exists(_待插入))
            {
                MessageBox.Show("请检查目标对象是否正确！");
                return;
            }

            button开始插入.Enabled = false;
            button开始插入.Text = "处理中..";
            

            if (System.IO.File.Exists(_待插入))
            {
                InsertFile(_待插入, _目标目录);
                button开始插入.Text = "插入完成";
                MessageBox.Show("插入完成！已插入" + 已插入的文件数 + "个文件");
            }
            else if (System.IO.Directory.Exists(_待插入))
            {

                Boolean bl = InsertDirectory(_待插入, _目标目录);
                if (bl)
                {
                    button开始插入.Text = "插入完成";
                    MessageBox.Show("插入完成！已插入" + 已插入的文件夹数 + "个文件夹，" + 已插入的文件数 + "个文件");

                }
                else
                {

                    MessageBox.Show("指定目录为空！");

                }
                    
                
                
            }

            button开始插入.Enabled = true;
            button开始插入.Text = "开始插入";
            已插入的文件夹数 = 0;
            已插入的文件数 = 0;
        }
        private void InsertFile(String filePath,String directoryPath)
        {
            String 文件全名 = Path.GetFileName(filePath);
            if (!File.Exists(directoryPath + "\\" + 文件全名))   //如果没有重名文件，就复制进去
            {
                File.Copy(filePath, directoryPath + "\\" + 文件全名);
                已插入的文件数 += 1;
            }

            String[] 所有目录_路径 = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);   //获取所有子文件夹路径
            
            for (int i = 0; i < 所有目录_路径.Length; i++)
            {
                String 新路径 = 所有目录_路径[i] + "\\" + 文件全名;
               if (!File.Exists(新路径))   //如果没有重名文件，就复制进去
                {
                    File.Copy(filePath, 新路径);
                    已插入的文件数 += 1;
                }
            }

        }

        private bool InsertDirectory(String sourceDirectoryPath, String targetDirectoryPath)
        {
            if (radioButton1.Checked)
            {
                if (Directory.GetFileSystemEntries(targetDirectoryPath, "*", SearchOption.TopDirectoryOnly).Length > 0)
                {
                    String[] 待插入文件_路径 = Directory.GetFiles(sourceDirectoryPath, "*", SearchOption.AllDirectories);
                    String[] 所有目标目录_路径 = Directory.GetDirectories(targetDirectoryPath, "*", SearchOption.AllDirectories);
                    if (所有目标目录_路径.Length > 0)
                    {
                      
                            for (int i = 0; i < 待插入文件_路径.Length; i++)
                            {
                                InsertFile(待插入文件_路径[i], targetDirectoryPath);
                            }
                            
                        
                    }
                    return true;
                }
                else
                {
                    
                    return false; 
                }

            }
            else if (radioButton2.Checked)  //整个插入
            {
                String 目录名 = Path.GetFileName(sourceDirectoryPath);
                if (!Directory.Exists(targetDirectoryPath + "\\" + 目录名))   //如果没有重名文件，就复制进去
                {
                    CopyFolder(sourceDirectoryPath, targetDirectoryPath + "\\" + 目录名);
                    已插入的文件夹数 += 1;
                }

                String[] 所有目录_路径 = Directory.GetDirectories(targetDirectoryPath, "*", SearchOption.AllDirectories);
                if(所有目录_路径.Length > 0)
                {
                    for (int i = 0; i < 所有目录_路径.Length; i++)
                    {
                        
                        String 新路径 = 所有目录_路径[i] + "\\" + 目录名;
                        CopyFolder(sourceDirectoryPath, 新路径);
                        已插入的文件夹数 += 1;
                    }
                }
                
                
            }
            return true;

        }


        public static int CopyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                //如果目标路径不存在,则创建目标路径
                if (!System.IO.Directory.Exists(destFolder))
                {
                    System.IO.Directory.CreateDirectory(destFolder);
                }
                //得到原文件根目录下的所有文件
                string[] files = System.IO.Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = System.IO.Path.GetFileName(file);
                    string dest = System.IO.Path.Combine(destFolder, name);
                    System.IO.File.Copy(file, dest);//复制文件
                }
                //得到原文件根目录下的所有文件夹
                string[] folders = System.IO.Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = System.IO.Path.GetFileName(folder);
                    string dest = System.IO.Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);//构建目标路径,递归复制文件
                }
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
