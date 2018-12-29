using System;
using System.Collections.Generic;
using System.Web;

namespace sapService
{
    public class db_log
    {
        /// <summary>
        /// 写入数据库日志
        /// </summary>
        /// <param name="ty"></param>
        /// <param name="rm"></param>
        public static void writeDBLogs(string rm) {
            try {
                CYQ.Data.Log.WriteLogToDB(rm, CYQ.Data.LogType.Info);
            }
            catch(Exception ex) { 
                //不捕捉
            }
            
       
        }
    }
}