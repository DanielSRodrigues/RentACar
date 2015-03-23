using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Rent
    {
        [Key]
        public long IdRent { get; set; }

        public long ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public long CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime DevolutionDate { get; set; }
        public long InitialMiliage { get; set; }
        public long FinalMiliage { get; set; }
    }
}
