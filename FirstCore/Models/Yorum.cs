using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class Yorum
    {
        [Key]
        public int id { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Boş geçilemez.")]
        public string Ileti { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Boş geçilemez.")] 
        public string AdSoyad { get; set; }
    }
}
