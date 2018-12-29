using System;
using System.Collections.Generic;
using System.Web;
using CYQ.Data;
using CYQ.Data.Table;
using sapService.Helper;
using sapService.nLog;
using sapService.sapModel;

namespace sapService
{
    public class getorderBean
    {

        private readonly LogInfo _logInfo = LogInfo.createLogInfo("C:\\SapI_log");


        /// <summary>
        /// 处理getorders
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public MessWms transGteorder(SapEkko[] orders)
        {
            StringUtil<SapEkko> pf = new StringUtil<SapEkko>();
             
            try
            {
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;
               
                foreach (SapEkko komodel in orders)
                {
                    _logInfo.Info("transGteorder", "单条表头\r\n" + pf.GetEntityToString(komodel));

                    SapEkpo[] pos = komodel._ekpos;


                    using (MAction action = new MAction("EKKO"))
                    {
                        if (action.Exists("Ebeln = '"+ komodel.Ebeln + "'")) {
                            _logInfo.Debug("transGteorder", "采购单号" + komodel.Ebeln + "重复传输！\r\n");                          
                            continue;
                        }
                        action.BeginTransation();
                       
                        action.AllowInsertID = false;
                        //插入表头
                        action.Set("Ebeln", komodel.Ebeln);
                        action.Set("Bsart", komodel.Bsart);
                        action.Set("Unsez", komodel.Unsez);
                        action.Set("Ihrez", komodel.Ihrez);
                        action.Set("Lifnr", komodel.Lifnr);
                        action.Set("Ekogr", komodel.Ekogr);
                        action.Set("Ekgrp", komodel.Ekgrp);
                        action.Set("Bukrs", komodel.Bukrs);
                        action.Set("Zcomment", komodel.Zcomment);
                        action.Set("Ernam", komodel.Ernam);
                        action.Set("Aedat", komodel.Aedat);
                                                
                        action.Set("pflag", "N");
                        action.Set("ts", DateTime.Now);

                        bool issuccess=  action.Insert(true);
                        //写日志
                        _logInfo.Debug("transGteorder", komodel.Ebeln + action.DebugInfo +"\r\n");                        

                        //插入明细表
                        action.ResetTable("Ekpo",true);
                        foreach (SapEkpo pomodel in pos)
                        {
                            StringUtil<SapEkpo> po = new StringUtil<SapEkpo>();
                            _logInfo.Info("transGteorder", "单条明细\r\n"  + po.GetEntityToString(pomodel));
                            if (pomodel==null)
                            {
                                throw new Exception("传输失败，明细为null");
                            }
                            action.Set("Ebelp", pomodel.Ebelp);
                            action.Set("Pstyp", pomodel.Pstyp);
                            action.Set("Matnr", pomodel.Matnr);
                            action.Set("Txz01", pomodel.Txz01);
                            action.Set("Menge", pomodel.Menge);
                            action.Set("Meins", pomodel.Meins);
                            action.Set("Gewei", pomodel.Gewei);
                            action.Set("Emren", pomodel.Emren);
                            action.Set("Umrez", pomodel.Umrez);
                            action.Set("Eindt", pomodel.Eindt);
                            action.Set("Netpr", pomodel.Netpr);
                            action.Set("Waers", pomodel.Waers);
                            action.Set("Peinh", pomodel.Peinh);
                            action.Set("Bprme", pomodel.Bprme);
                            action.Set("Mwskz", pomodel.Mwskz);
                            action.Set("Matkl", pomodel.Matkl);
                            action.Set("Retpo", pomodel.Retpo);
                            action.Set("Repos", pomodel.Repos);
                            action.Set("Werks", pomodel.Werks);
                            action.Set("Lgort", pomodel.Lgort);
                            action.Set("Brtwr", pomodel.Brtwr);

                            action.Set("Ebeln", komodel.Ebeln);
                            action.Set("pflag", "N");                           
                            action.Insert();
                        }

                        action.EndTransation();

                    }

                }

            }
            catch (Exception ex)
            {
                _logInfo.Error("transGteorder", ex.ToString()+ "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess="处理失败!"+ex.Message
                }; 
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "处理成功!" 
            };

        }



        /// <summary>
        /// WMS 接收大库调配
        /// </summary>
        /// <param name="sapAllots"></param>
        /// <returns></returns>
        public MessWms TransAllot(SapAllot[] sapAllots)
        {
            _logInfo.Info("TransAllot","开始处理大库请配");
            AppConfig.Cache.IsAutoCache = false;
            AppConfig.Debug.OpenDebugInfo = true;
            try
            {
                foreach (SapAllot allot in sapAllots) {
                    StringUtil<SapAllot> @string = new StringUtil<SapAllot>();
                    _logInfo.Info("TransAllot", @string.GetEntityToString(allot));
                    SapAllotdet[] sapAllotdet = allot.Allotdets;
                    using (MAction action = new MAction("allot")) {
                        action.BeginTransation();

                        action.AllowInsertID = false;
                        action.Set("purcode", allot.Purcode);
                        action.Set("purdate", CastUtil.CastDateTime(allot.Purdate));
                        action.Set("storeno", allot.Storeno);
                        action.Set("grpno", allot.Grpno);
                        action.Set("outshop", allot.Outshop);
                        action.Set("inshop", allot.Inshop);
                        action.Set("remark", allot.Remark);
                        action.Set("wareno", allot.Wareno);
                        action.Set("stat", "1");
                        action.Set("hzstat", "N");
                        action.Set("printflag", "N");
                        action.Set("pcnt", 0);
                        action.Set("sendflag", "N");
                        action.Set("pcnt", 0);
                        action.Insert(true);

                        action.ResetTable("Allotdet", true);
                        foreach (SapAllotdet @Allotdet in sapAllotdet) {
                            action.AllowInsertID = false;
                            action.Set("purcode", allot.Purcode);
                            action.Set("incode", @Allotdet.Incode);
                            action.Set("fname", @Allotdet.Fname);
                            action.Set("Unit", @Allotdet.Unit);
                            action.Set("qty", @Allotdet.Qty);
                            action.Set("sqty", @Allotdet.Sqty);
                            action.Set("rprc", @Allotdet.Rprc);
                            action.Set("outprc", @Allotdet.Outprc);
                        }
                        action.BeginTransation();
                        _logInfo.Info("TransAllot", action.DebugInfo);
                    }
                }
                _logInfo.Info("TransAllot", "大库请配单 处理完毕");
            }
            catch (Exception ex)
            {
                _logInfo.Error("TransAllot", ex.ToString() + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "处理失败!" + ex.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "处理成功!"
            };
        }

        /// <summary>
        /// WMS 接收客户主数据
        /// </summary>
        /// <param name="sapKnas"></param>
        /// <returns></returns>
        public  MessWms TransClient(SapKna1[] sapKnas)
        {
            
            if (sapKnas == null)
            {
                throw new Exception("null");
            }
            _logInfo.Info("TransClient", "开始接收客户主数据");
            AppConfig.Cache.IsAutoCache = false;
            AppConfig.Debug.OpenDebugInfo = true;
            try
            {
                foreach (SapKna1 sapKna in sapKnas)
                {
   
                    using (MAction action = new MAction("kna1"))
                    {
                        action.BeginTransation();

                        //查询本条数据 是否需要更新
                        action.SetSelectColumns(new string[] { "id", "Kunnr" });//返回的字段
                        List<SapKna1> lfa1s = action.Select("Kunnr='" + sapKna.Kunnr+"'").ToList<SapKna1>();

                        //如若 lfa1s.Count > 0，执行更新
                        if (lfa1s != null && lfa1s.Count > 0)
                        {
                            if (!action.Delete("Kunnr=" + sapKna.Kunnr))
                            {
                                _logInfo.Error("TransCustNO", "删除重复数据失败\r\n");
                                action.RollBack();
                                return new MessWms()
                                {
                                    TYPE = MessWms.failure,
                                    Mess = "Trans failure !更新客户信息失败, Kunnr:" + sapKna.Kunnr
                                };
                            }
                        }

                        action.AllowInsertID = false;

                        action.Set("Ktokd", sapKna.Ktokd);
                        action.Set("Kunnr", sapKna.Kunnr);
                        action.Set("Name1", sapKna.Name1+sapKna.Name2);
                        action.Set("Regio", sapKna.Regio);
                        action.Set("Tel_Number", sapKna.TelNumber);
                        action.Set("Smtp_Addr", sapKna.SmtpAddr);
                        action.Set("Fax_Number", sapKna.FaxNumber);
                        action.Set("Kukla", sapKna.Kukla);
                        action.Set("Niels", sapKna.Niels);
                        
                        bool issuccess = action.Insert(true);
                       
                        action.EndTransation();
                        //写日志
                        _logInfo.Debug("TransClient", action.DebugInfo + "\r\n");
                    }
                }
            }
            catch (Exception e)
            {
                _logInfo.Error("TransClient", e.Message + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "客户主数据处理失败!" + e.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "客户主数据处理成功!"
            };
        }

        /// <summary>
        /// WMS 接收人事主数据
        /// </summary>
        /// <param name="sapHrobs"></param>
        /// <returns></returns>
        public MessWms TransEmpl(SapEmpl[] sapEmpls)
        {
            _logInfo.Info("TransEmpl", "开始接收人事主数据"+ "\r\n");
            if (sapEmpls == null)
            {
                throw new Exception("null");
            }
            AppConfig.Cache.IsAutoCache = false;
            AppConfig.Debug.OpenDebugInfo = true;
            try
            {
                
                foreach (SapEmpl sapEmpl in sapEmpls)
                {
                    using (MAction action = new MAction("empl"))
                    {
                        action.BeginTransation();
                        action.AllowInsertID = false;

                        action.Set("Pno", sapEmpl.PERNR);
                        action.Set("Dept", sapEmpl.ORGEH);
                        action.Set("Deptname", sapEmpl.SHOR1);
                        action.Set("Plans", sapEmpl.Plans);
                        action.Set("Ptext", sapEmpl.STAT2);
                        action.Set("Compo", sapEmpl.WERKS);
                        action.Set("Persg", sapEmpl.Persg);
                        action.Set("Ptex1", sapEmpl.Ptex1);
                        action.Set("Pflag", sapEmpl.STAT2);
                        action.Set("Pname", sapEmpl.NACHN);
                        action.Set("Sex", sapEmpl.GESCH);
                        action.Set("Phone", sapEmpl.USRID);
                        action.Set("Name1", sapEmpl.Name1);
                        bool issuccess = action.Insert(true);
                        action.EndTransation();
                        //写日志
                        _logInfo.Debug("TransEmpl", sapEmpl.PERNR + action.DebugInfo + "\r\n");
                    }
                }
            }
            catch (Exception e)
            {
                _logInfo.Error("TransEmpl", e.Message + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "HR主数据处理失败!" + e.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "HR主数据处理成功!"
            };
        }

        /// <summary>
        /// WMS 接收组织主数据
        /// </summary>
        /// <param name="sapHrobs"></param>
        /// <returns></returns>
        public MessWms TransOrganic(SapHrob[] sapHrobs)
        {
            if (sapHrobs == null)
            {
                throw new Exception("null");
            }
            _logInfo.Info("TransEmpl", "开始接收组织主数据" + "\r\n");
            AppConfig.Cache.IsAutoCache = false;
            AppConfig.Debug.OpenDebugInfo = true;
            try {                          
                foreach (SapHrob sapHrob in sapHrobs) {
                    using (MAction action = new MAction("HROB")) {
                        action.BeginTransation();
                        action.AllowInsertID = false;
                        action.Set("Otype", sapHrob.Otype);
                        action.Set("ObjID", sapHrob.ObjID);
                        action.Set("Stext", sapHrob.Stext);
                        action.Set("SobID", sapHrob.SobID);
                        action.Set("Zbmfzr", sapHrob.Zbmfzr);
                        action.Set("Zjglx", sapHrob.Zjglx);
                        action.Set("MDBH", sapHrob.MDBH);
                        bool issuccess = action.Insert(true);                     
                        action.EndTransation();
                        //写日志
                        _logInfo.Debug("TransOrganic", sapHrob.ObjID + action.DebugInfo + "\r\n");
                    }    
                }
            } catch (Exception e) {
                _logInfo.Error("TransOrganic", e.ToString() + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "组织主数据处理失败!" + e.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "组织主数据处理成功!"
            };
        }  
       
        /// <summary>
        /// WMS 处理 越库单 
        /// </summary>
        /// <param name="overruns"></param>
        /// <returns></returns>
        public  MessWms TransOverRun(SapOverrun[] overruns)
        {
            _logInfo.Info("TransOverRun", "开始处理越库单\r\n" );
            StringUtil<SapOverrun> pf = new StringUtil<SapOverrun>();
            try
            {
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;

                foreach (SapOverrun komodel in overruns)
                {

                    _logInfo.Info("TransOverRun", "单条:\r\n" + pf.GetEntityToString(komodel));

                    using (MAction action = new MAction("overrun"))
                    {                      
                        action.BeginTransation();
                        //查询本条数据 是否需要更新
                        action.SetSelectColumns(new string[] { "Elben" });//返回的字段
                        List<SapOverrun> beans = action.Select("Elben='" + komodel.Elben + "' and Matnr='"+ komodel.Matnr+"'").ToList<SapOverrun>();
                        //如若 lfa1s.Count > 0，执行更新
                        if (beans != null && beans.Count > 0)
                        {
                            _logInfo.Debug("TransOverRun", "越库单号" + komodel.Elben + "重复传输！\r\n");
                            continue;
                        }
                        action.AllowInsertID = false;
                        //插入表头
                        action.Set("Elben", komodel.Elben);
                        action.Set("Elben2", komodel.Elben2);                       
                        action.Set("Lgort", komodel.Lgort);
                        action.Set("EKGRP", komodel.Ekgrp);
                        action.Set("Retpo", komodel.Retpo);
                        action.Set("Lifnr", komodel.Lifnr);
                        action.Set("Reswk", komodel.Reswk);
                        action.Set("Ernam", komodel.Ernam);
                        action.Set("Aedat", CastUtil.CastDateTime(komodel.Aedat));
                        action.Set("Elelp", komodel.Elelp);
                        action.Set("Matnr", komodel.Matnr);
                        action.Set("MAKTX", komodel.Maktx);
                        action.Set("Menge", komodel.Menge);
                        action.Set("Meins", komodel.Meins);
                        action.Set("Wrbtr1", komodel.Wrbtr1);
                        action.Set("Netpr1", komodel.Netpr1);
                        action.Set("Wrbtr2", komodel.Wrbtr2);
                        action.Set("Netpr2", komodel.Netpr2);                       
                        action.Set("Kunnr", komodel.Kunnr);
                        action.Set("Zregz", komodel.Zregz);
                        action.Set("Zbz", komodel.Zbz);

                        action.Set("wmscode", "Y" + komodel.Elben);

                        action.Set("pflag", "N");
                        action.Set("ts", DateTime.Now);

                        bool issuccess = action.Insert(true);
                           
                        action.EndTransation();
                        //写日志
                        _logInfo.Debug("TransOverRun", komodel.Elben + action.DebugInfo + "\r\n");
                    }

                }

            }
            catch (Exception ex)
            {
                _logInfo.Error("TransOverRun", ex.ToString() + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "处理失败!" + ex.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "处理成功!"
            };
        }

        /// <summary>
        /// 商品主数据接收
        /// </summary>
        /// <returns></returns>
        public MessWms SetMainKi(SapMakt[] sapMakts)
        {
            _logInfo.Info("SetMainKi", " wms 开始接收商品主数据\r\n");
            try
            {
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;

                foreach (SapMakt item in sapMakts)
                {

                    SapMarc[] SapMarcs = item.SapMarcs;
                    SapMarm[] SapMarms = item.SapMarms;
                    SapMean[] SapMeans = item.SapMeans;

                    StringUtil<SapMakt> pf = new StringUtil<SapMakt>();                                   
                   
                    _logInfo.Info("SetMainKi", "单条 SapMakt @:\r\n" + pf.GetEntityToString(item));
                    

                    using (MAction action = new MAction("MAKT"))//主表
                    {
                        action.BeginTransation();//提交事务

                        //查询本条数据 是否需要更新
                        action.SetSelectColumns(new string[] { "id", "Matnr" });//返回的字段
                        List<SapMakt> lfa1s = action.Select("Matnr='" + item.Matnr+"'").ToList<SapMakt>();

                        //如若 lfa1s.Count > 0，执行更新
                        if (lfa1s != null && lfa1s.Count > 0)
                        {
                            if (!action.Delete("Matnr='" + item.Matnr + "'"))
                            {
                                _logInfo.Error("SetMainKi", "删除重复数据失败\r\n");
                                action.RollBack();
                                return new MessWms()
                                {
                                    TYPE = MessWms.failure,
                                    Mess = "Trans failure !更新商品主数据失败, Matnr:" + item.Matnr
                                };
                            }
                        }


                        action.AllowInsertID = false;
                        //插入表头
                        action.Set("Matnr", item.Matnr);
                        action.Set("Maktx", item.Maktx);
                        action.Set("Maktm", item.Maktm);
                        action.Set("MAKTX_E", item.Maktxe);
                        action.Set("Mtart", item.Mtart);
                        action.Set("Attyp", item.Attyp);
                        action.Set("Matkl", item.Matkl);
                        action.Set("Prdha", item.Prdha);
                        action.Set("Zbrand", item.Zbrand);
                        action.Set("Wherl", item.Wherl);
                        action.Set("Wherr", item.Wherr);
                        action.Set("Groes", item.Groes);
                        action.Set("Taxm1", item.Taxm1);
                        action.Set("Xchpf", item.Xchpf);
                        action.Set("Hoehe", CastUtil.CastDecimal(item.Hoehe));
                        action.Set("Breit", CastUtil.CastDecimal(item.Breit));
                        action.Set("Laeng", CastUtil.CastDecimal(item.Laeng));
                        action.Set("Meabm", item.Meabm);
                        action.Set("Mhdhb", CastUtil.CastDecimal(item.Mhdhb));
                        action.Set("Iprkz", item.Iprkz);
                        action.Set("Raube", item.Raube);
                        action.Set("Idnrk", item.Idnrk);
                        action.Set("Tempb", item.Tempb);
                        action.Set("Ferth", item.Ferth);
                        action.Set("Iloos", item.Iloos);
                        action.Set("Zyear", item.Zyear);
                        action.Set("Zseason", item.Zseason);
                        action.Set("Color", item.Color);
                        action.Set("Size1", item.Size1);
                        action.Set("FSH_SC_VCONV", item.FshScVconv);
                        action.Set("Labor", item.Labor);

                        bool issuccess = action.Insert(true);

                        //插入明细表
                        action.ResetTable("MARC", true);
                        //如若 lfa1s.Count > 0，执行更新
                        if (lfa1s != null && lfa1s.Count > 0)
                        {
                            if (!action.Delete("Matnr='" + item.Matnr + "'"))
                            {
                                _logInfo.Error("SetMainKi", "删除重复数据 MARC 失败\r\n");
                                action.RollBack();
                                return new MessWms()
                                {
                                    TYPE = MessWms.failure,
                                    Mess = "Trans failure !更新商品主数据失败, Matnr:" + item.Matnr
                                };
                            }
                        }
                        foreach (SapMarc marcs in SapMarcs)
                        {
                            StringUtil<SapMarc> pf2 = new StringUtil<SapMarc>();
                            _logInfo.Info("SetMainKi", "单条 SapMarc @:\r\n" + pf2.GetEntityToString(marcs));

                            action.Set("Matnr", item.Matnr);
                            action.Set("Asort", marcs.Asort);
                            action.Set("Werks", marcs.Werks);
                            action.Set("Datbi", CastUtil.CastDateTime(marcs.Datbi));
                            action.Set("Datab", CastUtil.CastDateTime(marcs.Datab));
                            action.Set("Mmsta", marcs.Mmsta);
                            action.Set("Xmcng", marcs.Xmcng);
                            action.Set("CONS_PROCG", marcs.ConsProcg);
                            action.Set("Mwsk1", marcs.Mwsk1);
                            action.Set("Zdsj", CastUtil.CastDecimal(marcs.Zdsj));
                            action.Set("Kbetr", CastUtil.CastDecimal(marcs.Kbetr));
                            action.Set("Zp03", CastUtil.CastDecimal(marcs.Zp03));
                            action.Set("Ekgrp", marcs.Ekgrp);
                            action.Insert(true);
                        }

                        //插入明细表
                        action.ResetTable("MARM", true);
                        //如若 lfa1s.Count > 0，执行更新
                        if (lfa1s != null && lfa1s.Count > 0)
                        {
                            if (!action.Delete("Matnr='" + item.Matnr + "'"))
                            {
                                _logInfo.Error("SetMainKi", "删除重复数据 MARM 失败\r\n");
                                action.RollBack();
                                return new MessWms()
                                {
                                    TYPE = MessWms.failure,
                                    Mess = "Trans failure !更新商品主数据失败, Matnr:" + item.Matnr
                                };
                            }
                        }
                        foreach (SapMarm marms in SapMarms)
                        {
                            StringUtil<SapMarm> pf3 = new StringUtil<SapMarm>();
                            _logInfo.Info("SetMainKi", "单条 SapMarm @:\r\n" + pf3.GetEntityToString(marms));

                            action.Set("Matnr", item.Matnr);
                            action.Set("Umrez", CastUtil.CastDecimal(marms.Umrez));
                            action.Set("Meins", marms.Meins);
                            action.Set("Maktm", marms.Maktm);
                            action.Set("Umren", CastUtil.CastDecimal(marms.Umren));
                            action.Set("Meinh", marms.Meinh);

                            action.Insert(true);
                        }

                        //插入明细表
                        action.ResetTable("MEAN", true);
                        //如若 lfa1s.Count > 0，执行更新
                        if (lfa1s != null && lfa1s.Count > 0)
                        {
                            if (!action.Delete("Matnr='" + item.Matnr + "'"))
                            {
                                _logInfo.Error("SetMainKi", "删除重复数据 MEAN 失败\r\n");
                                action.RollBack();
                                return new MessWms()
                                {
                                    TYPE = MessWms.failure,
                                    Mess = "Trans failure !更新商品主数据失败, Matnr:" + item.Matnr
                                };
                            }
                            _logInfo.Error("SetMainKi", "删除重复数据 MEAN 成功\r\n");
                        }
                        foreach (SapMean means in SapMeans)
                        {
                            StringUtil<SapMean> pf4 = new StringUtil<SapMean>();
                            _logInfo.Info("SetMainKi", "单条 SapMean @:\r\n" + pf4.GetEntityToString(means));

                            action.Set("Matnr", item.Matnr);
                            action.Set("Eantp", means.Eantp);
                            action.Set("EAN11", means.Ean11);
                            action.Insert(true);
                        }

                        action.EndTransation();

                        //写日志
                        _logInfo.Debug("SetMainKi", item.Matnr + action.DebugInfo + "\r\n");
                    }

                }

            }
            catch (Exception ex)
            {
                _logInfo.Error("SetMainKi", ex.ToString() + "\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "处理失败!" + ex.Message
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "处理成功!"
            };

        }

        /// <summary>
        /// WMS获取请配单
        /// </summary>
        /// <returns></returns>
        public MessWms SetDeldet(SapDelo [] tasks) {
            _logInfo.Debug("Setputorder", "开始处理请配单\r\n");
            try
            {
               
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;
                foreach (SapDelo Demodel in tasks)
                {
                    StringUtil<SapDelo> @delo = new StringUtil<SapDelo>();
                    _logInfo.Debug("Setputorder", "开始处理请配单表头:{["+ @delo.GetEntityToString(Demodel) + "]}\r\n");
                    SapDeld [] sapdelds = Demodel._delds; //取出明细
                    using (MAction action = new MAction("DELO"))
                    {
                        action.BeginTransation();

                        action.AllowInsertID = false;
                        //插入表头
                        action.Set("Ebeln", Demodel.Ebeln);
                        action.Set("Bsart", Demodel.Bsart);
                        action.Set("Zjj", Demodel.Zjj);
                        action.Set("Zfree", Demodel.Zfree);
                        action.Set("Ztype", Demodel.Ztype);
                        action.Set("Reswk", Demodel.Reswk);
                        action.Set("Ekgrp", Demodel.Ekgrp);
                        action.Set("Reslo", Demodel.Reslo);
                        action.Set("Kunnr", Demodel.Kunnr);
                        action.Set("Znwx", Demodel.Znwx);
                        action.Set("Zregz", Demodel.Zregz);
                        action.Set("EINDT", CastUtil.CastDateTime(Demodel.Eindt));
                        action.Set("Zbz", Demodel.Zbz);
                        action.Set("Ernam", Demodel.Ernam);
                        action.Set("AEDAT", CastUtil.CastDateTime(Demodel.Aedat));
                        action.Set("VSBED", Demodel.VSBED);
                        action.Set("RETPO", Demodel.RETPO);
                        action.Set("EbelnO", Demodel.EbelnO);

                        bool issuccess = action.Insert(true);                        

                        //插入明细表
                        action.ResetTable("DELD", true);
                        foreach (SapDeld sapDeld in sapdelds)
                        {
                            StringUtil<SapDeld> @deld = new StringUtil<SapDeld>();
                            _logInfo.Debug("Setputorder", "开始处理请配单明细:{[" + @deld.GetEntityToString(sapDeld) + "]}\r\n");
                            action.Set("Ebeln", Demodel.Ebeln);
                            action.Set("Ebelp", sapDeld.Ebelp);
                            action.Set("Matnr", sapDeld.Matnr);
                            action.Set("Maktx", sapDeld.Maktx);
                            action.Set("Werks", sapDeld.Werks);
                            action.Set("Menge", sapDeld.Menge);
                            action.Set("Zbatch", sapDeld.Zbatch);
                            action.Set("Zwmcw", sapDeld.Zwmcw);
                            action.Set("DATBI", CastUtil.CastDateTime(sapDeld.Datbi));
                            action.Set("Charg", sapDeld.Charg);
                            action.Set("Meins", sapDeld.Meins);
                            action.Set("Wrbtr", sapDeld.Wrbtr);
                            action.Set("Netpr", sapDeld.Netpr);
                           
                            action.Insert(true);
                            _logInfo.Debug("SetDeldet", Demodel.Ebeln + "||" + action.DebugInfo + "\r\n");
                        }
                        action.EndTransation();//处理
                    }
                  
                }
                //写日志
                _logInfo.Debug("TransTask", "请配单写入完毕\r\n");
            }
            catch (Exception Ex)
            {
                _logInfo.Debug("TransTask", "请配单异常\r\n"+Ex);
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "处理失败!" + Ex.Message
                };
            }
           
            return new MessWms()
            {
                TYPE = MessWms.success,
                Mess = "处理成功!"
            };

        }
       
        /// <summary>
        /// WMS 接收供应商主数据
        /// </summary>
        /// <param name="sapLfas"></param>
        /// <returns></returns>
        public MessWms TransCustNO(SapLfa1[] sapLfas)
        {
            _logInfo.Info("TransCustNO", "开始处理接收供应商主数据\r\n");
            try {
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;
                if (sapLfas != null)
                {
                    foreach (SapLfa1 sapLfa in sapLfas)
                    {
                        _logInfo.Debug("TransCustNO", "传输"+ sapLfa.Lifnr + "\r\n");
                        using (MAction action = new MAction("lfa1"))
                        {
                            action.BeginTransation();
                            //查询本条数据 是否需要更新
                            action.SetSelectColumns(new string[] {"id","Lifnr", "name1" });//返回的字段
                            List<SapLfa1> lfa1s= action.Select("Lifnr='" + sapLfa.Lifnr+"'").ToList<SapLfa1>();

                            //如若 lfa1s.Count > 0，执行更新
                            if (lfa1s != null && lfa1s.Count > 0)
                            {
                                bool flag = action.Delete("Lifnr='" + sapLfa.Lifnr+"'");
                                if (!flag)
                                {
                                    _logInfo.Error("TransCustNO", "删除重复数据失败\r\n");
                                    action.RollBack();
                                    return new MessWms()
                                    {
                                        TYPE = MessWms.failure,
                                        Mess = "Trans failure !更新供应商信息失败 lifnr:"+ sapLfa.Lifnr
                                    };
                                }
                            }

                            action.AllowInsertID = false;
                            action.Set("Ktokk", sapLfa.Ktokk);
                            action.Set("Lifnr", sapLfa.Lifnr);
                            action.Set("Name1", sapLfa.Name1);
                            action.Set("Taxnumxl", sapLfa.Taxnumxl);
                            action.Set("Stras", sapLfa.Stras);
                            action.Set("NameCo", sapLfa.NameCo);
                            action.Set("Name3", sapLfa.Name3);
                            action.Set("rstlz", sapLfa.Pstlz);
                            action.Set("TelNumber", sapLfa.TelNumber);
                            action.Set("FaxNumber", sapLfa.FaxNumber);
                            action.Set("SmtpAddr", sapLfa.SmtpAddr);
                            action.Set("Waers", sapLfa.Waers);
                            action.Set("Langu", sapLfa.Langu);
                            action.Set("Country", sapLfa.Country);
                            action.Set("Loekz", sapLfa.Loekz);
                            action.Set("Bankl", sapLfa.Bankl);
                            action.Set("Banks", sapLfa.Banks);
                            action.Set("Bankn", sapLfa.Bankn);
                            action.Set("Bkref", sapLfa.Bkref);
                            action.Set("Koinh", sapLfa.Koinh);
                            action.Set("Akont", sapLfa.Akont);
                            action.Set("Loekz", sapLfa.Loekz);
                            action.Set("Ekorg", sapLfa.Ekorg);

                            action.Insert(true);
                            _logInfo.Debug("TransCustNO", "sql 语句:" + action.DebugInfo + "\r\n");


                            action.EndTransation();
                            
                        }
                    }
                    //写日志
                    _logInfo.Debug("TransCustNO", "写入完毕\r\n");
                       
                }
               
            }
            catch (Exception e)
            {
                _logInfo.Error("TransCustNO", "处理失败！"+e+"\r\n");
                return new MessWms()
                {
                    TYPE = MessWms.failure,
                    Mess = "处理失败!"+e
                };
            }
            return new MessWms()
            {
                TYPE = MessWms.failure,
                Mess = "处理成功!"
            };
        }

        /// <summary>
        /// WMS 接收差异移库退单
        /// </summary>
        /// <param name="sapDtros"></param>
        /// <returns></returns>
        public MessWms TransDtro(SapDtro[] sapDtros)
        {
            try
            {
                _logInfo.Info("TransDtro", "开始接收差异移库单\r\n");
                AppConfig.Cache.IsAutoCache = false;
                AppConfig.Debug.OpenDebugInfo = true;
                if (sapDtros.Length>0)
                {
                    foreach (SapDtro bean in sapDtros)
                    {
                        SapDtrd[] sapDtrds = bean.sapDtrds; //取出明细
                        using (MAction action = new MAction("DTRO"))
                        {
                            action.BeginTransation();

                            action.AllowInsertID = false;
                            //插入表头
                            action.Set("EBELN_T", bean.EbelnT);
                            action.Set("EBELN_Y", bean.EbelnY);
                            action.Set("BLDAT", CastUtil.CastDateTime(bean.Bldat));
                            action.Set("BNAME", bean.Bname);
                            action.Set("EKGRP", bean.Ekgrp);

                            bool issuccess = action.Insert(true);

                            //插入明细表
                            action.ResetTable("DTRD", true);
                            foreach (SapDtrd item in sapDtrds)
                            {
                                _logInfo.Info("TransDtro", "开始处理差异移库单:[" + bean.EbelnT + "]-["+ item.Matnr + "]\r\n");
                                action.Set("EBELN_T",bean.EbelnT);                                
                                action.Set("Matnr", item.Matnr);
                                action.Set("MENGE", CastUtil.CastDecimal(item.Menge));
                                action.Set("MEINS", item.Meins);
                                action.Set("Werks", item.Werks);
                                action.Set("LGORT_C", item.LgortC);
                                action.Set("LGORT_R", item.LgortR);

                                action.Insert(true);
                                _logInfo.Info("TransDtro", action.DebugInfo + "\r\n");
                            }
                            action.EndTransation();//处理
                        }

                    }
                    //写日志
                    _logInfo.Info("TransDtro", "差异移库单写入完毕\r\n");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return new MessWms()
            {
                TYPE = MessWms.failure,
                Mess = "处理成功!"
            };
        }
    }
}