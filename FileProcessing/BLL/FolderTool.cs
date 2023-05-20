using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing.DAL
{
    internal class FolderTool
    {
        /// <summary>
        /// 获取目标目录下的所有空的子目录
        /// </summary>
        /// <param name="path">目标目录</param>
        /// <returns>空目录的列表</returns>
        public static List<string> GetEmptyFolder(string  path)
        {
            //定义一个用于装载空目录路径的列表
            List<string> emptyFolders = new List<string>();
            //获取目标目录下的所有子目录
            string[] subdirectories = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);
            foreach (string subdir in subdirectories)
            {
                if (Directory.GetFiles(subdir,"*",SearchOption.AllDirectories).Length < 1)
                {
                    emptyFolders.Add(subdir);
                }
             }
            return emptyFolders;
        }
    }
}
