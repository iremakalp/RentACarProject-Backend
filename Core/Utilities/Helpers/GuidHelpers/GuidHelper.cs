using System;

namespace Core.Utilities.Helpers.GuidHelpers
{
    // Guid --> benzersiz deger olusturmak icin kullanilir
    // Amac --> ayni isimde dosyalar olusmasini onlemek
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            // Guid.NewGuid()--> essiz bir deger olusturur 
            return Guid.NewGuid().ToString();
        }
    }
}