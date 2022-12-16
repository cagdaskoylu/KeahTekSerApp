using System;
using System.Collections.Generic;
using System.Text;

namespace Keah_TekSer_App.Models
{
    public class ResponseBase<T> : ResponseBase
    {
        public T Data { get; set; }
    }

    public class ResponseBase
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
}
