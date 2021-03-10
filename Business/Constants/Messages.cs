using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string SuccessMessage = "İslem basariyla gerceklestirildi.";
        public static string ErrorMessage = "İslem gerceklestirilemedi.";
        public static string ImageLimitExceded = "Resim ekleme sınırını aştınız.";
        public static string UserRegistered = "Kayıt başarılı.";
        public static string AccessTokenCreated = "Token başarıyla oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfullLogin= "Giriş başarılı.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
