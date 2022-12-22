using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comand
    {
        [Column("ComandId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Comand name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string ComandName { get; set; }
        [Required(ErrorMessage = "Comand Cost is a required field.")]
        public int ComandCost { get; set; }
    }
}
