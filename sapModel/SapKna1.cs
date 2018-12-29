using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// 客户主数据
    /// </summary>
    public class SapKna1
    {
        private string _Ktokd;
        /// <summary>
        /// 客户账户组
        /// </summary>
        public string Ktokd
        {
            get
            {
                return _Ktokd;
            }
            set
            {
                _Ktokd = value;
            }
        }
        private string _Kunnr;
        /// <summary>
        /// 客户编码
        /// </summary>
        public string Kunnr
        {
            get
            {
                return _Kunnr;
            }
            set
            {
                _Kunnr = value;
            }
        }
        private string _Name1;
        /// <summary>
        /// 客户描述
        /// </summary>
        public string Name1
        {
            get
            {
                return _Name1;
            }
            set
            {
                _Name1 = value;
            }
        }
        public string Name2 { get; set; }
        private string _Regio;
        /// <summary>
        /// 地区
        /// </summary>
        public string Regio
        {
            get
            {
                return _Regio;
            }
            set
            {
                _Regio = value;
            }
        }
        private string _TelNumber;
        /// <summary>
        /// 电话
        /// </summary>
        public string TelNumber
        {
            get
            {
                return _TelNumber;
            }
            set
            {
                _TelNumber = value;
            }
        }
        private string _SmtpAddr;
        /// <summary>
        /// 邮箱
        /// </summary>
        public string SmtpAddr
        {
            get
            {
                return _SmtpAddr;
            }
            set
            {
                _SmtpAddr = value;
            }
        }
        private string _FaxNumber;
        /// <summary>
        /// 移动电话
        /// </summary>
        public string FaxNumber
        {
            get
            {
                return _FaxNumber;
            }
            set
            {
                _FaxNumber = value;
            }
        }
        private string _Kukla;
        /// <summary>
        /// 客户分类
        /// </summary>
        public string Kukla
        {
            get
            {
                return _Kukla;
            }
            set
            {
                _Kukla = value;
            }
        }
        private string _Niels;
        /// <summary>
        /// WMS物流方式
        /// </summary>
        public string Niels
        {
            get
            {
                return _Niels;
            }
            set
            {
                _Niels = value;
            }
        }
        
    }
}