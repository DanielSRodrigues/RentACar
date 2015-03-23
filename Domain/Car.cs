using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Car
   {
        [Key]
        public long IdCar { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public long Miliage { get; set; }
        public string Board { get; set; }
    }
}
