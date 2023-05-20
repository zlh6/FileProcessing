using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileProcessing.DAL;

namespace FileProcessing
{
    public partial class FormClean : Form
    {
        string path;
        public FormClean()
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
            textBox目标目录.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void Button浏览_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择目录";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = folderBrowserDialog1.SelectedPath;
                textBox目标目录.Text = path;
            }
        }

        private void Button执行_Click(object sender, EventArgs e)
        {
            List<string> emptyFolders=FolderTool.GetEmptyFolder(path);
            checkedListBox清理列表.DataSource = emptyFolders;
            CheckAllItems();
        }

        private void TextBox目标目录_TextChanged(object sender, EventArgs e)
        {
            path=textBox目标目录.Text;
        }
        private void CheckAllItems()
        {
            for (int i = 0; i < checkedListBox清理列表.Items.Count; i++)
            {
                checkedListBox清理列表.SetItemChecked(i, true);
            }
        }

        private void CheckBox全选_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox全选.Checked == true)
            {
                for (int i = 0; i < checkedListBox清理列表.Items.Count; i++)
                {
                    checkedListBox清理列表.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox清理列表.Items.Count; i++)
                {
                    checkedListBox清理列表.SetItemChecked(i, false);
                }
            }
        }

        private void Button反选_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox清理列表.Items.Count; i++)
            {
                checkedListBox清理列表.SetItemChecked(i, !checkedListBox清理列表.GetItemChecked(i));
            }
        }
    }
}
