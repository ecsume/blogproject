using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Hakkimdas.Any())
                {
                    return;
                }
                context.Hakkimdas.AddRange(
                   new Hakkimda
                   {
                       id=1,
                       hakkimda="Ben Elif",
                      
                   },
                   new Hakkimda
                   {
                       id = 1,
                       hakkimda = "Ben Cem",

                   }, new Hakkimda
                   {
                       id = 1,
                       hakkimda = "Ben Kaka",

                   }
                   );
                context.SaveChanges();
            }
        }

    }
}
