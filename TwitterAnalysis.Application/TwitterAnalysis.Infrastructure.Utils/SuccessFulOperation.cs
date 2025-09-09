using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TwitterAnalysis.Infrastructure.Utils.Interfaces;

namespace TwitterAnalysis.Infrastructure.Utils
{
    public class SuccessFulOperation : IOperation { }

    public class SuccessFulOperation<T> : SuccessFulOperation, IOperation<T>
    {
        public SuccessFulOperation(T data)
        {
            Data = data;
        }

        [JsonPropertyName("data")]
        public T Data { get; }
    }
}
