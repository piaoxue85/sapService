using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    public class SapAllotdet
    {
        private string _Incode;
        /// <summary>
        /// 商品编码
        /// </summary>
        public string Incode
        {
            get
            {
                return _Incode;
            }
            set
            {
                _Incode = value;
            }
        }
        private string _Fname;
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                _Fname = value;
            }
        }
        private string _Unit;
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get
            {
                return _Unit;
            }
            set
            {
                _Unit = value;
            }
        }
        private Decimal? _Qty;
        /// <summary>
        /// 数量
        /// </summary>
        public Decimal? Qty
        {
            get
            {
                return _Qty;
            }
            set
            {
                _Qty = value;
            }
        }
        private Decimal? _Sqty;
        /// <summary>
        /// 实调数量
        /// </summary>
        public Decimal? Sqty
        {
            get
            {
                return _Sqty;
            }
            set
            {
                _Sqty = value;
            }
        }
        private Decimal? _Rprc;
        /// <summary>
        /// 调入价
        /// </summary>
        public Decimal? Rprc
        {
            get
            {
                return _Rprc;
            }
            set
            {
                _Rprc = value;
            }
        }
        private Decimal? _Outprc;
        /// <summary>
        /// 调出价
        /// </summary>
        public Decimal? Outprc
        {
            get
            {
                return _Outprc;
            }
            set
            {
                _Outprc = value;
            }
        }
    }
}