using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarekodBarkodUygulaması.Models
{
    /// <summary>
    /// Eğer database oluşmadıysa oluştursun, oluşturduktan sonra eğer products tablosu boş ise belirttiğimiz ürünleri otomatik olarak veritabanına eklemesini
    /// istiyoruz.
    /// </summary>
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DatabaseContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.products.Any())
            {
                context.products.AddRange(
                    new Product
                    {
                        productBarkod = "5099206051805",
                        productImgUrl = "/img/productImg/5099206051805.jpg",
                        productBarkodImgUrl = "/img/productBarkodImg/5099206051805.gif",
                        karekodImgUrl = "/img/productKarekodImg/5099206051805.gif",
                        productName = "Logitech Bluetooth Adaptör / Ses Alıcısı - Siyah",
                        productAdet = 120
                    },
                    new Product
                    {
                        productBarkod = "8697445992049",
                        productImgUrl = "/img/productImg/8697445992049.jpg",
                        productBarkodImgUrl = "/img/productBarkodImg/8697445992049.gif",
                        karekodImgUrl = "/img/productKarekodImg/8697445992049.gif",
                        productName = "Logitech 60W Rms 2+1 Siyah Hoparlör-Bt Adaptör",
                        productAdet = 15
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
