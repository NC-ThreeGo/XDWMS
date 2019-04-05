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
	public partial class WMS_Product_EntryBLL: Virtual_WMS_Product_EntryBLL,IWMS_Product_EntryBLL
	{
        

	}
	public class Virtual_WMS_Product_EntryBLL
	{
        [Dependency]
        public IWMS_Product_EntryRepository m_Rep { get; set; }

		public virtual List<WMS_Product_EntryModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<WMS_Product_Entry> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								
								a=>a.ProductBillNum.Contains(queryStr)
								|| a.EntryBillNum.Contains(queryStr)
								|| a.Department.Contains(queryStr)
								
								
								
								
								|| a.Remark.Contains(queryStr)
								|| a.Attr1.Contains(queryStr)
								|| a.Attr2.Contains(queryStr)
								|| a.Attr3.Contains(queryStr)
								|| a.Attr4.Contains(queryStr)
								|| a.Attr5.Contains(queryStr)
								|| a.CreatePerson.Contains(queryStr)
								
								|| a.ModifyPerson.Contains(queryStr)
								
								|| a.Lot.Contains(queryStr)
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

		public virtual List<WMS_Product_EntryModel> GetListByUserId(ref GridPager pager, string userId,string queryStr)
		{
			return new List<WMS_Product_EntryModel>();
		}
		
		public virtual List<WMS_Product_EntryModel> GetListByParentId(ref GridPager pager, string queryStr,object parentId)
        {
			return new List<WMS_Product_EntryModel>();
		}

        public virtual List<WMS_Product_EntryModel> CreateModelList(ref IQueryable<WMS_Product_Entry> queryData)
        {

            List<WMS_Product_EntryModel> modelList = (from r in queryData
                                              select new WMS_Product_EntryModel
                                              {
													Id = r.Id,
													ProductBillNum = r.ProductBillNum,
													EntryBillNum = r.EntryBillNum,
													Department = r.Department,
													Partid = r.Partid,
													ProductQty = r.ProductQty,
													InvId = r.InvId,
													SubInvId = r.SubInvId,
													Remark = r.Remark,
													Attr1 = r.Attr1,
													Attr2 = r.Attr2,
													Attr3 = r.Attr3,
													Attr4 = r.Attr4,
													Attr5 = r.Attr5,
													CreatePerson = r.CreatePerson,
													CreateTime = r.CreateTime,
													ModifyPerson = r.ModifyPerson,
													ModifyTime = r.ModifyTime,
													Lot = r.Lot,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, WMS_Product_EntryModel model)
        {
            try
            {
                WMS_Product_Entry entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new WMS_Product_Entry();
               				entity.Id = model.Id;
				entity.ProductBillNum = model.ProductBillNum;
				entity.EntryBillNum = model.EntryBillNum;
				entity.Department = model.Department;
				entity.Partid = model.Partid;
				entity.ProductQty = model.ProductQty;
				entity.InvId = model.InvId;
				entity.SubInvId = model.SubInvId;
				entity.Remark = model.Remark;
				entity.Attr1 = model.Attr1;
				entity.Attr2 = model.Attr2;
				entity.Attr3 = model.Attr3;
				entity.Attr4 = model.Attr4;
				entity.Attr5 = model.Attr5;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
				entity.Lot = model.Lot;
  

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

		
       

        public virtual bool Edit(ref ValidationErrors errors, WMS_Product_EntryModel model)
        {
            try
            {
                WMS_Product_Entry entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.ProductBillNum = model.ProductBillNum;
				entity.EntryBillNum = model.EntryBillNum;
				entity.Department = model.Department;
				entity.Partid = model.Partid;
				entity.ProductQty = model.ProductQty;
				entity.InvId = model.InvId;
				entity.SubInvId = model.SubInvId;
				entity.Remark = model.Remark;
				entity.Attr1 = model.Attr1;
				entity.Attr2 = model.Attr2;
				entity.Attr3 = model.Attr3;
				entity.Attr4 = model.Attr4;
				entity.Attr5 = model.Attr5;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
				entity.Lot = model.Lot;
 


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

      

        public virtual WMS_Product_EntryModel GetById(object id)
        {
            if (IsExists(id))
            {
                WMS_Product_Entry entity = m_Rep.GetById(id);
                WMS_Product_EntryModel model = new WMS_Product_EntryModel();
                              				model.Id = entity.Id;
				model.ProductBillNum = entity.ProductBillNum;
				model.EntryBillNum = entity.EntryBillNum;
				model.Department = entity.Department;
				model.Partid = entity.Partid;
				model.ProductQty = entity.ProductQty;
				model.InvId = entity.InvId;
				model.SubInvId = entity.SubInvId;
				model.Remark = entity.Remark;
				model.Attr1 = entity.Attr1;
				model.Attr2 = entity.Attr2;
				model.Attr3 = entity.Attr3;
				model.Attr4 = entity.Attr4;
				model.Attr5 = entity.Attr5;
				model.CreatePerson = entity.CreatePerson;
				model.CreateTime = entity.CreateTime;
				model.ModifyPerson = entity.ModifyPerson;
				model.ModifyTime = entity.ModifyTime;
				model.Lot = entity.Lot;
 
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
        public virtual bool CheckImportData(string fileName, List<WMS_Product_EntryModel> list,ref ValidationErrors errors )
        {
          
            var targetFile = new FileInfo(fileName);

            if (!targetFile.Exists)
            {

                errors.Add("导入的数据文件不存在");
                return false;
            }

            var excelFile = new ExcelQueryFactory(fileName);

            //对应列头
			 				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.ProductBillNum, "入库单号（业务）");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.EntryBillNum, "入库单号（系统）");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Department, "本货部门");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Partid, "物料");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.ProductQty, "数量");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.InvId, "库存");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.SubInvId, "子库存");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Remark, "备注");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Attr1, "Attr1");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Attr2, "Attr2");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Attr3, "Attr3");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Attr4, "Attr4");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Attr5, "Attr5");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.CreatePerson, "创建人");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.CreateTime, "创建时间");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.ModifyPerson, "修改人");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.ModifyTime, "修改时间");
				 excelFile.AddMapping<WMS_Product_EntryModel>(x => x.Lot, "Lot");
 
            //SheetName
            var excelContent = excelFile.Worksheet<WMS_Product_EntryModel>(0);
            int rowIndex = 1;
            //检查数据正确性
            foreach (var row in excelContent)
            {
                var errorMessage = new StringBuilder();
                var entity = new WMS_Product_EntryModel();
						 				  entity.Id = row.Id;
				  entity.ProductBillNum = row.ProductBillNum;
				  entity.EntryBillNum = row.EntryBillNum;
				  entity.Department = row.Department;
				  entity.Partid = row.Partid;
				  entity.ProductQty = row.ProductQty;
				  entity.InvId = row.InvId;
				  entity.SubInvId = row.SubInvId;
				  entity.Remark = row.Remark;
				  entity.Attr1 = row.Attr1;
				  entity.Attr2 = row.Attr2;
				  entity.Attr3 = row.Attr3;
				  entity.Attr4 = row.Attr4;
				  entity.Attr5 = row.Attr5;
				  entity.CreatePerson = row.CreatePerson;
				  entity.CreateTime = row.CreateTime;
				  entity.ModifyPerson = row.ModifyPerson;
				  entity.ModifyTime = row.ModifyTime;
				  entity.Lot = row.Lot;
 
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
        public virtual void SaveImportData(IEnumerable<WMS_Product_EntryModel> list)
        {
            try
            {
                using (DBContainer db = new DBContainer())
                {
                    foreach (var model in list)
                    {
                        WMS_Product_Entry entity = new WMS_Product_Entry();
                       						entity.Id = 0;
						entity.ProductBillNum = model.ProductBillNum;
						entity.EntryBillNum = model.EntryBillNum;
						entity.Department = model.Department;
						entity.Partid = model.Partid;
						entity.ProductQty = model.ProductQty;
						entity.InvId = model.InvId;
						entity.SubInvId = model.SubInvId;
						entity.Remark = model.Remark;
						entity.Attr1 = model.Attr1;
						entity.Attr2 = model.Attr2;
						entity.Attr3 = model.Attr3;
						entity.Attr4 = model.Attr4;
						entity.Attr5 = model.Attr5;
						entity.CreatePerson = model.CreatePerson;
						entity.CreateTime = ResultHelper.NowTime;
						entity.ModifyPerson = model.ModifyPerson;
						entity.ModifyTime = model.ModifyTime;
						entity.Lot = model.Lot;
 
                        db.WMS_Product_Entry.Add(entity);
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
