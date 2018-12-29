using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{   
    /// <summary>
    /// 差异移库明细Differential transfer reservoir delivery
    /// </summary>
    public class SapDtrd
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
        private string _Matnr;
        /// <summary>
        /// 商品编码
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
        /// <summary>
        /// 数量
        /// </summary>
        public string Menge
        {
            get; set;
            
        }
        private string _Meins;
        /// <summary>
        /// 基本单位
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
        private string _LgortC;
        /// <summary>
        /// 移除库存地点
        /// </summary>
        public string LgortC
        {
            get
            {
                return _LgortC;
            }
            set
            {
                _LgortC = value;
            }
        }
        private string _LgortR;
        /// <summary>
        /// 移入库存地点
        /// </summary>
        public string LgortR
        {
            get
            {
                return _LgortR;
            }
            set
            {
                _LgortR = value;
            }
        }
    }
}