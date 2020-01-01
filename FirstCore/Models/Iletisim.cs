using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adres giriniz.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Boş geçilemez.")]

        [MaxLength(250, ErrorMessage = "250 karakterden daha uzun olamaz.")]
        public string Mesaj { get; set; }
    }
}
