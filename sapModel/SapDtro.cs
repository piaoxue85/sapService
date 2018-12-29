using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// 差异移库抬头 Differential transfer reservoir
    /// </summary>
    public class SapDtro
    {
        private string _EbelnT;
        /// <summary>
        /// 退单号
        /// </summary>
        public string EbelnT
        {
            get
            {
                return _EbelnT;
            }
            set
            {
                _EbelnT = value;
            }
        }
        /// <summary>
        /// 移库通知日期
        /// </summary>
        public string Bldat
        {
            get;set;
        }
        private string _EbelnY;
        /// <summary>
        /// 原单号
        /// </summary>
        public string EbelnY
        {
            get
            {
                return _EbelnY;
            }
            set
            {
                _EbelnY = value;
            }
        }
        private string _Bname;
        /// <summary>
        /// 操作人
        /// </summary>
        public string Bname
        {
            get
            {
                return _Bname;
            }
            set
            {
                _Bname = value;
            }
        }
        private string _Ekgrp;
        public string Ekgrp
        {
            get
            {
                return _Ekgrp;
            }
            set
            {
                _Ekgrp = value;
            }
        }

        public SapDtrd[] sapDtrds { get; set; }
    }
}