using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SportsBet : BaseEntity
    {
        [Required]
        public string BetName { get; set; }
        [Required]
        public string Result { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public double Odds { get; set; }
        [Required]
        public string Competition { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
