using SimpleFeatures_CRUD.Enumeration;
using SimpleFeatures_CRUD.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Models
{
    /// <summary>
    /// API 回傳結果基礎型別
    /// </summary>
    public abstract class ResponseBase
    {
        /// <summary>
        /// 取得回傳訊息代碼
        /// </summary>
        public string ResultCode { get; set; }
        /// <summary>
        /// 取得回傳訊息內容
        /// </summary>
        public string ResultMessage { get; set; }


        public ResponseBase():this(ResultCodeEnum.Success)
        {
        }

        public ResponseBase(ResultCodeEnum resultCode)
        {
            this.ResultCode = ((int)resultCode).ToString();
            this.ResultMessage = ResultMessageFormatter.GetMessageContent(resultCode);
        }
    }
}