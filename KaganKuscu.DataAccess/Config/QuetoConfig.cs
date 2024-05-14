using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class QuetoConfig : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder.HasData(
                    new Quote { Id = 1, Owner = "Bill Gates", Content = "Başarısızlıktan korkma. Başarısızlık, başarıya giden yoldaki en önemli adımdır." },
                    new Quote { Id = 2, Owner = "Bill Gates", Content = "Bilgisayarlar, bisiklete binmek gibi bir şeydir. Dengeyi bir kez yakaladınız mı, düşmeniz çok zor." },
                    new Quote { Id = 3, Owner = "Bill Gates", Content = "Yazılım, bir insanın zekasını en iyi şekilde yansıtan şeydir." },
                    new Quote { Id = 4, Owner = "Bill Gates", Content = "Gelecek, bugünü nasıl geçirdiğimize bağlıdır." },
                    new Quote { Id = 5, Owner = "Bill Gates", Content = "Dünyayı değiştirmek istiyorsan, önce kendini değiştirmelisin." },
                    new Quote { Id = 6, Owner = "Steve Jobs", Content = "Teknolojinin kalbi insan ruhudur." },
                    new Quote { Id = 7, Owner = "Steve Jobs", Content = "Noktaları birleştirmek ancak geriye baktığınızda mümkündür." },
                    new Quote { Id = 8, Owner = "Steve Jobs", Content = "Zamanınız sınırlı, onu başkasının hayatını yaşayarak harcamayın." },
                    new Quote { Id = 9, Owner = "Steve Jobs", Content = "Harika işler yapmak için tutkulu olmanız gerekir." },
                    new Quote { Id = 10, Owner = "Steve Jobs", Content = "Yaratıcı olmak, başkalarının ne düşündüğünü önemsememektir." },
                    new Quote { Id = 11, Owner = "Mark Zuckerberg", Content = "Hızlı hareket et ve bir şeyler yap. Mükemmellik, eylemin sonucudur." },
                    new Quote { Id = 12, Owner = "Larry Page", Content = "Her zaman daha iyisini yapmanin bir yolu vardir." },
                    new Quote { Id = 13, Owner = "Elon Musk", Content = "Başarısızlık bir seçenek değildir. Pes edene kadar denemeye devam et." },
                    new Quote { Id = 14, Owner = "Tim Cook", Content = "Basitlik, karmaşıklığın en üst noktasıdır." },
                    new Quote { Id = 15, Owner = "Satya Nadella", Content = "Teknolojinin iyilik için bir güç olduğuna inanıyorum." }
            );
        }
    }
}