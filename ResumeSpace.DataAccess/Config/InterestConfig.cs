using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class InterestConfig : IEntityTypeConfiguration<Interest>
    {
        public void Configure(EntityTypeBuilder<Interest> builder)
        {
            builder.HasData(
                new Interest {
                    Id = 1,
                    ResumeId = 1,
                    Name = "Bisiklet",
                    IconCssClass = "map-icon map-icon-bicycling"
                }
            );
        }
    }
}