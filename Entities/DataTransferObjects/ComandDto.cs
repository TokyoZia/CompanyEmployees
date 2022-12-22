using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ComandDto
    {
       
        public int Id { get; set; }
        public string ComandName { get; set; }
        public int ComandCost { get; set; }
    }
}
