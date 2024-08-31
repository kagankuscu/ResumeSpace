using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class ResumeConfig : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
                new Resume {
                    Id = 1,
                    FullName = "Kağan Kuşcu",
                    BirthDate = new DateTime(1996, 2, 11),
                    Address = "Kocaeli/Izmit",
                    Phone = "(551)-0973377",
                    SecondPhone = "(089)-3006776",
                    AppUserId = "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                    ResumeName = "KaganKuscu",
                    About = @"<p>Teknolojinin sunduğu sonsuz olasılıklar beni her zaman heyecanlandırmıştır. Yazılım geliştirme dünyasına adım atarak bu heyecanımı gerçeğe dönüştürme şansı yakaladım. .NET Core platformlarında backend web geliştirmeye olan ilgimi keşfettim ve bu alanlarda kendimi geliştirmeye başladım. C#, JavaScript ve MS SQL Server dillerini öğrenerek temellerimi sağlamlaştırmaya çalışıyorum.</p>

                        <p>Meraklı ve araştırmacı ruhum sayesinde her gün yeni bir şeyler öğreniyor ve kendimi geliştirmeye devam ediyorum. Kod yazmak benim için sadece bir meslek değil, aynı zamanda bir tutku ve öğrenme fırsatı. Her projede kendimi geliştirmenin ve yeni bilgiler edinmenin heyecanını yaşıyorum.</p>

                        <p>Problem çözme becerilerimi geliştirmeye ve analitik düşünme yeteneğimi güçlendirmeye odaklanıyorum. Karmaşık problemler karşısında yılmadan çözümler aramak ve en uygun çözümü bulmak için çabalıyorum.</p>

                        <p>Ekip çalışmasına yatkın bir kişiliğe sahibim ve iletişim becerilerimi geliştirmeye önem veriyorum. Ekip arkadaşlarımla uyum içinde çalışarak ortak hedeflere ulaşmanın keyfini yaşıyorum.</p>",
                    Title = ".Net Backend Developer",
                    ImagePath = "img/resume/kagankuscu.jpg",
                    ResumePath = "Files/Resume/kagankuscu.pdf",
                    Email = "kuscukagan@gmail.com",
                    Interest = @"<p>Bisiklet tutkunuyum. Rüzgarı yüzümde hissederek pedallara basmak, özgürlüğün ve maceranın tadını çıkarmak benim için paha biçilemez bir deneyim. Her sürüşte yeni keşiflere yelken açıyor, doğanın güzelliklerine tanık oluyorum. Bisikletimle şehirlerin karmaşasından uzaklaşıp, sakin patikalarda huzur buluyorum. Her viraj yeni bir sürprizi, her tepe yeni bir manzarayı müjdeliyor.
                        <br />
                        <br />
                        Bisikletim sadece bir ulaşım aracı değil, aynı zamanda bir yaşam tarzı. Bisiklet kullanmak bana sadece sağlık ve zindelik değil, aynı zamanda çevreye karşı sorumluluk bilinci de kazandırıyor. Bisikletimle pedal çevirdikçe dünyayı daha güzel bir yer yapmak için katkıda bulunuyorum.
                        <br />
                        <br />
                        Bisiklet tutkum beni her geçen gün daha da ileriye taşıyor. Kendimi geliştirmek için sürekli yeni rotalar arıyor, daha uzun mesafeler kat etmek için antrenman yapıyorum. Bisiklet üzerinde kendimi sınırlarımı zorlarken, aynı zamanda kendimi de daha iyi tanıyorum.
                        <br />
                        <br />
                        Bisikletimle çıktığım her yolculuk unutulmaz bir anıya dönüşüyor. Pedallara her basışımda yeni bir hikaye yazıyorum. Bisiklet tutkum bana sadece keyif ve huzur değil, aynı zamanda unutulmaz anılar ve deneyimler de kazandırıyor.</p>"
                }
            );
        }
    }
}