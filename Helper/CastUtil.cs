using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.Helper
{
    public class CastUtil
    {
        /// <summary>
        /// 将字符串转换为 DateTime 类型，默认值为当前时间
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime CastDateTime(Object obj)
        {

            return CastUtil.CastDateTime(obj, DateTime.Now);


        }
        public static DateTime CastDateTime(Object obj, DateTime defaultValue)
        {
            try
            {
                DateTime DateTimeValue = defaultValue;
                if (obj != null)
                {

                    string str = CastUtil.CastString(obj);
                    if (!string.IsNullOrEmpty(str))
                    {
                        if (str.Contains("-"))
                        {
                            DateTimeValue = DateTime.ParseExact(str, "yyyy-MM-dd", null);
                        }
                        else
                        {
                            DateTimeValue = DateTime.ParseExact(str, "yyyyMMdd", null);
                        }
                    }
                }
                return DateTimeValue;
            }
            catch
            {
                return DateTime.Now;
            }

        }

        /// <summary>
        /// 将 Char 类型装换为 Decimal 类型，默认是0.0M
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Decimal CastDecimal(Object obj)
        {
            return CastUtil.CastDecimal(obj, 0.0M);
        }
        public static Decimal CastDecimal(Object obj, Decimal defaultValue)
        {
            Decimal decimalValue = defaultValue;
            if (obj != null)
            {
                string str = CastUtil.CastString(obj);
                if (!string.IsNullOrEmpty(str))
                {

                    decimalValue = Convert.ToDecimal(str);

                }
            }
            return decimalValue;
        }

        /// <summary>
        /// 将 Object 类型转换为 string 类型
        /// 默认值为""
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string CastString(Object obj)
        {
            return CastUtil.CastString(obj, "");
        }
        public static string CastString(Object obj, string defaultValue)
        {
            return obj != null ? Convert.ToString(obj) : defaultValue;
        }

        /// <summary>
        /// 输出 sql 语句
        /// </summary>
        /// <returns> string </returns>
        public static string DebugSql(string mess)
        {
            if (string.IsNullOrEmpty(mess))
            {
                mess = "Auto Cache ...";
            }
            return mess;
        }

    }
}