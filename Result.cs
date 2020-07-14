namespace Infrastructure
{
    public class Result<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public T Data { get; set; }

        public void AddErr(string msg)
        {
            this.Success = false;
            Message = msg;
        }
        public void AppendErr(string msg)
        {
            Success = false;
            if (string.IsNullOrEmpty(Message))
            {
                Message = msg;
            }
            else
            {
                Message += ";" + msg;
            }
        }
    }
}