using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    public class SapMarm
    {       
        private string _Umrez;
        /// <summary>
        /// 基本单位系数
        /// </summary>
        public string Umrez
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
        private string _Maktm;
        /// <summary>
        /// 基本单位描述
        /// </summary>
        public string Maktm
        {
            get
            {
                return _Maktm;
            }
            set
            {
                _Maktm = value;
            }
        }
        private string _Umren;
        /// <summary>
        /// 包装单位系数
        /// </summary>
        public string Umren
        {
            get
            {
                return _Umren;
            }
            set
            {
                _Umren = value;
            }
        }
        private string _Meinh;
        /// <summary>
        /// 包装单位
        /// </summary>
        public string Meinh
        {
            get
            {
                return _Meinh;
            }
            set
            {
                _Meinh = value;
            }
        }
    }
}