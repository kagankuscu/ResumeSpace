using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaganKuscu.DataAccess.Config
{
    public class AppUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "A34A825F-E1A6-427C-8194-0D051C22560F",
                UserId = "D0C23476-68D0-4DA0-AAD4-3ADAE20702C0"
            });
        }
    }
}