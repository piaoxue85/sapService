using System;

namespace sapService
{
    public class SapEkko 
    {

        private string _Ebeln;
        /// <summary>
        /// 采购订单编号
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
        private string _Unsez;
        /// <summary>
        /// 需求柜组
        /// </summary>
        public string Unsez
        {
            get
            {
                return _Unsez;
            }
            set
            {
                _Unsez = value;
            }
        }
        private string _Ihrez;
        /// <summary>
        /// 调出柜组
        /// </summary>
        public string Ihrez
        {
            get
            {
                return _Ihrez;
            }
            set
            {
                _Ihrez = value;
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
        private string _Lifnr;
        /// <summary>
        /// 供应商
        /// </summary>
        public string Lifnr
        {
            get
            {
                return _Lifnr;
            }
            set
            {
                _Lifnr = value;
            }
        }
        private string _Ekogr;
        /// <summary>
        /// 采购组织
        /// </summary>
        public string Ekogr
        {
            get
            {
                return _Ekogr;
            }
            set
            {
                _Ekogr = value;
            }
        }
        private string _Ekgrp;
        /// <summary>
        /// 采购组
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
        private string _Bukrs;
        /// <summary>
        /// 公司代码
        /// </summary>
        public string Bukrs
        {
            get
            {
                return _Bukrs;
            }
            set
            {
                _Bukrs = value;
            }
        }
        private string _Zcomment;
        /// <summary>
        /// 订单注释
        /// </summary>
        public string Zcomment
        {
            get
            {
                return _Zcomment;
            }
            set
            {
                _Zcomment = value;
            }
        }
        private string _Ernam;
        /// <summary>
        /// 订单创建人
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
        private string _Zfield1;
        /// <summary>
        /// 预留1
        /// </summary>
        public string Zfield1
        {
            get
            {
                return _Zfield1;
            }
            set
            {
                _Zfield1 = value;
            }
        }
        private string _Zfield2;
        /// <summary>
        /// 预留2
        /// </summary>
        public string Zfield2
        {
            get
            {
                return _Zfield2;
            }
            set
            {
                _Zfield2 = value;
            }
        }
        private string _Zfield3;
        /// <summary>
        /// 预留3
        /// </summary>
        public string Zfield3
        {
            get
            {
                return _Zfield3;
            }
            set
            {
                _Zfield3 = value;
            }
        }


        /// <summary>
        /// 明细
        /// </summary>
        public SapEkpo[] _ekpos { get; set; }


    }
}
