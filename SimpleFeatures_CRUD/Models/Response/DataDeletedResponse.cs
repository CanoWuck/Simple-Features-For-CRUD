using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Models.Response
{
    /// <summary>
    /// 刪除資料回應資訊
    /// </summary>
    /// <seealso cref="SimpleFeatures_CRUD.Models.ResponseBase" />
    public class DataDeletedResponse : ResponseBase
    {
        /// <summary> 刪除是否成功 </summary>        
        public bool IsSuccess { get; set; }
        /// <summary> 資料清單 </summary>
        public IEnumerable<DataInfo> datas { get; set; }
    }
}