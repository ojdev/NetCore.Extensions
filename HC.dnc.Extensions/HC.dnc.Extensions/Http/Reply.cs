using System;
using System.Collections.Generic;
using System.Text;

namespace DNC.Extensions.Http
{
    /// <summary>
    /// WebApi返回内容
    /// </summary>
    /// <typeparam name="Tin"></typeparam>
    public class Reply<Tin> where Tin : IBaseDto
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { private set; get; } = true;
        /// <summary>
        /// 返回值
        /// </summary>
        public Tin Result { private set; get; }
        /// <summary>
        /// 成功的返回内容
        /// </summary>
        /// <param name="result"></param>
        public Reply(Tin result)
        {
            Result = result;
        }
    }
    /// <summary>
    /// 错误的返回内容
    /// </summary>
    public class ErrorReply
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { private set; get; } = false;
        /// <summary>
        /// 错误信息
        /// </summary>
        public Error[] Errors { private set; get; }
        /// <summary>
        /// 失败返回的错误信息
        /// </summary>
        /// <param name="errors"></param>
        public ErrorReply(Error[] errors)
        {
            Errors = errors;
        }
    }
}
