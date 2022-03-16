using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result
    {
        // base Result claasina gondermesini saglar
        // hem mesaj hem false donmesi icin yazilan constructor
        public ErrorResult(string message) : base(false, message)
        {

        }
        // sadece true donmesi icin yazilan constructor
        public ErrorResult() : base(false)
        {
        }
    }
}
