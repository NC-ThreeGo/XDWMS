﻿using System.Collections.Generic;
using Apps.Common;
using Apps.Models.WMS;

namespace Apps.IBLL.WMS
{
    public partial interface IWMS_ReturnOrderBLL
    {
         /// <summary>
         /// 导入Excel文件，当发生导入错误时，回写错误信息，并且全部回滚。
         /// </summary>
         /// <param name="oper">操作员ID</param>
         /// <param name="filePath"></param>
         /// <param name="errors"></param>
         /// <returns></returns>
         bool ImportExcelData(string oper, string filePath, ref ValidationErrors errors);
    
         /// <summary>
         /// 对导入进行附加的校验，例如物料编码是否存在等。
         /// </summary>
         /// <param name="model"></param>
         void AdditionalCheckExcelData(ref WMS_ReturnOrderModel model);
    
         /// <summary>
         /// 根据where字符串获取列表数据。
         /// </summary>
         /// <param name="pager"></param>
         /// <param name="whereStr"></param>
         List<WMS_ReturnOrderModel> GetListByWhere(ref GridPager pager, string where);

        /// <summary>
        /// 根据where字符串获取按单据编号分组后的列表数据。
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<WMS_ReturnOrderModel> GetListByWhereAndGroupBy(ref GridPager pager, string where);

        /// <summary>
        /// 根据where字符串获取按SupplierId分组后的列表数据。
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<WMS_ReturnOrderModel> GetListByWhereAndGroupBySupplierId(ref GridPager pager, string where);

        /// <summary>
        /// 批量保存库存退货记录
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="jsonReturnOrder"></param>
        /// <returns></returns>
        bool CreateBatchReturnOrder(ref ValidationErrors errors, string opt, string jsonReturnOrder);

        /// <summary>
        /// 手工创建库存待退货单
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="opt"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        bool CreateReturnOrder(ref ValidationErrors errors, string opt, WMS_ReturnOrderModel model);

        /// <summary>
        /// 打印退货单
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="returnOrderNum"></param>
        /// <returns></returns>
        //string PrintReturnOrder(ref ValidationErrors errors, string opt, string returnOrderNum);

        /// <summary>
        /// 确认指定单号的退货单
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="opt"></param>
        /// <param name="returnOrderNum"></param>
        //bool ConfirmReturnOrder(ref ValidationErrors errors, string opt, string returnOrderNum);

        bool CancelReturnOrder(ref ValidationErrors errors, string opt, int aiId);
    }
}
