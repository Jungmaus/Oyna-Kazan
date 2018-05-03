using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.AnaModels
{
    public class GirisModel
    {

        [Required(ErrorMessage ="Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [StringLength(30, ErrorMessage = "Maksimum 30 karakter girebilirsiniz.")]
        [DataType(DataType.Text)]
        public string Sifre { get; set; }


    }
}