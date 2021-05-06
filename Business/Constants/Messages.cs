using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarNameInvalid = "Araba adı en az 2 karakter olmalı.";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";

        public static string ColorNameInvalid = "Renk adı en az 1 karakter olmalı";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";

        public static string BrandNameInvalid = "Marka adı en az 2 karakter olmalı";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string UserNameInvalid = "Kuulanıcı adı en az 2 karakter olmalı.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CompanyNameInvalid = "Şirket adı en az 1 karakter olmalı";
        public static string CustomerAdded = "Müştei eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string CarNotAvailable = "Araba şu an mevcut değil.";
        public static string RentalSuccessful = "Araba kiralama başarılı!";
        public static string RentalDeleted = "Kiralama iptal edildi";
        public static string RentalsListed = "Kiralanan araçlar listelendi";
        public static string ReturnDateUpdated = "Kiralama tarihi güncellendi";
    }
}
