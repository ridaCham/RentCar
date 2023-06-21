using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result
{
    public class Result : IResult
    {
        public Result(string message, bool succes):this(succes)
        {
            Message= message;
        }
        public Result(bool succes) 
        {
            Success = succes;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
