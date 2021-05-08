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
        public bool IsOK { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }
    }

    public class Result<T>
    {
        public Result(T data)
        {
            if(data == null)
            {
                IsOK = false;
                Error = "Resourse not found";
                return;
            }
            Data = data;
            IsOK = true;
            Error = null;
        }
        public Result(string error)
        {
            IsOK = false;
            Error = error;
        }
        public bool IsOK { get; set; }
        public string Error { get; set; }
        public T Data { get; set; }
    }
}
