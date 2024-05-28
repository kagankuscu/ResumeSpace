using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaganKuscu.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData(
                new Education {
                    Id = 1,
                    ResumeId = 1,
                    Name = "İZMİT MESLEKİ VE TEKNİK ANADOLU LİSESİ",
                    StartDate = new DateTime(2012, 9, 17),
                    EndDate = new DateTime(2015, 6, 12),
                    Role = "Elektrik Teknisyeni",
                    Description = "",
                },
                new Education {
                    Id = 2,
                    ResumeId = 1,
                    Name = "KOCAELİ ÜNİVERSİTESİ HEREKE YÜKSEK OKULU",
                    StartDate = new DateTime(2015, 9, 14),
                    EndDate = new DateTime(2017, 6, 10),
                    Role = "Elektrik Teknikeri",
                    Description = "",
                },
                new Education {
                    Id = 3,
                    ResumeId = 1,
                    Name = "SOFYA TEKNİK ÜNİVERSİTESİ",
                    StartDate = new DateTime(2017, 9, 26),
                    EndDate = new DateTime(2021, 6, 24),
                    Role = "Mekatronik Mühendisi",
                    Description = "",
                },
                new Education {
                    Id = 4,
                    ResumeId = 1,
                    Name = "SOFYA TEKNİK ÜNİVERSİTESİ",
                    StartDate = new DateTime(2021, 11, 3),
                    EndDate = new DateTime(2023, 6, 23),
                    Role = "Yüksek Lisans Mekatronik Mühendisi",
                    Description = "",
                },
                new Education {
                    Id = 5,
                    ResumeId = 1,
                    Name = "ACUNMEDYA AKADEMİ",
                    StartDate = new DateTime(2023, 9, 11),
                    EndDate = new DateTime(0001, 1, 1),
                    Role = ".Net Core Backend Developer",
                    Description = "",
                }
            );
        }
    }
}