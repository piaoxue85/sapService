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

        /// <summary>
        /// 退单号
        /// </summary>
        public string EbelnT
        {
            get; set;
        }
      
        /// <summary>
        /// 商品编码
        /// </summary>
        public string Matnr
        {
            get; set;
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Maktx { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string Menge
        {
            get; set;
            
        }
        /// <summary>
        /// 基本单位
        /// </summary>
        public string Meins
        {
            get; set;
        }
        /// <summary>
        /// 工厂
        /// </summary>
        public string Werks
        {
            get; set;
        }
        /// <summary>
        /// 移除库存地点
        /// </summary>
        public string LgortC
        {
            get; set;
        }
        /// <summary>
        /// 移入库存地点
        /// </summary>
        public string LgortR
        {
            get; set;
        }
    }
}