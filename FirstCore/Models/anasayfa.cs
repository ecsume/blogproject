using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        
        [MaxLength(4000, ErrorMessage = "4000 karakterden daha uzun olamaz.")]
        public string anasayfabilgi { get; set; }
    }
}
