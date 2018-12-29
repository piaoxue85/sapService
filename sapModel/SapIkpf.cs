using System;
using System.Collections.Generic;
using System.Web;

namespace sapService.sapModel
{
    public class SapIkpf
    {
        private string _Iblnr;
        /// <summary>
        /// 凭证编号
        /// </summary>
        public string Iblnr
        {
            get
            {
                return _Iblnr;
            }
            set
            {
                _Iblnr = value;
            }
        }
        private string _Bldat;
        /// <summary>
        /// 凭证日期
        /// </summary>
        public string Bldat
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
        private string _Zldat;
        /// <summary>
        /// 计划盘点日期
        /// </summary>
        public string Zldat
        {
            get
            {
                return _Zldat;
            }
            set
            {
                _Zldat = value;
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
        
        private string _Usnam;
        /// <summary>
        /// 制单人
        /// </summary>
        public string Usnam
        {
            get
            {
                return _Usnam;
            }
            set
            {
                _Usnam = value;
            }
        }
        /// <summary>
        /// 明细
        /// </summary>
        public SapIseg[] _isegs { get; set; }
    }
}