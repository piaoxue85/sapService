using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapDeld
    {
        private string _Ebeln;
        /// <summary>
        /// 请配单号
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
        private int? _Ebelp;
        /// <summary>
        /// 请配行号
        /// </summary>
        public int? Ebelp
        {
            get
            {
                return _Ebelp;
            }
            set
            {
                _Ebelp = value;
            }
        }
        private string _Matnr;
        /// <summary>
        /// 商品
        /// </summary>
        public string Matnr
        {
            get
            {
                return _Matnr;
            }
            set
            {
                _Matnr = value;
            }
        }
        private string _Maktx;
        /// <summary>
        /// 商品描述
        /// </summary>
        public string Maktx
        {
            get
            {
                return _Maktx;
            }
            set
            {
                _Maktx = value;
            }
        }
        private string _Werks;
        /// <summary>
        /// 工厂
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
        private string _Menge;
        /// <summary>
        /// 数量
        /// </summary>
        public string Menge
        {
            get
            {
                return _Menge;
            }
            set
            {
                _Menge = value;
            }
        }
        private string _Zbatch;
        /// <summary>
        /// 批号
        /// </summary>
        public string Zbatch
        {
            get
            {
                return _Zbatch;
            }
            set
            {
                _Zbatch = value;
            }
        }
        private string _Zwmcw;
        /// <summary>
        /// 仓位好
        /// </summary>
        public string Zwmcw
        {
            get
            {
                return _Zwmcw;
            }
            set
            {
                _Zwmcw = value;
            }
        }
        private string _Datbi;
        /// <summary>
        /// 到期日
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
        private string _Charg;
        /// <summary>
        /// 批次
        /// </summary>
        public string Charg
        {
            get
            {
                return _Charg;
            }
            set
            {
                _Charg = value;
            }
        }
        private string _Meins;
        /// <summary>
        /// 单位
        /// </summary>
        public string Meins
        {
            get
            {
                return _Meins;
            }
            set
            {
                _Meins = value;
            }
        }
        private string _Wrbtr;
        /// <summary>
        /// 含税金额
        /// </summary>
        public string Wrbtr
        {
            get
            {
                return _Wrbtr;
            }
            set
            {
                _Wrbtr = value;
            }
        }
        private string _Netpr;
        /// <summary>
        /// 不含税金额
        /// </summary>
        public string Netpr
        {
            get
            {
                return _Netpr;
            }
            set
            {
                _Netpr = value;
            }
        }

    }
}