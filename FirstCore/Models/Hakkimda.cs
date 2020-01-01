using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace FirstCore.Models
{
    public class Hakkimda
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage="Boş geçilemez.")]
        [MaxLength(750, ErrorMessage = "750 karakterden daha uzun olamaz.")]
        public string hakkimda { get; set; }

    }
}
