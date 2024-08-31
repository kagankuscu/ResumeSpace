using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeSpace.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeSpace.DataAccess.Config
{
    public class QuetoConfig : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder.HasData(
                new Quote { Id = 1, Owner = "Bill Gates", Content = "Don’t be afraid of failure. Failure is a crucial step on the road to success." },
                new Quote { Id = 2, Owner = "Bill Gates", Content = "Computers are like riding a bicycle. Once you get the balance, it’s hard to fall off." },
                new Quote { Id = 3, Owner = "Bill Gates", Content = "Software is the best reflection of a person’s intelligence." },
                new Quote { Id = 4, Owner = "Bill Gates", Content = "The future depends on how we spend today." },
                new Quote { Id = 5, Owner = "Bill Gates", Content = "If you want to change the world, you must first change yourself." },
                new Quote { Id = 6, Owner = "Steve Jobs", Content = "The heart of technology is the human soul." },
                new Quote { Id = 7, Owner = "Steve Jobs", Content = "You can only connect the dots looking backward." },
                new Quote { Id = 8, Owner = "Steve Jobs", Content = "Your time is limited, so don’t waste it living someone else’s life." },
                new Quote { Id = 9, Owner = "Steve Jobs", Content = "To do great work, you need to be passionate." },
                new Quote { Id = 10, Owner = "Steve Jobs", Content = "Being creative means not caring about what others think." },
                new Quote { Id = 11, Owner = "Mark Zuckerberg", Content = "Move fast and make things. Perfection is the result of action." },
                new Quote { Id = 12, Owner = "Larry Page", Content = "There is always a way to do better." },
                new Quote { Id = 13, Owner = "Elon Musk", Content = "Failure is not an option. Keep trying until you succeed." },
                new Quote { Id = 14, Owner = "Tim Cook", Content = "Simplicity is the ultimate sophistication." },
                new Quote { Id = 15, Owner = "Satya Nadella", Content = "I believe technology is a force for good." }
            );
        }
    }
}