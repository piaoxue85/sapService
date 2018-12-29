using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    public class SapAllot
    {
        
        private string _Purcode;
        /// <summary>
        /// 单号
        /// </summary>
        public string Purcode
        {
            get
            {
                return _Purcode;
            }
            set
            {
                _Purcode = value;
            }
        }
        /// <summary>
        /// 调配时间
        /// </summary>
        public string Purdate
        {
            get;set;
        }
        /// <summary>
        /// 仓库号
        /// </summary>
        public string Storeno { get; set; }
        private string _Grpno;
        /// <summary>
        /// 部门
        /// </summary>
        public string Grpno
        {
            get
            {
                return _Grpno;
            }
            set
            {
                _Grpno = value;
            }
        }
        private string _Outshop;
        /// <summary>
        /// 调出门店
        /// </summary>
        public string Outshop
        {
            get
            {
                return _Outshop;
            }
            set
            {
                _Outshop = value;
            }
        }
        private string _Wareno;
        /// <summary>
        /// 申请人
        /// </summary>
        public string Wareno
        {
            get
            {
                return _Wareno;
            }
            set
            {
                _Wareno = value;
            }
        }
        
       
        private string _Inshop;
        /// <summary>
        /// 调入门店
        /// </summary>
        public string Inshop
        {
            get
            {
                return _Inshop;
            }
            set
            {
                _Inshop = value;
            }
        }    
        private string _Remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get
            {
                return _Remark;
            }
            set
            {
                _Remark = value;
            }
        }
        /// <summary>
        /// 明细
        /// </summary>
        public SapAllotdet[] Allotdets { get; set; }
    }
}