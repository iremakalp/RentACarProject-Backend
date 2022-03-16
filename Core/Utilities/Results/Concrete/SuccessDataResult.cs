using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //hem data hem mesaj hemde true dondurebilir
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
       // sadece data ve true dondurebilir
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //datayı default atip mesaj ve true dondurebilir
        public SuccessDataResult(string message) : base(default, true,message)
        {

        }        
        // datayi default atip sadece true dondurebilir
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
