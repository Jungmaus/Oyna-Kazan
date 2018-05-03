using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.UserPanelModels
{
    public class BankaHesabiOlusturModel
    {
        [Required]
        [MaxLength(26,ErrorMessage ="Maksimum 26 hane girebilirsiniz.")]
        [MinLength(26,ErrorMessage ="Lütfen geçerli bir IBAN giriniz.")]
        [DataType(DataType.Text)]
        public string IBAN { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage ="En fazla 20 karakter girebilirsiniz.")]
        [MinLength(3,ErrorMessage ="En az 3 karakter girmelisiniz.")]
        [DataType(DataType.Text)]
        public string BankaAdi { get; set; }


        [Required]
        [MaxLength(50,ErrorMessage ="Maksimum 25 karakter girebilirsiniz.")]
        [MinLength(3,ErrorMessage ="Lütfen geçerli bir isim giriniz.")]
        [DataType(DataType.Text)]
        public string HesapSahibi { get; set; }

    }
}