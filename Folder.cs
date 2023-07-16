using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFolder
{
    public class Folder
    {
        // 创建文件夹的函数
        public void CreateFolder(string folderPath)
        {
            // 检查文件夹是否存在
            if (!Directory.Exists(folderPath))
            {
                // 创建文件夹
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}
