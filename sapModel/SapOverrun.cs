using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// sap樾库单
     /// </summary>
    public class SapOverrun
    {

        private string _Elben;
        /// <summary>
        /// 入库单号
        /// </summary>
        public string Elben
        {
            get
            {
                return _Elben;
            }
            set
            {
                _Elben = value;
            }
        }
        private string _Elben2;
        /// <summary>
        /// 出库单
        /// </summary>
        public string Elben2
        {
            get
            {
                return _Elben2;
            }
            set
            {
                _Elben2 = value;
            }
        }
        private string _Lgort;
        /// <summary>
        /// 樾库地点
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
        private string _Elelp;
        /// <summary>
        /// 行项目
        /// </summary>
        public string Elelp
        {
            get
            {
                return _Elelp;
            }
            set
            {
                _Elelp = value;
            }
        }
        private string _Retpo;
        /// <summary>
        /// 退货标示
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
        /// 物料描述
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
        private Decimal? _Menge;
        /// <summary>
        /// 数量
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
        private Decimal? _Wrbtr1;
        /// <summary>
        /// 含税金额
        /// </summary>
        public Decimal? Wrbtr1
        {
            get
            {
                return _Wrbtr1;
            }
            set
            {
                _Wrbtr1 = value;
            }
        }
        private Decimal? _Netpr1;
        /// <summary>
        /// 未税金额
        /// </summary>
        public Decimal? Netpr1
        {
            get
            {
                return _Netpr1;
            }
            set
            {
                _Netpr1 = value;
            }
        }
        private Decimal? _Wrbtr2;
        /// <summary>
        /// 出库含税
        /// </summary>
        public Decimal? Wrbtr2
        {
            get
            {
                return _Wrbtr2;
            }
            set
            {
                _Wrbtr2 = value;
            }
        }
        private Decimal? _Netpr2;
        /// <summary>
        /// 出库未税
        /// </summary>
        public Decimal? Netpr2
        {
            get
            {
                return _Netpr2;
            }
            set
            {
                _Netpr2 = value;
            }
        }
        private string _Kunnr;
        /// <summary>
        /// 门店
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
        private string _Zregz;
        /// <summary>
        /// 收货柜组
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
        private string _Wmscode;
        /// <summary>
        /// wms单号
        /// </summary>
        public string Wmscode
        {
            get
            {
                return _Wmscode;
            }
            set
            {
                _Wmscode = value;
            }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string Ernam { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>
        public string Aedat { get;  set; }
    }
}