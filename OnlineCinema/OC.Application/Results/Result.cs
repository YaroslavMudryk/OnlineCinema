using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Application.Results
{
    public class Result
    {
        public Result(string error) : this(false, error, null)
        {

        }
        public Result(object data) : this(true, null, data)
        {

        }

        public Result(bool isOK, string error, object data)
        {
            if (data == null)
            {
                IsOK = false;
                if (string.IsNullOrEmpty(error))
                    Error = "Resource not found";
                else
                    Error = error;
                Data = null;
            }
        }
        public bool IsOK { get; set; } = true;
        public string Error { get; set; } = null;
        public object Data { get; set; } = 0;
    }
}
