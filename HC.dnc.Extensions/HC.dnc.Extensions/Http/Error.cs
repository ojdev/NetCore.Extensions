using System;
using System.Collections.Generic;
using System.Text;

namespace DNC.Extensions.Http
{
    /// <summary>
    /// 错误信息
    /// </summary>
    public class Error
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { set; get; }
    }
}
