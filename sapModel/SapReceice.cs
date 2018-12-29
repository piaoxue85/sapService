using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapReceice
    {
        private DateTime? _Bldat;
        /// <summary>
        /// 凭证日期
        /// </summary>
        public DateTime? Bldat
        {
            get
            {
                return _Bldat;
            }
            set
            {
                _Bldat = value;
            }
        }
        private DateTime? _Budat;
        /// <summary>
        /// 过账日期
        /// </summary>
        public DateTime? Budat
        {
            get
            {
                return _Budat;
            }
            set
            {
                _Budat = value;
            }
        }
        private string _Ebeln;
        /// <summary>
        /// 采购订单编号
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
    }
}