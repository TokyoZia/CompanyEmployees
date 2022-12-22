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
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasData
            (
            new Player
            {
                Id = 1,
                PlayerName = "Ajmed arusk",
                PlayerCost = 800,
                CommandId = 1 ,
            },
            new Player
            {
                Id = 2,
                PlayerName = "Orper kdgl",
                PlayerCost = 650,
                CommandId = 2,
            }
            );
        }
    }
}
