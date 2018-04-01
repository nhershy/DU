using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DU
{
    class Helper
    {
        static public string humanReadableSize(long bytes)
        {
            //return in bytes
            if (bytes < 1000)
            {
                return bytes.ToString() + "B";
            }
            //return in kilobytes
            else if (bytes > 1000 && bytes < 1000000)
            {
                return (bytes / 1000).ToString() + "KB";
            }
            //return in megabytes
            else if (bytes > 1000000 && bytes < 1000000000)
            {
                return (bytes / 1000000).ToString() + "MB";
            }
            //return in gigabytes
            else
            {
                //format to one decimal place without rounding
                string num = string.Format("{0:0.0}", Math.Truncate((bytes / 1000000000.0) * 10) / 10);
                return num + "GB";
            }
        }

        static public string getSize(long bytes)
        {
            return string.Format("[{0}] ", Helper.humanReadableSize(bytes));
        }

        static public long getBytes(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            return fileInfo.Length;
        }
    }
}
