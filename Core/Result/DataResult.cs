using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, string message, bool succes) : base(message, succes)
        {
            Data = data;
        }

        public DataResult(T data, bool succes) : base(succes)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
