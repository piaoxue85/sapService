using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    public class SapMarc
    {      
        private string _Asort;
        /// <summary>
        /// 门店分组
        /// </summary>
        public string Asort
        {
            get
            {
                return _Asort;
            }
            set
            {
                _Asort = value;
            }
        }
        private string _Werks;
        /// <summary>
        /// 门店编码
        /// </summary>
        public string Werks
        {
            get
            {
                return _Werks;
            }
            set
            {
                _Werks = value;
            }
        }
        private string _Datbi;
        /// <summary>
        /// 有效截至日期
        /// </summary>
        public string Datbi
        {
            get
            {
                return _Datbi;
            }
            set
            {
                _Datbi = value;
            }
        }
        private string _Datab;
        /// <summary>
        /// 开始生效日期 
        /// </summary>
        public string Datab
        {
            get
            {
                return _Datab;
            }
            set
            {
                _Datab = value;
            }
        }
        private string _Mmsta;
        /// <summary>
        /// 工厂特定的商品状态
        /// </summary>
        public string Mmsta
        {
            get
            {
                return _Mmsta;
            }
            set
            {
                _Mmsta = value;
            }
        }
        private string _Xmcng;
        /// <summary>
        /// 工厂中允许负库存
        /// </summary>
        public string Xmcng
        {
            get
            {
                return _Xmcng;
            }
            set
            {
                _Xmcng = value;
            }
        }
        private string _ConsProcg;
        /// <summary>
        /// 经营属性
        /// </summary>
        public string ConsProcg
        {
            get
            {
                return _ConsProcg;
            }
            set
            {
                _ConsProcg = value;
            }
        }
        private string _Mwsk1;
        /// <summary>
        /// 销售税代码
        /// </summary>
        public string Mwsk1
        {
            get
            {
                return _Mwsk1;
            }
            set
            {
                _Mwsk1 = value;
            }
        }
        private string _Kbetr;
        /// <summary>
        /// 销项税额
        /// </summary>
        public string Kbetr
        {
            get
            {
                return _Kbetr;
            }
            set
            {
                _Kbetr = value;
            }
        }
        private string _Zp03;
        /// <summary>
        /// 建议售价
        /// </summary>
        public string Zp03
        {
            get
            {
                return _Zp03;
            }
            set
            {
                _Zp03 = value;
            }
        }
        private string _Zdsj;
        /// <summary>
        /// 最低售价
        /// </summary>
        public string Zdsj
        {
            get
            {
                return _Zdsj;
            }
            set
            {
                _Zdsj = value;
            }
        }
        /// <summary>
        /// 采购组
        /// </summary>        
        public string Ekgrp { get; set; }
    }
}