using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterAnalysis.Infrastructure.Utils.Interfaces
{
    public interface IOperation
    {
    }

    public interface IOperation<T>: IOperation
    {
    }
}
