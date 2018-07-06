using SimpleFeatures_CRUD.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleFeatures_CRUD.Controllers
{
    /// <summary>
    /// API CRUD 控制器
    /// </summary>    
    public class DataOperatorController : ApiController
    {
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns>回取得資料清單</returns>
        [HttpGet]
        public DataInfoResponse GetData()
        {
            return new DataInfoResponse();
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <returns>取得是否新增成功</returns>
        [HttpPost]
        public DataInsertResponse AddedData()
        {
            return new DataInsertResponse();
        }

        /// <summary>
        /// 修改資料
        /// </summary>
        /// <returns>修改資料是否成功</returns>
        [HttpPut]
        public DataUpdateResponse UpdatedData()
        {
            return new DataUpdateResponse();
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <returns>刪除資料是否成功</returns>
        [HttpDelete]
        public DataDeletedResponse DeletedData()
        {
            return new DataDeletedResponse();
        }
    }
}
