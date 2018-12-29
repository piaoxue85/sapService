using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapIseg
    {
        private string _Matnr;
        /// <summary>
        /// 物料编码
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
    }
}