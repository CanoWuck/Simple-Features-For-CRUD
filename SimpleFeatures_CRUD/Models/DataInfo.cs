using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Models
{
    /// <summary>
    /// 資料容器
    /// </summary>
    public class DataInfo
    {
        /// <summary> 資料編號 </summary>
        public long DataID { get; set; }

        /// <summary> 標題 </summary>
        public string Title { get; set; }

        /// <summary> 內容 </summary>
        public string Content { get; set; }

    }
}