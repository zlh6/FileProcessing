using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void TextBox目标目录_TextChanged(object sender, EventArgs e)
        {
            path = textBox目标目录.Text;
            toolStripStatusLabel状态指示.Text = "未开始";
        }
        /// <summary>
        /// 默认选中列表中的所有项目
        /// </summary>
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
        private void Button扫描_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("文件夹不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CloseButton();
            toolStripStatusLabel1.Text = "一共有 0 个空目录，选中了 0 个空目录";
            toolStripStatusLabel状态指示.Text = "正在扫描...";
            ThreadStart ts = new ThreadStart(GetEmptyDirectory);
            Thread t = new Thread(ts);
            t.Start();
        }
        /// <summary>
        /// 获取所有空目录数组，填充到列表
        /// </summary>
        private void GetEmptyDirectory()
        {
            string[] subdirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);//所有子目录的数组
            toolStripProgressBar1.Maximum = subdirectories.Length;//设定进度条最大值
            //checkedListBox清理列表.DataSource = emptyFolders;     //不要使用绑定
            checkedListBox清理列表.Items.Clear();   //添加之前先将列表清空
            int rate = 0;   //rate代表当前进度
            foreach (string subdir in subdirectories)
            {
                if (Directory.GetFiles(subdir, "*", SearchOption.AllDirectories).Length < 1)
                {
                    checkedListBox清理列表.Items.Add(subdir);
                    //Thread.Sleep(200); // 延时0.2秒
                }
                rate++;
                toolStripProgressBar1.Value = rate;
            }
            CheckAllItems();
            // RefreshStatusBarLabels();
            toolStripStatusLabel状态指示.Text = "扫描完成";
            OpenButton();
        }
        private void Button一键清理_Click(object sender, EventArgs e)
        {
            CloseButton();
            toolStripStatusLabel状态指示.Text = "正在清理...";
            ThreadStart ts = new ThreadStart(CleanEmptyDirectory);
            Thread t = new Thread(ts);
            t.Start();

        }
        /// <summary>
        /// 清理空文件夹
        /// </summary>
        private void CleanEmptyDirectory()
        {
            toolStripProgressBar1.Maximum = checkedListBox清理列表.CheckedItems.Count;
            int rate = 0;
            for (int i = 0; i < checkedListBox清理列表.CheckedItems.Count;)
            {
                string directoryPath = checkedListBox清理列表.CheckedItems[i].ToString();
                if (Directory.Exists(directoryPath))
                {
                    Directory.Delete(directoryPath, true); //删除当前项路径对应的目录
                }
                if (rate< toolStripProgressBar1.Maximum)
                {
                    rate++;
                    toolStripProgressBar1.Value = rate;
                }
                checkedListBox清理列表.Items.RemoveAt(i); // 移除指定索引处的项
                checkedListBox清理列表.Refresh(); // 刷新 CheckedListBox 界面数据
                //Thread.Sleep(200); // 延时0.2秒
            }
            toolStripStatusLabel状态指示.Text = "清理完成";
            toolStripStatusLabel1.Text = "一共有 0 个空目录，选中了 0 个空目录";
            OpenButton();
        }

        private void CheckedListBox清理列表_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 获取更改后的选中状态
            CheckState newState = e.NewValue;
            int totalItems = checkedListBox清理列表.Items.Count; // 获取项数                                                           
            int checkedItems = checkedListBox清理列表.CheckedItems.Count; // 获取被勾选的项数
            if (newState == CheckState.Checked)     // 判断当前是勾选还是取消勾选项
            {
                // 勾选项
                checkedItems++;
            }
            else if (newState == CheckState.Unchecked)
            {
                // 取消勾选项
                checkedItems--;
            }
            if (checkedItems > 0)
            {
                button一键清理.Enabled = true;
            }
            else
            {
                button一键清理.Enabled = false;
            }
            toolStripStatusLabel1.Text = $"一共有 {totalItems} 个空目录，选中了 {checkedItems} 个空目录";
        }

        private void FormClean_Load(object sender, EventArgs e)
        {
            //允许跨线程操作UI
            CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 关闭所有按钮
        /// </summary>
        private void CloseButton()
        {
            button扫描.Enabled = false;
            button一键清理.Enabled = false;
            button浏览.Enabled = false;
            button反选.Enabled = false;
        }
        private void OpenButton()
        {
            button扫描.Enabled = true;
            button浏览.Enabled = true;
            button反选.Enabled = true;
        }

        private void CheckedListBox清理列表_MouseUp(object sender, MouseEventArgs e)
        {
            // 判断鼠标右键点击
            if (e.Button == MouseButtons.Right)
            {
                // 获取鼠标点击的项索引
                int index = checkedListBox清理列表.IndexFromPoint(e.Location);

                // 判断索引是否有效
                if (index >= 0 && index < checkedListBox清理列表.Items.Count)
                {
                    // 设置选中项
                    checkedListBox清理列表.SelectedIndex = index;

                    // 显示右键菜单
                    contextMenuStrip1.Show(checkedListBox清理列表, e.Location);
                }
            }
        }

        private void 打开文件夹位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选中行的内容
            string selectedItemPath = checkedListBox清理列表.SelectedItem.ToString();
            // 使用资源管理器打开目录
            Process.Start("explorer.exe", selectedItemPath);
        }

    }
}

