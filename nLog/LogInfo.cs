using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Text;

namespace sapService.nLog
{
    public sealed class LogInfo
    {
        //工厂模式
        private static LogInfo _logInfo = null;
        private static object Singleton_Lock = new object(); //锁
        private LogInfo( string path) {
            this.Path = path;
        }

        public static LogInfo createLogInfo( string path)
        {
            lock (Singleton_Lock)
            {
                if (_logInfo == null)
                {
                    _logInfo = new LogInfo(path);
                }
            }
            return _logInfo;
        }
        /// <summary>
        /// 日志等级
        /// </summary>
        private enum LogType { ERROR = 1, INFO = 2, DEBUG = 3 };

        /// <summary>
        /// 指定日志文件夹（项目跟路劲文件夹）
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 向日志文件写入调试信息
        /// </summary>
        /// <param name="logName">类名/方法名</param>
        /// <param name="logContent">日志记录内容</param>
        public void Debug(string logName, string logContent)
        {
            WriteLog(new LogParameter() { LogGrade = (int)LogType.DEBUG, LogType = "LogType.DEBUG", LogName = logName, LogContent = logContent });

        }

        /// <summary>
        /// 向日志文件写入运行时信息
        /// </summary>
        /// <param name="logName">类名/方法名</param>
        /// <param name="logContent">日志记录内容</param>
        public void Info(string logName, string logContent)
        {
            WriteLog(new LogParameter() { LogGrade = (int)LogType.INFO, LogType = "LogType.INFO", LogName = logName, LogContent = logContent });

        }

        /// <summary>
        /// 向日志文件写入出错信息
        /// </summary>
        /// <param name="logName">类名/方法名</param>
        /// <param name="logContent">日志记录内容</param>
        public void Error(string logName, string logContent)
        {
            WriteLog(new LogParameter() { LogGrade = (int)LogType.ERROR, LogType = "LogType.ERROR", LogName = logName, LogContent = logContent });

        }
        /// <summary>
        /// 实际的写日志操作
        /// </summary>
        /// <param name="logParameter">日志参数model</param>
        private void WriteLog(LogParameter logParameter)
        {
            if (!Directory.Exists(Path))//如果日志目录不存在就创建
            {
                Directory.CreateDirectory(Path);
            }

            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToString("yyyy-MM-dd HH:mm:ss");//获取当前系统时间
            string filename = Path + "/" + dateTime.ToString("yyyy-MM-dd") + ".log";//用日期对日志文件命名
           // string filename = $"{Path}/{dateTime.ToString("yyyy-MM-dd")}.log";//同上等效

            //创建或打开日志文件，向日志文件末尾追加记录
            StreamWriter mySw = File.AppendText(filename);

            //向日志文件写入内容
            string writeContent = "###[" + logParameter.LogType +"||"+ time +"]" + logParameter.LogName + "(){\r\n" + logParameter.LogContent + "\r\n}";
            mySw.WriteLine(writeContent);
            //关闭日志文件
            mySw.Close();

        }
    }
}