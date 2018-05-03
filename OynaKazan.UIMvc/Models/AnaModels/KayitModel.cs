using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.AnaModels
{
    public class KayitModel
    {

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(30,ErrorMessage ="Maksimum 30 karakter girebilirsiniz.")]
        [MinLength(7,ErrorMessage ="En az 7 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage ="Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [MinLength(7, ErrorMessage = "En az 7 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [MinLength(10, ErrorMessage = "En az 10 karakter girebilirsiniz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Soyad { get; set; }

        public bool Sozlesme { get; set; }

    }
}