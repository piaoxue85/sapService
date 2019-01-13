using sapService.sapModel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using sapService.nLog;
using System.Collections.Generic;

namespace sapService
{
    /// <summary>
    /// Contorller 分发
    /// </summary>
    [WebService(Description = "LQ-WMS接口", Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class WmsService : System.Web.Services.WebService
    {

        [WebMethod(Description = "WMS接收采购订单信息")]
        /// <summary>
        /// 获取采购订单信息
        /// </summary>
        /// <returns></returns>
        public MessWms getOrder(SapEkko[] orders)
        {
            try
            {
                if (orders==null) {
                    throw new Exception("采购订单为空");
                }
                if (orders.Length > 0)
                {
                    db_log.writeDBLogs("items:" + orders.Length + " key:" + orders[0].Ebeln);
                }
                else
                {
                    db_log.writeDBLogs("items:" + orders.Length + " key:null");
                }
            }
            catch (Exception)
            {
                
            }
            return new getorderBean().transGteorder(orders);

        }
       
        /// <summary>
        /// WMS获取请配单
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        [WebMethod(Description = "WMS 接收请配单")]
        public MessWms SetDel(SapDelo [] tasks)
        {
            return new getorderBean().SetDeldet(tasks);
        }

        /// <summary>
        /// WMS接收商品主数据
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "WMS 接收商品主数据")]
        public MessWms SetMainK(SapMakt [] sapMakts) {
            return new getorderBean().SetMainKi(sapMakts);
        }

       
        /// <summary>
        /// WMS 接收越库单
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "WMS 接收越库单")]
        public MessWms GetOverRun(SapOverrun [] overruns) {
            return new getorderBean().TransOverRun(overruns);
        }
        /// <summary>
        /// WMS 接收供应商主数据
        /// </summary>
        /// <param name="sapLfas"></param>
        /// <returns></returns>
        [WebMethod(Description = "WMS 接收供应商主数据")]
        public MessWms GetCustNo(SapLfa1 [] sapLfas) {
            return new getorderBean().TransCustNO(sapLfas);
        }
        /// <summary>
        /// WMS 接收组织主数据
        /// </summary>
        /// <returns></returns>
        [WebMethod(Description = "WMS 接收组织主数据")]
        public MessWms GetOrganic(SapHrob[] sapHrobs) {

            return new getorderBean().TransOrganic(sapHrobs);
        }

        /// <summary>
        /// WMS 接收人事主数据
        /// </summary>
        /// <returns>MessWms</returns>
        [WebMethod(Description = "WMS 接收人事主数据")]
        public MessWms GetHRI(SapEmpl[] sapEmpls)
        {
   
            return new getorderBean().TransEmpl(sapEmpls);
        }

        /// <summary>
        /// WMS 接收客户主数据
        /// </summary>
        /// <returns>MessWms</returns>
        [WebMethod(Description = "WMS 接收客户主数据")]
        public MessWms GetClient(SapKna1[] sapKnas) {
            return new getorderBean().TransClient(sapKnas);
        }
        /// <summary>
        /// WMS 接收大库请配
        /// </summary>
        /// <returns>MessWms</returns>
        [WebMethod(Description = "WMS 接收大库请配")]
        public MessWms GetAllot(SapAllot[] sapAllots) {
            return new getorderBean().TransAllot(sapAllots);
        }
        /// <summary>
        /// WMS 接收差异移库
        /// </summary>
        /// <returns>MessWms</returns>
        [WebMethod(Description = "WMS 接收差异移库")]
        public MessWms GetDtro(SapDtro[] sapDtros)
        {
            return new getorderBean().TransDtro(sapDtros);
        }






        /// <summary>
        /// 家电请送
        /// </summary>
        /// <returns>List<ConsumerElectric.reTransBean></returns>
        [WebMethod(Description = "家电请送")]
        public List<ConsumerElectric.reTransBean> TranSport(ConsumerElectric.sportBean bean) {
            List<ConsumerElectric.reTransBean> defaultValue = new List<ConsumerElectric.reTransBean>();
            try
            {
                if (bean!=null)
                {
                    List<ConsumerElectric.reTransBean> resultValue = new List<ConsumerElectric.reTransBean>(new ConsumerElectric.ServiceDelegateClient().transport(bean));
                    if (resultValue.Count>0)
                    {
                        defaultValue.AddRange(resultValue);
                    }
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return defaultValue;
        }

        /// <summary>
        /// 获取 大库 库存 
        /// </summary>
        /// <param name="bean"></param>
        /// <returns>List<ConsumerElectric.stockBean></returns>
        [WebMethod(Description = "获取大库的库存 ")]
        public List<ConsumerElectric.stockBean> GetStock(ConsumerElectric.stockBean bean) {
            List<ConsumerElectric.stockBean> defaultValue = new List<ConsumerElectric.stockBean>();
            try
            {
                List<ConsumerElectric.stockBean> resultValue = new List<ConsumerElectric.stockBean>(new ConsumerElectric.ServiceDelegateClient().GetStock(bean));
                if (resultValue.Count > 0)
                {
                    defaultValue.AddRange(resultValue);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return defaultValue;
        }

        /// <summary>
        /// 家电请退
        /// </summary>
        /// <param name="bean"></param>
        /// <returns></returns>
        [WebMethod(Description = "家电请退")]
        public List<ConsumerElectric.reTransBean> GetTranSportT(ConsumerElectric.tsportBean bean)
        {
            List<ConsumerElectric.reTransBean> defaultValue = new List<ConsumerElectric.reTransBean>();
            try
            {
                List<ConsumerElectric.reTransBean> resultValue = new List<ConsumerElectric.reTransBean>(new ConsumerElectric.ServiceDelegateClient().t_trans(bean));
                if (resultValue.Count > 0)
                {
                    defaultValue.AddRange(resultValue);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return defaultValue;
        }

        /// <summary>
        /// 更改预送货日期
        /// </summary>
        /// <param name="bean"></param>
        /// <returns></returns>
        [WebMethod(Description = "大库更改预送货日期")]
        public List<ConsumerElectric.reTransBean> SetChDate(ConsumerElectric.chTasnsdate bean)
        {
            List<ConsumerElectric.reTransBean> defaultValue = new List<ConsumerElectric.reTransBean>();
            try
            {
                List<ConsumerElectric.reTransBean> resultValue = new List<ConsumerElectric.reTransBean>(new ConsumerElectric.ServiceDelegateClient().ch_transdate(bean));
                if (resultValue.Count > 0)
                {
                    defaultValue.AddRange(resultValue);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return defaultValue;
        }

        /// <summary>
        /// 修改单据类型
        /// </summary>
        /// <param name="bean"></param>
        /// <returns>List<ConsumerElectric.reTransBean></returns>
        [WebMethod(Description = "大库更改类型")]
        public List<ConsumerElectric.reTransBean> SetChType(ConsumerElectric.chTranstype bean)
        {
            List<ConsumerElectric.reTransBean> defaultValue = new List<ConsumerElectric.reTransBean>();
            try
            {
                List<ConsumerElectric.reTransBean> resultValue = new List<ConsumerElectric.reTransBean>(new ConsumerElectric.ServiceDelegateClient().ch_transtype(bean));
                if (resultValue.Count > 0)
                {
                    defaultValue.AddRange(resultValue);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return defaultValue;
        }
    }
}
