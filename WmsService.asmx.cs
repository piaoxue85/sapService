using sapService.sapModel;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using sapService.nLog;

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










    }
}
