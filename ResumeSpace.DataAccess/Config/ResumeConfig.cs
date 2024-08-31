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
                    FullName = "Kagan Kuscu",
                    BirthDate = new DateTime(1996, 2, 11),
                    Address = "Kocaeli/Izmit",
                    Phone = "(089)-3006776",
                    SecondPhone = "",
                    AppUserId = "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0",
                    ResumeName = "KaganKuscu",
                    About = @"<p>The endless possibilities offered by technology have always excited me. Stepping into the world of software development has given me the chance to turn this excitement into reality. I discovered my interest in backend web development on .NET Core platforms and started to improve myself in these areas. By learning C#, JavaScript, and MS SQL Server, I am working to solidify my foundations.</p>

                    <p>Thanks to my curious and research-oriented nature, I learn new things every day and continue to develop myself. Writing code is not just a profession for me but also a passion and an opportunity for learning. I experience the thrill of growing and acquiring new knowledge with every project.</p>

                    <p>I focus on enhancing my problem-solving skills and strengthening my analytical thinking abilities. I strive to find solutions and seek the best possible answers when faced with complex problems.</p>

                    <p>I have a personality suited to teamwork and place great importance on developing my communication skills. I enjoy working in harmony with my team members to achieve common goals.</p>",
                    Title = ".Net Backend Developer",
                    ImagePath = "kagankuscu/kagankuscu.jpg",
                    ResumePath = "kagankuscu/kagankuscu.pdf",
                    Email = "kuscukagan@gmail.com",
                    Interest = @"<p>I am passionate about cycling. Feeling the wind on my face as I pedal is an invaluable experience that embodies freedom and adventure. Each ride opens the door to new discoveries and allows me to witness the beauty of nature. I find tranquility away from the city’s chaos, exploring serene trails on my bike. Every turn brings a new surprise, and every hill reveals a new view.
                    <br />
                    <br />
                    My bike is not just a mode of transportation; it’s a lifestyle. Cycling provides not only health and vitality but also a sense of responsibility towards the environment. By pedaling, I contribute to making the world a better place.
                    <br />
                    <br />
                    My passion for cycling drives me forward each day. I am constantly seeking new routes to challenge myself and training to cover longer distances. As I push my limits on the bike, I also get to know myself better.
                    <br />
                    <br />
                    Every journey I take on my bike becomes an unforgettable memory. With every pedal stroke, I write a new story. My passion for cycling brings me not only joy and peace but also unforgettable memories and experiences.</p>"
                }
            );
        }
    }
}