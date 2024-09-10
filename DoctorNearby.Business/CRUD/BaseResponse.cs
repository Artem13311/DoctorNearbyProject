using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorNearby.Business.CRUD
{
    public class BaseResponse<TResponse> where TResponse : class
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public TResponse Data { get; set; }
        public List<TResponse> List { get; set; }
        public BaseResponse(string message, int status)
        {
            Message = message;
            Status = status;
        }
        public BaseResponse(string message, int status, TResponse? data)
        {
            Message = message;
            Status = status;
            Data = data;
        }
     
        public BaseResponse(string message, int status, List<TResponse> list)
        {
            Message = message;
            Status = status;
            List = list;
        }
        public BaseResponse(List<TResponse> list)
        {
            Message = "OK";
            Status = 200;
            List = list;
        }

        public BaseResponse(TResponse data)
        {
            Message = "OK";
            Status = 200;
            Data = data;
        }
    }
}
