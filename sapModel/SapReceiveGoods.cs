using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapReceiveGoods
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
        private string _Bwart;
        /// <summary>
        /// 移动类型
        /// </summary>
        public string Bwart
        {
            get
            {
                return _Bwart;
            }
            set
            {
                _Bwart = value;
            }
        }
    }
}