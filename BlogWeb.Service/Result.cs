using System;
using System.Collections.Generic;
using System.Text;

namespace BlogWeb.Service
{
    public class Result<T> where T : class
    {
        public Result(bool _is_success = true, string _message = "", T _data = null, List<T> _datas = null)
        {
            isSuccess = _is_success;
            errorMessage = _message;
            data = _data;
            datas = _datas;
        }
        public bool isSuccess { get; set; }
        public string errorMessage { get; set; }
        public T data { get; set; }
        public List<T> datas { get; set; }   
    }
}
