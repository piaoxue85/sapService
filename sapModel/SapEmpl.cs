using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{   
    /// <summary>
    /// 人事主数据
    /// </summary>
    public class SapEmpl
    {
        private string _Pno;
        public string PERNR
        {
            get
            {
                return _Pno;
            }
            set
            {
                _Pno = value;
            }
        }
        private string _Pname;
        public string NACHN
        {
            get
            {
                return _Pname;
            }
            set
            {
                _Pname = value;
            }
        }
        private string _Dept;
        public string ORGEH
        {
            get
            {
                return _Dept;
            }
            set
            {
                _Dept = value;
            }
        }
        private string _Deptname;
        public string SHOR1
        {
            get
            {
                return _Deptname;
            }
            set
            {
                _Deptname = value;
            }
        }
        private string _Compo;
        public string WERKS
        {
            get
            {
                return _Compo;
            }
            set
            {
                _Compo = value;
            }
        }
        private string _Sex;
        /// <summary>
        /// 性别
        /// </summary>
        public string GESCH
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }
        private string _Phone;
        public string USRID
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        private string _Pflag;
        public string STAT2
        {
            get
            {
                return _Pflag;
            }
            set
            {
                _Pflag = value;
            }
        }
        private string _Persg;
        /// <summary>
        /// 员工组
        /// </summary>
        public string Persg
        {
            get
            {
                return _Persg;
            }
            set
            {
                _Persg = value;
            }
        }
        private string _Ptex1;
        /// <summary>
        /// 员工组描述
        /// </summary>
        public string Ptex1
        {
            get
            {
                return _Ptex1;
            }
            set
            {
                _Ptex1 = value;
            }
        }
        private string _Plans;
        /// <summary>
        /// 岗位ID
        /// </summary>
        public string Plans
        {
            get
            {
                return _Plans;
            }
            set
            {
                _Plans = value;
            }
        }
        private string _Ptext;
        /// <summary>
        /// 岗位名
        /// </summary>
        public string SHOR2
        {
            get
            {
                return _Ptext;
            }
            set
            {
                _Ptext = value;
            }
        }
        /// <summary>
        /// 人事范围描述
        /// </summary>
        public string Name1 { get; set; }
    }
}