using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

namespace sapService.nLog
{
    class LogParameter
    {
        // 日志等级
        public int LogGrade { get; set; }

        // 日志类型
        public string LogType { get; set; }

        // 日志记录类名和方法名（className/methodName）
        public string LogName { get; set; }

        // 日志记录文本内容     
        public string LogContent { get; set; }
    }
}