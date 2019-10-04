using System;
using System.Collections.Generic;
using System.Text;

namespace EventInfo.Business
{
    public interface IAutoMapper
    {
        T2 Map<T1, T2>(T1 input);
        IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> input);
    }
}
