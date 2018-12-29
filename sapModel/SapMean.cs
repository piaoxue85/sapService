using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// 明细条码
    /// </summary>
    public class SapMean
    {
        private string _Eantp;
        /// <summary>
        /// 条码类别
        /// </summary>
        public string Eantp
        {
            get
            {
                return _Eantp;
            }
            set
            {
                _Eantp = value;
            }
        }
        private string _Ean11;
        /// <summary>
        /// 条码(EAN)
        /// </summary>
        public string Ean11
        {
            get
            {
                return _Ean11;
            }
            set
            {
                _Ean11 = value;
            }
        }
    }
}