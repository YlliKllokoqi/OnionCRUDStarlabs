using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class SportsBetModel
    {
        public string BetName { get; set; }
       
        public string Result { get; set; }

        public double Amount { get; set; }

        public double Odds { get; set; }

        public string Competition { get; set; }
    }
}
