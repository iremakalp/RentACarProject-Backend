namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //hem data hem mesaj hemde false dondurebilir
        public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
        {

        }
        // sadece data ve trufalsee dondurebilir
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //datayı default atip mesaj ve false dondurebilir
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        // datayi default atip sadece false dondurebilir
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
