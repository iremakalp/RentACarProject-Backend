using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarUpdated="Araba güncellendi";

        public static string RentalAdded = "Yeni araç kiralama bilgileri eklendi";
        public static string RentalDeleted = "Araç kiralama bilgisi silindi";
        public static string RentalUpdated = "Araç kiralama bilgisi güncellendi";
        public static string RentalListed = "Kiralanan araçlar listelendi";


        public static string CustomerAdded = "Yeni müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi"; 
        public static string CustomerListed = "Müşteriler listelendi";

        public static string BrandAdded = "Yeni marka eklendi";
        public static string BrandUpdated= "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";

        public static string ColorAdded = "Yeni renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";

        public static string FileAdded = "Resim başarıyla yüklendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserAdded = "Kullanıcı kaydedildi";
        public static string AccessTokenCreated = "Access token oluşturuldu";

        public static string AuthorizationDenied = "Access token oluşturuldu";
        public static string ColorExists = "Aynı renk eklenemez";
        public static string BrandNameExists = "Aynı marka eklenemez";
    }
}
