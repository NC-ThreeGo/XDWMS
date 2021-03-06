//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Unity.Attributes;
using System.Transactions;
using Apps.BLL.Core;
using Apps.Locale;
using LinqToExcel;
using System.IO;
using System.Text;
using Apps.IDAL.WMS;
using Apps.Models.WMS;
using Apps.IBLL.WMS;
namespace Apps.BLL.WMS
{
	public partial class WMS_ReturnInspectionBLL: Virtual_WMS_ReturnInspectionBLL,IWMS_ReturnInspectionBLL
	{
        

	}
	public class Virtual_WMS_ReturnInspectionBLL
	{
        [Dependency]
        public IWMS_ReturnInspectionRepository m_Rep { get; set; }

		public virtual List<WMS_ReturnInspectionModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<WMS_ReturnInspection> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								
								a=>a.ReturnInspectionNum.Contains(queryStr)
								|| a.PartCustomerCode.Contains(queryStr)
								|| a.PartCustomerCodeName.Contains(queryStr)
								|| a.PrintStatus.Contains(queryStr)
								
								|| a.PrintMan.Contains(queryStr)
								|| a.Remark.Contains(queryStr)
								|| a.InspectMan.Contains(queryStr)
								
								|| a.InspectStatus.Contains(queryStr)
								|| a.CheckOutResult.Contains(queryStr)
								
								
								|| a.Lot.Contains(queryStr)
								|| a.ConfirmStatus.Contains(queryStr)
								|| a.ConfirmMan.Contains(queryStr)
								
								|| a.ConfirmRemark.Contains(queryStr)
								|| a.Attr1.Contains(queryStr)
								|| a.Attr2.Contains(queryStr)
								|| a.Attr3.Contains(queryStr)
								|| a.Attr4.Contains(queryStr)
								|| a.Attr5.Contains(queryStr)
								|| a.CreatePerson.Contains(queryStr)
								
								|| a.ModifyPerson.Contains(queryStr)
								
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            //排序
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }

		public virtual List<WMS_ReturnInspectionModel> GetListByUserId(ref GridPager pager, string userId,string queryStr)
		{
			return new List<WMS_ReturnInspectionModel>();
		}
		
		public virtual List<WMS_ReturnInspectionModel> GetListByParentId(ref GridPager pager, string queryStr,object parentId)
        {
			return new List<WMS_ReturnInspectionModel>();
		}

        public virtual List<WMS_ReturnInspectionModel> CreateModelList(ref IQueryable<WMS_ReturnInspection> queryData)
        {

            List<WMS_ReturnInspectionModel> modelList = (from r in queryData
                                              select new WMS_ReturnInspectionModel
                                              {
													Id = r.Id,
													ReturnInspectionNum = r.ReturnInspectionNum,
													PartCustomerCode = r.PartCustomerCode,
                                                  PartCustomerCodeName = r.PartCustomerCodeName,
													PartID = r.PartID,
													Qty = r.Qty,
													CustomerId = r.CustomerId,
													SupplierId = r.SupplierId,
													PCS = r.PCS,
													Volume = r.Volume,
													InvId = r.InvId,
													SubInvId = r.SubInvId,
													PrintStatus = r.PrintStatus,
													PrintDate = r.PrintDate,
													PrintMan = r.PrintMan,
													Remark = r.Remark,
													InspectMan = r.InspectMan,
													InspectDate = r.InspectDate,
													InspectStatus = r.InspectStatus,
													CheckOutResult = r.CheckOutResult,
													QualifyQty = r.QualifyQty,
													NoQualifyQty = r.NoQualifyQty,
													Lot = r.Lot,
													ConfirmStatus = r.ConfirmStatus,
													ConfirmMan = r.ConfirmMan,
													ConfirmDate = r.ConfirmDate,
													ConfirmRemark = r.ConfirmRemark,
													Attr1 = r.Attr1,
													Attr2 = r.Attr2,
													Attr3 = r.Attr3,
													Attr4 = r.Attr4,
													Attr5 = r.Attr5,
													CreatePerson = r.CreatePerson,
													CreateTime = r.CreateTime,
													ModifyPerson = r.ModifyPerson,
													ModifyTime = r.ModifyTime,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, WMS_ReturnInspectionModel model)
        {
            try
            {
                WMS_ReturnInspection entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new WMS_ReturnInspection();
               				entity.Id = model.Id;
				entity.ReturnInspectionNum = model.ReturnInspectionNum;
				entity.PartCustomerCode = model.PartCustomerCode;
				entity.PartCustomerCodeName = model.PartCustomerCodeName;
				entity.PartID = model.PartID;
				entity.Qty = model.Qty;
				entity.CustomerId = model.CustomerId;
				entity.SupplierId = model.SupplierId;
				entity.PCS = model.PCS;
				entity.Volume = model.Volume;
				entity.InvId = model.InvId;
				entity.SubInvId = model.SubInvId;
				entity.PrintStatus = model.PrintStatus;
				entity.PrintDate = model.PrintDate;
				entity.PrintMan = model.PrintMan;
				entity.Remark = model.Remark;
				entity.InspectMan = model.InspectMan;
				entity.InspectDate = model.InspectDate;
				entity.InspectStatus = model.InspectStatus;
				entity.CheckOutResult = model.CheckOutResult;
				entity.QualifyQty = model.QualifyQty;
				entity.NoQualifyQty = model.NoQualifyQty;
				entity.Lot = model.Lot;
				entity.ConfirmStatus = model.ConfirmStatus;
				entity.ConfirmMan = model.ConfirmMan;
				entity.ConfirmDate = model.ConfirmDate;
				entity.ConfirmRemark = model.ConfirmRemark;
				entity.Attr1 = model.Attr1;
				entity.Attr2 = model.Attr2;
				entity.Attr3 = model.Attr3;
				entity.Attr4 = model.Attr4;
				entity.Attr5 = model.Attr5;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
  

                if (m_Rep.Create(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.InsertFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }



         public virtual bool Delete(ref ValidationErrors errors, object id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

        public virtual bool Delete(ref ValidationErrors errors, object[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                {
                    using (TransactionScope transactionScope = new TransactionScope())
                    {
                        if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
                        {
                            transactionScope.Complete();
                            return true;
                        }
                        else
                        {
                            Transaction.Current.Rollback();
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

		
       

        public virtual bool Edit(ref ValidationErrors errors, WMS_ReturnInspectionModel model)
        {
            try
            {
                WMS_ReturnInspection entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.ReturnInspectionNum = model.ReturnInspectionNum;
				entity.PartCustomerCode = model.PartCustomerCode;
				entity.PartCustomerCodeName = model.PartCustomerCodeName;
				entity.PartID = model.PartID;
				entity.Qty = model.Qty;
				entity.CustomerId = model.CustomerId;
				entity.SupplierId = model.SupplierId;
				entity.PCS = model.PCS;
				entity.Volume = model.Volume;
				entity.InvId = model.InvId;
				entity.SubInvId = model.SubInvId;
				entity.PrintStatus = model.PrintStatus;
				entity.PrintDate = model.PrintDate;
				entity.PrintMan = model.PrintMan;
				entity.Remark = model.Remark;
				entity.InspectMan = model.InspectMan;
				entity.InspectDate = model.InspectDate;
				entity.InspectStatus = model.InspectStatus;
				entity.CheckOutResult = model.CheckOutResult;
				entity.QualifyQty = model.QualifyQty;
				entity.NoQualifyQty = model.NoQualifyQty;
				entity.Lot = model.Lot;
				entity.ConfirmStatus = model.ConfirmStatus;
				entity.ConfirmMan = model.ConfirmMan;
				entity.ConfirmDate = model.ConfirmDate;
				entity.ConfirmRemark = model.ConfirmRemark;
				entity.Attr1 = model.Attr1;
				entity.Attr2 = model.Attr2;
				entity.Attr3 = model.Attr3;
				entity.Attr4 = model.Attr4;
				entity.Attr5 = model.Attr5;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
 


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.NoDataChange);
                    return false;
                }

            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

      

        public virtual WMS_ReturnInspectionModel GetById(object id)
        {
            if (IsExists(id))
            {
                WMS_ReturnInspection entity = m_Rep.GetById(id);
                WMS_ReturnInspectionModel model = new WMS_ReturnInspectionModel();
                              				model.Id = entity.Id;
				model.ReturnInspectionNum = entity.ReturnInspectionNum;
				model.PartCustomerCode = entity.PartCustomerCode;
				model.PartCustomerCodeName = entity.PartCustomerCodeName;
				model.PartID = entity.PartID;
				model.Qty = entity.Qty;
				model.CustomerId = entity.CustomerId;
				model.SupplierId = entity.SupplierId;
				model.PCS = entity.PCS;
				model.Volume = entity.Volume;
				model.InvId = entity.InvId;
				model.SubInvId = entity.SubInvId;
				model.PrintStatus = entity.PrintStatus;
				model.PrintDate = entity.PrintDate;
				model.PrintMan = entity.PrintMan;
				model.Remark = entity.Remark;
				model.InspectMan = entity.InspectMan;
				model.InspectDate = entity.InspectDate;
				model.InspectStatus = entity.InspectStatus;
				model.CheckOutResult = entity.CheckOutResult;
				model.QualifyQty = entity.QualifyQty;
				model.NoQualifyQty = entity.NoQualifyQty;
				model.Lot = entity.Lot;
				model.ConfirmStatus = entity.ConfirmStatus;
				model.ConfirmMan = entity.ConfirmMan;
				model.ConfirmDate = entity.ConfirmDate;
				model.ConfirmRemark = entity.ConfirmRemark;
				model.Attr1 = entity.Attr1;
				model.Attr2 = entity.Attr2;
				model.Attr3 = entity.Attr3;
				model.Attr4 = entity.Attr4;
				model.Attr5 = entity.Attr5;
				model.CreatePerson = entity.CreatePerson;
				model.CreateTime = entity.CreateTime;
				model.ModifyPerson = entity.ModifyPerson;
				model.ModifyTime = entity.ModifyTime;
 
                return model;
            }
            else
            {
                return null;
            }
        }


		 /// <summary>
        /// 校验Excel数据,这个方法一般用于重写校验逻辑
        /// </summary>
        public virtual bool CheckImportData(string fileName, List<WMS_ReturnInspectionModel> list,ref ValidationErrors errors )
        {
          
            var targetFile = new FileInfo(fileName);

            if (!targetFile.Exists)
            {

                errors.Add("导入的数据文件不存在");
                return false;
            }

            var excelFile = new ExcelQueryFactory(fileName);

            //对应列头
			 				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ReturnInspectionNum, "退货送检单号");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PartCustomerCode, "客户图号");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PartCustomerCodeName, "零件名称");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PartID, "新电图号");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Qty, "数量");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.CustomerId, "客户");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.SupplierId, "供应商");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PCS, "箱数");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Volume, "体积");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.InvId, "库房");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.SubInvId, "子库房");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PrintStatus, "打印状态");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PrintDate, "打印日期");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.PrintMan, "打印人");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Remark, "备注");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.InspectMan, "检验人");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.InspectDate, "检验日期");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.InspectStatus, "检验状态");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.CheckOutResult, "检验结果");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.QualifyQty, "合格数量");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.NoQualifyQty, "不合格数量");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Lot, "批次");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ConfirmStatus, "ConfirmStatus");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ConfirmMan, "ConfirmMan");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ConfirmDate, "ConfirmDate");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ConfirmRemark, "ConfirmRemark");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Attr1, "Attr1");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Attr2, "Attr2");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Attr3, "Attr3");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Attr4, "Attr4");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.Attr5, "Attr5");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.CreatePerson, "创建人");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.CreateTime, "创建时间");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ModifyPerson, "修改人");
				 excelFile.AddMapping<WMS_ReturnInspectionModel>(x => x.ModifyTime, "修改时间");
 
            //SheetName
            var excelContent = excelFile.Worksheet<WMS_ReturnInspectionModel>(0);
            int rowIndex = 1;
            //检查数据正确性
            foreach (var row in excelContent)
            {
                var errorMessage = new StringBuilder();
                var entity = new WMS_ReturnInspectionModel();
						 				  entity.Id = row.Id;
				  entity.ReturnInspectionNum = row.ReturnInspectionNum;
				  entity.PartCustomerCode = row.PartCustomerCode;
				  entity.PartCustomerCodeName = row.PartCustomerCodeName;
				  entity.PartID = row.PartID;
				  entity.Qty = row.Qty;
				  entity.CustomerId = row.CustomerId;
				  entity.SupplierId = row.SupplierId;
				  entity.PCS = row.PCS;
				  entity.Volume = row.Volume;
				  entity.InvId = row.InvId;
				  entity.SubInvId = row.SubInvId;
				  entity.PrintStatus = row.PrintStatus;
				  entity.PrintDate = row.PrintDate;
				  entity.PrintMan = row.PrintMan;
				  entity.Remark = row.Remark;
				  entity.InspectMan = row.InspectMan;
				  entity.InspectDate = row.InspectDate;
				  entity.InspectStatus = row.InspectStatus;
				  entity.CheckOutResult = row.CheckOutResult;
				  entity.QualifyQty = row.QualifyQty;
				  entity.NoQualifyQty = row.NoQualifyQty;
				  entity.Lot = row.Lot;
				  entity.ConfirmStatus = row.ConfirmStatus;
				  entity.ConfirmMan = row.ConfirmMan;
				  entity.ConfirmDate = row.ConfirmDate;
				  entity.ConfirmRemark = row.ConfirmRemark;
				  entity.Attr1 = row.Attr1;
				  entity.Attr2 = row.Attr2;
				  entity.Attr3 = row.Attr3;
				  entity.Attr4 = row.Attr4;
				  entity.Attr5 = row.Attr5;
				  entity.CreatePerson = row.CreatePerson;
				  entity.CreateTime = row.CreateTime;
				  entity.ModifyPerson = row.ModifyPerson;
				  entity.ModifyTime = row.ModifyTime;
 
                //=============================================================================
                if (errorMessage.Length > 0)
                {
                    errors.Add(string.Format(
                        "第 {0} 列发现错误：{1}{2}",
                        rowIndex,
                        errorMessage,
                        "<br/>"));
                }
                list.Add(entity);
                rowIndex += 1;
            }
            if (errors.Count > 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public virtual void SaveImportData(IEnumerable<WMS_ReturnInspectionModel> list)
        {
            try
            {
                using (DBContainer db = new DBContainer())
                {
                    foreach (var model in list)
                    {
                        WMS_ReturnInspection entity = new WMS_ReturnInspection();
                       						entity.Id = 0;
						entity.ReturnInspectionNum = model.ReturnInspectionNum;
						entity.PartCustomerCode = model.PartCustomerCode;
						entity.PartCustomerCodeName = model.PartCustomerCodeName;
						entity.PartID = model.PartID;
						entity.Qty = model.Qty;
						entity.CustomerId = model.CustomerId;
						entity.SupplierId = model.SupplierId;
						entity.PCS = model.PCS;
						entity.Volume = model.Volume;
						entity.InvId = model.InvId;
						entity.SubInvId = model.SubInvId;
						entity.PrintStatus = model.PrintStatus;
						entity.PrintDate = model.PrintDate;
						entity.PrintMan = model.PrintMan;
						entity.Remark = model.Remark;
						entity.InspectMan = model.InspectMan;
						entity.InspectDate = model.InspectDate;
						entity.InspectStatus = model.InspectStatus;
						entity.CheckOutResult = model.CheckOutResult;
						entity.QualifyQty = model.QualifyQty;
						entity.NoQualifyQty = model.NoQualifyQty;
						entity.Lot = model.Lot;
						entity.ConfirmStatus = model.ConfirmStatus;
						entity.ConfirmMan = model.ConfirmMan;
						entity.ConfirmDate = model.ConfirmDate;
						entity.ConfirmRemark = model.ConfirmRemark;
						entity.Attr1 = model.Attr1;
						entity.Attr2 = model.Attr2;
						entity.Attr3 = model.Attr3;
						entity.Attr4 = model.Attr4;
						entity.Attr5 = model.Attr5;
						entity.CreatePerson = model.CreatePerson;
						entity.CreateTime = ResultHelper.NowTime;
						entity.ModifyPerson = model.ModifyPerson;
						entity.ModifyTime = model.ModifyTime;
 
                        db.WMS_ReturnInspection.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
		public virtual bool Check(ref ValidationErrors errors, object id,int flag)
        {
			return true;
		}

        public virtual bool IsExists(object id)
        {
            return m_Rep.IsExist(id);
        }
		
		public void Dispose()
        { 
            
        }

	}
}
