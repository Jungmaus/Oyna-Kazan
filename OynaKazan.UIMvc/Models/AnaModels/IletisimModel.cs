using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.AnaModels
{
    public class IletisimModel
    {
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MinLength(5, ErrorMessage = "Lütfen Adınızı ve Soyadınızı geçerli bir şekilde giriniz.")]
        [StringLength(20, ErrorMessage = "Maksimum 20 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MinLength(10,ErrorMessage ="Lütfen geçerli bir Email adresi giriniz.")]
        [StringLength(50,ErrorMessage ="Maksimum 50 karakter girebilirsiniz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MinLength(3,ErrorMessage ="Lütfen geçerli bir konu giriniz. (En az 3 karakter)")]
        [StringLength(20,ErrorMessage ="Maksimum 20 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MinLength(10,ErrorMessage ="Lütfen geçerli bir mesaj giriniz. (En az 10 karakter)")]
        [StringLength(200,ErrorMessage ="Maksimum 200 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Mesaj { get; set; }
    }
}