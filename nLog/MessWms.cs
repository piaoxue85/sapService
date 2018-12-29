using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.nLog
{
    /// <summary>
    /// 此为返回的对象 
    /// </summary>
    public class MessWms
    {
        /// <summary>
        /// 成功标识
        /// </summary>
        public static readonly string success = "S";
        /// <summary>
        /// 失败标识
        /// </summary>
        public static readonly string failure = "E";
        /// <summary>
        /// 成功为S；失败为E
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// 消息明文
        /// </summary>
        public string Mess { get; set; }

    }
}