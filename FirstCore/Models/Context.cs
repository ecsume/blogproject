using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Hakkimda> Hakkimdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
    }
}
