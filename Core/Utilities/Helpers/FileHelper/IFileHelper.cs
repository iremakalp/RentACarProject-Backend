using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    // IFormFile projede bir dosya yuklemek icin kullanilan yontem
    // HttpRequest ile gonderilen bir dosyayi temsil eder -->Microsoft.AspNetCore.Http;
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}