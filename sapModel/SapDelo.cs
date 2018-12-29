using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapDelo
    {
        private string _Ebeln;
        /// <summary>
        /// 请配单号(STO号)
        /// </summary>
        public string Ebeln
        {
            get
            {
                return _Ebeln;
            }
            set
            {
                _Ebeln = value;
            }
        }
        private string _Bsart;
        /// <summary>
        /// 订单类型
        /// </summary>
        public string Bsart
        {
            get
            {
                return _Bsart;
            }
            set
            {
                _Bsart = value;
            }
        }
        /// <summary>
        /// 退货标识
        /// </summary>
        public string RETPO { get; set; }
        private string _Zjj;
        /// <summary>
        /// 是否加急
        /// </summary>
        public string Zjj
        {
            get
            {
                return _Zjj;
            }
            set
            {
                _Zjj = value;
            }
        }
        private string _Zfree;
        /// <summary>
        /// 是否赠品
        /// </summary>
        public string Zfree
        {
            get
            {
                return _Zfree;
            }
            set
            {
                _Zfree = value;
            }
        }
        private string _Reswk;
        /// <summary>
        /// 批发公司
        /// </summary>
        public string Reswk
        {
            get
            {
                return _Reswk;
            }
            set
            {
                _Reswk = value;
            }
        }
        private string _Ekgrp;
        /// <summary>
        /// 部门
        /// </summary>
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
        private string _Reslo;
        /// <summary>
        /// 出库地点
        /// </summary>
        public string Reslo
        {
            get
            {
                return _Reslo;
            }
            set
            {
                _Reslo = value;
            }
        }
        private string _Kunnr;
        /// <summary>
        /// 客户
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
        private string _Znwx;
        /// <summary>
        /// 内外销标识
        /// </summary>
        public string Znwx
        {
            get
            {
                return _Znwx;
            }
            set
            {
                _Znwx = value;
            }
        }
        private string _Zregz;
        /// <summary>
        /// 接收柜组
        /// </summary>
        public string Zregz
        {
            get
            {
                return _Zregz;
            }
            set
            {
                _Zregz = value;
            }
        }
        private string _Eindt;
        /// <summary>
        /// 计划送货日期
        /// </summary>
        public string Eindt
        {
            get
            {
                return _Eindt;
            }
            set
            {
                _Eindt = value;
            }
        }
        private string _Zbz;
        /// <summary>
        /// 备注
        /// </summary>
        public string Zbz
        {
            get
            {
                return _Zbz;
            }
            set
            {
                _Zbz = value;
            }
        }
        private string _Ernam;
        /// <summary>
        /// 请配人员
        /// </summary>
        public string Ernam
        {
            get
            {
                return _Ernam;
            }
            set
            {
                _Ernam = value;
            }
        }
        private string _Aedat;
        /// <summary>
        /// 订单创建日期
        /// </summary>
        public string Aedat
        {
            get
            {
                return _Aedat;
            }
            set
            {
                _Aedat = value;
            }
        }
        /// <summary>
        /// 装运条件
        /// </summary>
        public string VSBED { get; set; }
        private string _EbelnO;
        /// <summary>
        /// 原始单号
        /// </summary>
        public string EbelnO
        {
            get
            {
                return _EbelnO;
            }
            set
            {
                _EbelnO = value;
            }
        }
        /// <summary>
        /// 请配类型
        /// </summary>
        public string Ztype { get; set; }
        /// <summary>
        /// 明细
        /// </summary>
        public SapDeld[] _delds { get; set; }

    }
}