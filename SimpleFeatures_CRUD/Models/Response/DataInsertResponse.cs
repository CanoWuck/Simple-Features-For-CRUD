using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Models.Response
{
    /// <summary>
    /// 新增資料回應資訊
    /// </summary>
    public class DataInsertResponse : ResponseBase
    {
        /// <summary> 新增是否成功 </summary>        
        public bool IsSuccess { get; set; }
        /// <summary> 資料清單 </summary>
        public IEnumerable<DataInfo> datas { get; set; }
    }
}