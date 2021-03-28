using System;
using System.Collections.Generic;
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
        internal static string UserExists = "Bu e-posta ile kayıtlı kullanıcı bulunmaktadır.";
    }
}
