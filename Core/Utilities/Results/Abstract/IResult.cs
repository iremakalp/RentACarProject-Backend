using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    // Temel void islemleri icin
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
