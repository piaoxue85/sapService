using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// 组织主数据
    /// </summary>
    public class SapHrob
    {
        /// <summary>
        /// 对象类型
        /// </summary>
        public string Otype
        {
            get;set;
        }
        private string _ObjID;
        /// <summary>
        /// 对象编码
        /// </summary>
        public string ObjID
        {
            get
            {
                return _ObjID;
            }
            set
            {
                _ObjID = value;
            }
        }
        private string _Stext;
        /// <summary>
        /// 对象名称
        /// </summary>
        public string Stext
        {
            get
            {
                return _Stext;
            }
            set
            {
                _Stext = value;
            }
        }
        private string _SobID;
        /// <summary>
        /// 上级对象编号
        /// </summary>
        public string SobID
        {
            get
            {
                return _SobID;
            }
            set
            {
                _SobID = value;
            }
        }
        private string _Zbmfzr;
        /// <summary>
        /// 部门负责人
        /// </summary>
        public string Zbmfzr
        {
            get
            {
                return _Zbmfzr;
            }
            set
            {
                _Zbmfzr = value;
            }
        }
        private string _Zjglx;
        /// <summary>
        /// 机构类型
        /// </summary>
        public string Zjglx
        {
            get
            {
                return _Zjglx;
            }
            set
            {
                _Zjglx = value;
            }
        }
        /// <summary>
        /// 门店编号
        /// </summary>
        public string MDBH { get; set; }
    }
}