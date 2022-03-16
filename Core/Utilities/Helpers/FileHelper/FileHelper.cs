using System;
using System.IO;
using Core.Utilities.Helpers.GuidHelpers;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    // IFormFile projede bir dosya yuklemek icin kullanilan yontem
    // HttpRequest ile gonderilen bir dosyayi temsil eder -->Microsoft.AspNetCore.Http;
    // FileStream --> belirtilen kaynak dosyalar uzerinde okuma/yazma/atlama gibi operasyonlari yapmaya yarar
    public class FileHelper : IFileHelper
    {
        public void Delete(string filePath)
        {
            // adreste dosya var mi?
            if (File.Exists(filePath))
            {
                //eger dosya var ise silinir
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            // gelen adreste boyle bir dosya var mi?
            if (File.Exists(filePath))
            {
                // eger dosya var ise silinir
                File.Delete(filePath);
            }
            // eski dosya silindikten sonra yerine yeni dosya gecer
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            //file.Length() byte olarak
            // dosya var mi? yok mu?
            if (file.Length>0) 
            {
                // resmin kaydedilecegi dosya dizini var mi?
                // yoksa olustur
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                //secilen dosyanin uzantisi elde edilir
                string extension = Path.GetExtension(file.FileName);
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension; // dosya adi+uzanti --> resim.jpg

                //Belirtilen yolda bir dosya olusturur veya uzerine yazar
                using (FileStream fileStream=File.Create(root+filePath))
                {
                    file.CopyTo(fileStream);//Kopyalanacak dosyanin kopyalanacagi akisi belirtir.
                    fileStream.Flush();//arabellekten siler
                    return filePath;// dosyanın tam adını geri dondurur
                }
            }
            return null;
        }
    }
}