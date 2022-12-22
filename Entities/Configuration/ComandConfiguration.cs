using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class ComandConfiguration : IEntityTypeConfiguration<Comand>
    {
        public void Configure(EntityTypeBuilder<Comand> builder)
        {
            builder.HasData
            (
            new Comand
            {
                Id = 1,
                ComandName = "Liqiud",
                ComandCost = 3500
            },
            new Comand
            {
                Id = 2,
                ComandName = "Ryazan",
                ComandCost = 4500
            }
            );
        }
    }
}
