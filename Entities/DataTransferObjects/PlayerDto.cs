using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class PlayerDto
    {
        public int Id { get; set; }
      
        public string PlayerName { get; set; }
        public int PlayerCost { get; set; }
        public int CommandId { get; set; }
      
    }
}
