using SimpleFeatures_CRUD.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFeatures_CRUD.Message
{
    public class ResultMessageFormatter
    {
        public static string GetMessageContent(ResultCodeEnum resultCode)
        {
            switch(resultCode)
            {
                case ResultCodeEnum.Success: return "執行成功";
                default: throw new NotImplementedException(string.Format("尚未定義APIResultCode.{0}的回傳訊息",resultCode.ToString()));
            }
        }
    }
}