using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.Helper
{
    public class Common : ICommon
    {
        public object ResponseAPI(object data)
        {
            ResponseModal response = new ResponseModal();
            response.Status = "OK";
            response.ResponseData = data;
            return response;
        }
    }
}
