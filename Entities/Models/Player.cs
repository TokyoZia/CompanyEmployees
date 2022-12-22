using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Player
    {
        [Column("PlayerId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Player name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string PlayerName { get; set; }
        [Required(ErrorMessage = "Player Cost is a required field.")]
        public int PlayerCost { get; set; }

        [ForeignKey(nameof(Comand))]
        public int CommandId { get; set; }
        public Comand Comand { get; set; }
    }
}
