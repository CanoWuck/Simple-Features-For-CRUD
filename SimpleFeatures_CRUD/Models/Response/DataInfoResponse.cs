using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Models.Response
{
    /// <summary>
    /// 資料內容回應資訊
    /// </summary>
    /// <seealso cref="SimpleFeatures_CRUD.Models.ResponseBase" />
    public class DataInfoResponse : ResponseBase
    {
        /// <summary>
        /// 資料內容清單
        /// </summary>
        public IEnumerable<DataInfo> Datas { get; set; }
    }
}