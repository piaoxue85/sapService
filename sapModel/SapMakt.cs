using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapService.sapModel
{
    /// <summary>
    /// 商品主数据抬头
    /// </summary>
    public class SapMakt
    {
        private string _Matnr;
        /// <summary>
        /// SAP商品编码
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
        private string _Maktx;
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Maktx
        {
            get
            {
                return _Maktx;
            }
            set
            {
                _Maktx = value;
            }
        }
        private string _Maktm;
        /// <summary>
        /// 商品简称
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
        private string _Maktxe;
        /// <summary>
        /// 英文描述
        /// </summary>
        public string Maktxe
        {
            get
            {
                return _Maktxe;
            }
            set
            {
                _Maktxe = value;
            }
        }
        private string _Mtart;
        /// <summary>
        /// 商品类别
        /// </summary>
        public string Mtart
        {
            get
            {
                return _Mtart;
            }
            set
            {
                _Mtart = value;
            }
        }
        private string _Attyp;
        /// <summary>
        /// 商品类别
        /// </summary>
        public string Attyp
        {
            get
            {
                return _Attyp;
            }
            set
            {
                _Attyp = value;
            }
        }
        private string _Matkl;
        /// <summary>
        /// 商品组/物料组
        /// </summary>
        public string Matkl
        {
            get
            {
                return _Matkl;
            }
            set
            {
                _Matkl = value;
            }
        }
        private string _Prdha;
        /// <summary>
        /// 产品层次
        /// </summary>
        public string Prdha
        {
            get
            {
                return _Prdha;
            }
            set
            {
                _Prdha = value;
            }
        }
        private string _Zbrand;
        /// <summary>
        /// 品牌
        /// </summary>
        public string Zbrand
        {
            get
            {
                return _Zbrand;
            }
            set
            {
                _Zbrand = value;
            }
        }
        private string _Wherl;
        /// <summary>
        /// 原产国
        /// </summary>
        public string Wherl
        {
            get
            {
                return _Wherl;
            }
            set
            {
                _Wherl = value;
            }
        }
        private string _Wherr;
        /// <summary>
        /// 产地
        /// </summary>
        public string Wherr
        {
            get
            {
                return _Wherr;
            }
            set
            {
                _Wherr = value;
            }
        }
        private string _Groes;
        /// <summary>
        /// 产地
        /// </summary>
        public string Groes
        {
            get
            {
                return _Groes;
            }
            set
            {
                _Groes = value;
            }
        }
        private string _Taxm1;
        /// <summary>
        /// 销项税码
        /// </summary>
        public string Taxm1
        {
            get
            {
                return _Taxm1;
            }
            set
            {
                _Taxm1 = value;
            }
        }
        private string _Xchpf;
        /// <summary>
        /// 批次管理需求（是否批次）
        /// </summary>
        public string Xchpf
        {
            get
            {
                return _Xchpf;
            }
            set
            {
                _Xchpf = value;
            }
        }
        private string _Hoehe;
        /// <summary>
        /// 高
        /// </summary>
        public string Hoehe
        {
            get
            {
                return _Hoehe;
            }
            set
            {
                _Hoehe = value;
            }
        }
        private string _Breit;
        /// <summary>
        /// 宽
        /// </summary>
        public string Breit
        {
            get
            {
                return _Breit;
            }
            set
            {
                _Breit = value;
            }
        }
        private string _Laeng;
        /// <summary>
        /// 长/深
        /// </summary>
        public string Laeng
        {
            get
            {
                return _Laeng;
            }
            set
            {
                _Laeng = value;
            }
        }
        private string _Meabm;
        /// <summary>
        /// 尺寸单位（长宽高单位）
        /// </summary>
        public string Meabm
        {
            get
            {
                return _Meabm;
            }
            set
            {
                _Meabm = value;
            }
        }
        private string _Mhdhb;
        /// <summary>
        /// 总货架寿命/总保质天数
        /// </summary>
        public string Mhdhb
        {
            get
            {
                return _Mhdhb;
            }
            set
            {
                _Mhdhb = value;
            }
        }
        private string _Iprkz;
        /// <summary>
        /// 期间标识（保质期日期单位）
        /// </summary>
        public string Iprkz
        {
            get
            {
                return _Iprkz;
            }
            set
            {
                _Iprkz = value;
            }
        }
        private string _Raube;
        /// <summary>
        /// 仓库保管属性
        /// </summary>
        public string Raube
        {
            get
            {
                return _Raube;
            }
            set
            {
                _Raube = value;
            }
        }
        private string _Idnrk;
        /// <summary>
        /// 展示商品BOM组件
        /// </summary>
        public string Idnrk
        {
            get
            {
                return _Idnrk;
            }
            set
            {
                _Idnrk = value;
            }
        }
        private string _Tempb;
        /// <summary>
        /// 生鲜特性条件
        /// </summary>
        public string Tempb
        {
            get
            {
                return _Tempb;
            }
            set
            {
                _Tempb = value;
            }
        }
        private string _Ferth;
        /// <summary>
        /// 电器颜色
        /// </summary>
        public string Ferth
        {
            get
            {
                return _Ferth;
            }
            set
            {
                _Ferth = value;
            }
        }
        private string _Iloos;
        /// <summary>
        /// 序列号启用标识/以大批/液体
        /// </summary>
        public string Iloos
        {
            get
            {
                return _Iloos;
            }
            set
            {
                _Iloos = value;
            }
        }
        private string _Zyear;
        /// <summary>
        /// 年份
        /// </summary>
        public string Zyear
        {
            get
            {
                return _Zyear;
            }
            set
            {
                _Zyear = value;
            }
        }
        private string _Zseason;
        /// <summary>
        /// 季节
        /// </summary>
        public string Zseason
        {
            get
            {
                return _Zseason;
            }
            set
            {
                _Zseason = value;
            }
        }
        private string _Color;
        /// <summary>
        /// 服装颜色库
        /// </summary>
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }
        private string _Size1;
        /// <summary>
        /// 服装尺码库
        /// </summary>
        public string Size1
        {
            get
            {
                return _Size1;
            }
            set
            {
                _Size1 = value;
            }
        }
        private string _FshScVconv;
        /// <summary>
        /// 尺码组(待定字段)
        /// </summary>
        public string FshScVconv
        {
            get
            {
                return _FshScVconv;
            }
            set
            {
                _FshScVconv = value;
            }
        }
        private string _Labor;
        /// <summary>
        /// 是否拆零/实验室办公室
        /// </summary>
        public string Labor
        {
            get
            {
                return _Labor;
            }
            set
            {
                _Labor = value;
            }
        }
        /// <summary>
        /// 明细
        /// </summary>
        public SapMarc[] SapMarcs { get; set; }
        /// <summary>
        /// 明细-包装
        /// </summary>
        public SapMarm[] SapMarms { get; set; }
        /// <summary>
        ///  明细-条码
        /// </summary>
        public SapMean[] SapMeans { get; set; }
    }
}