﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * 访问文件的工具类
 */
namespace SqListCAI.Utils
{
    class Files
    {
        public static byte[]  read(string fileName)
        {
            byte[] data = null;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                int offset = 0;
                int remaining = data.Length;
                // C#读取文件之只要有剩余的字节就不停的读  
                while (remaining > 0)
                {
                    int read = fs.Read(data, offset, remaining);
                    if (read <= 0)
                        throw new EndOfStreamException("文件读取到" + read.ToString() + "失败！");
                    // C#读取文件之减少剩余的字节数  
                    remaining -= read;
                    // C#读取文件之增加偏移量  
                    offset += read;
                }
                fs.Close();
                return data;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return data;
        }
    }
}
