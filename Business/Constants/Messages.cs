using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string RentalAdded = "Kiralama başarıyla eklendi.";
        public static string RentalCarMissing = "Kiralanacak araç şuanda başka bir kiralamada.";
        public static string RentalDeleted = "Kiralama başarıyla silindi.";
        public static string RentalUpdated = "Kiralama başarıyla güncellendi";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";
        public static string ColorAdded = "Renk başarıyla eklendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";
        public static string CarNameLengthShort = "Araba ismi 2'den kısa olamaz";
        public static string CarDailyPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarAdded = "Araba başarıyla eklendi";
        public static string CarDeleted = "Araba başarıyla silindi";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";
        public static string BrandDeleted = "Marka başarıyla güncellendi";
        public static string UserExists = "Bu e-posta ile kayıtlı kullanıcı bulunmaktadır.";
        public static string CarImageAdded = "Araba resmi başarıyla eklendi.";
        public static string CarImageDeleted = "Araba resmi başarıyla silindi.";
        public static string CarImageUpdated = "Araba resmi başarıyla güncellendi";
        public static string CarImageLimitExceeded = "Ara resim limiti aşıldı";
        public static string AuthorizationFailed = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre yanlış";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var";
        public static string AccessTokenCreated = "Giriş tokeni üretildi.";
    }
}
