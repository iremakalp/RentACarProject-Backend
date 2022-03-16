using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        // base Result claasina gondermesini saglar
        // hem mesaj hem false donmesi icin yazilan constructor
        public SuccessResult(string message) : base(true, message)
        {

        }
        // sadece true donmesi icin yazilan constructor
        public SuccessResult() : base(true)
        {
        }
    }
}
