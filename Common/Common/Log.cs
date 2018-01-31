using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Common
{
    public static class Log
    {
        private static string _filePath = string.Empty;
        public static string FilePath
        {
            set { _filePath = value; }
            get
            {
                return string.IsNullOrWhiteSpace(_filePath) ? Directory.GetCurrentDirectory() : _filePath;

            }
        }

        private static string _fileName = string.Empty;
        public static string FileName
        {
            set { _fileName = value; }
            get
            {
                string fn = string.IsNullOrWhiteSpace(_fileName) ? Process.GetCurrentProcess().MainModule.FileName : _filePath;
                return  Path.GetFileName(fn) + "_" + DateTime.Now.ToString("yyyyMMdd")+ ".log";
            }
        }

        public static string LogFilePath
        { get { return Path.Combine(FilePath, FileName); } }


        public static void OutPutErrorLog(string msg)
        {
            using (StreamWriter sw = new StreamWriter(LogFilePath, true))
            {
                sw.WriteLine(GetLogMessage("ERROR " + msg));
            }
        }

        public static void OutPutInfoLog(string msg)
        {
            using (StreamWriter sw = new StreamWriter(LogFilePath, true))
            {
                sw.WriteLine(GetLogMessage("Info  " + msg));
            }
        }

        private static string GetLogMessage(string msg)
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "   " + msg;
        }
    }
}
