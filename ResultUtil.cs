﻿namespace Infrastructure
{
    public static class ResultUtil
    {

        /// <summary>
        /// Result添加非空数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">数据集</param>
        /// <param name="ExceptionMsg">data为null时，Result的Message</param>
        /// <returns>Result<T></returns>
        public static Result<T> AddNotNullData<T>(T data, string ExceptionMsg = ConstInfo.ERR_NotFound)
        {
            Result<T> result = new Result<T>();
            if (data == null)
            {
                result.AddErr(ExceptionMsg);
            }
            result.Data = data;
            return result;
        }
        public static Result<T> CreateResult<T>(T data)
        {
            return new Result<T>()
            {
                Data = data
            };
        }
        public static Result<T> CreateResult<T>(string msg)
        {
            return new Result<T>
            {
                Data = default,
                Success = false,
                Message = msg
            };
        }
        /// <summary>
        /// 生成Result实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="msg">empty or null时，success为true</param>
        /// <returns></returns>
        public static Result<T> CreateResult<T>(T data, string msg)
        {
            return new Result<T>
            {
                Data = data,
                Success = string.IsNullOrEmpty(msg) ? true : false,
                Message = msg
            };
        }


    }
}
