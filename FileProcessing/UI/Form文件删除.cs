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
//using Microsoft.VisualBasic.FileIO;

namespace FileProcessing
{
    public partial class Form文件删除 : Form
    {
        String _操作路径;
        String _目标文件;
        long _文件大小B;
        int _文件大小KB;
        String _MD5值;
        public Form文件删除()
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

        private void 操作目录_TextChanged(object sender, EventArgs e)
        {
            _操作路径 = textBox操作目录.Text;
        }

        private void 目标文件_TextChanged(object sender, EventArgs e)
        {
            _目标文件 = textBox目标文件.Text;
            if (File.Exists(_目标文件))
            {
                _文件大小B = GetFileSize(_目标文件); 
                _文件大小KB = (int)System.Math.Ceiling(_文件大小B / 1024.0);
                textBox文件大小.Text = _文件大小KB.ToString();
                _MD5值 = GetMD5HashFromFile(_目标文件);
                textBoxMD5值.Text = _MD5值;
            }
            else if (Directory.Exists(_目标文件))
            {
                textBox文件大小.Text = "";
                textBoxMD5值.Text = "拖入的是文件夹";
            }

        }


        private long GetFileSize(string path) //返回指定路径的文件大小
        {
            System.IO.FileInfo fileInfo;
            try
            {
                fileInfo = new System.IO.FileInfo(path);
            }
            catch
            {
                return 0;
            }
            if (fileInfo != null && fileInfo.Exists)
            {
                //return (int)System.Math.Ceiling(fileInfo.Length / 1024.0);    //单位KB
                return fileInfo.Length;     //单位B
            }
            else
            {
                return 0;
            }
        }



        public static string GetMD5HashFromFile(string file)    //      获取文件的MD5值
        {
            try
            {
                FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(fileStream);
                fileStream.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("获取文件MD5值error:" + ex.Message);
            }
        }

        private void Button开始提取_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(_操作路径))  //判断文件夹是否存在
            {
                MessageBox.Show("请检查操作目录是否正确！");
                return;
            }
            else if (!System.IO.File.Exists(_目标文件))
            {
                MessageBox.Show("请检查目标文件是否正确！");
                return;
            }

            button开始删除.Enabled = false;
            button开始删除.Text = "枚举中...";
            ushort 删除数=SameFileDelete();
            button开始删除.Text = "删除完成";
            MessageBox.Show("删除完成！已将"+删除数+"个相同文件移动到回收站");
            button开始删除.Enabled = true;
            button开始删除.Text = "开始删除";
        }

        private ushort SameFileDelete()
        {
            ushort 删除数 = 0;
            String[] 文件_路径;
            文件_路径 = Directory.GetFiles(_操作路径, "*", System.IO.SearchOption.AllDirectories);
            button开始删除.Text = "寻找中...";
            for (int i = 0; i < 文件_路径.Length; i++)
            {
                if (GetFileSize(文件_路径[i]) == _文件大小B)
                {
                    if (GetMD5HashFromFile(文件_路径[i]) == _MD5值)
                    {
                        //FileSystem.DeleteFile(文件_路径[i], UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);   //将文件删除到回收站
                        删除数 += 1;
                    }
                }
            }
            return 删除数;
        }
    }
}
