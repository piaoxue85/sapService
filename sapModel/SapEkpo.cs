using System;

namespace sapService
{
    public class SapEkpo
    {

        private int? _Ebelp;
        /// <summary>
        /// 行项目号
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
       
        private string _Pstyp;
        /// <summary>
        /// 项目类型
        /// </summary>
        public string Pstyp
        {
            get
            {
                return _Pstyp;
            }
            set
            {
                _Pstyp = value;
            }
        }
        private string _Matnr;
        /// <summary>
        /// 物料
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
        private string _Txz01;
        public string Txz01
        {
            get
            {
                return _Txz01;
            }
            set
            {
                _Txz01 = value;
            }
        }
        private Decimal? _Menge;
        /// <summary>
        /// 订单数量/收货数量
        /// </summary>
        public Decimal? Menge
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
        private string _Meins;
        /// <summary>
        /// 订单单位
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
        private string _Gewei;
        /// <summary>
        /// 基本单位
        /// </summary>
        public string Gewei
        {
            get
            {
                return _Gewei;
            }
            set
            {
                _Gewei = value;
            }
        }
        private Decimal? _Emren;
        /// <summary>
        /// 订单单位比例
        /// </summary>
        public Decimal? Emren
        {
            get
            {
                return _Emren;
            }
            set
            {
                _Emren = value;
            }
        }
        private Decimal? _Umrez;
        /// <summary>
        /// 基本单位比例
        /// </summary>
        public Decimal? Umrez
        {
            get
            {
                return _Umrez;
            }
            set
            {
                _Umrez = value;
            }
        }
        private string _Eindt;
        /// <summary>
        /// 交货日期
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
        private Decimal? _Netpr;
        /// <summary>
        /// 净价
        /// </summary>
        public Decimal? Netpr
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
        private string _Waers;
        /// <summary>
        /// 货币
        /// </summary>
        public string Waers
        {
            get
            {
                return _Waers;
            }
            set
            {
                _Waers = value;
            }
        }
        private string _Peinh;
        /// <summary>
        /// 价格单位
        /// </summary>
        public string Peinh
        {
            get
            {
                return _Peinh;
            }
            set
            {
                _Peinh = value;
            }
        }
        private string _Bprme;
        /// <summary>
        /// 单位
        /// </summary>
        public string Bprme
        {
            get
            {
                return _Bprme;
            }
            set
            {
                _Bprme = value;
            }
        }
        private string _Mwskz;
        /// <summary>
        /// 税码
        /// </summary>
        public string Mwskz
        {
            get
            {
                return _Mwskz;
            }
            set
            {
                _Mwskz = value;
            }
        }
        private string _Matkl;
        /// <summary>
        /// 物料组
        /// </summary>
        public string Matkl
        {
            get
            {
                return _Matkl;
            }
            set
            {
                _Matkl = value;
            }
        }
        private string _Retpo;
        /// <summary>
        /// 退货项目
        /// </summary>
        public string Retpo
        {
            get
            {
                return _Retpo;
            }
            set
            {
                _Retpo = value;
            }
        }
        private string _Repos;
        /// <summary>
        /// 免费
        /// </summary>
        public string Repos
        {
            get
            {
                return _Repos;
            }
            set
            {
                _Repos = value;
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
        private string _Lgort;
        /// <summary>
        /// 库存地点
        /// </summary>
        public string Lgort
        {
            get
            {
                return _Lgort;
            }
            set
            {
                _Lgort = value;
            }
        }
        private Decimal? _Brtwr;
        /// <summary>
        /// 含税总价
        /// </summary>
        public Decimal? Brtwr
        {
            get
            {
                return _Brtwr;
            }
            set
            {
                _Brtwr = value;
            }
        }


    }
}