using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Client
    {
        [Key]
        public long IdClient { get; set; }
        [Required(ErrorMessage="O nome é obrigatório")]
        [MaxLength (150)]
        public string Name { get; set; }
        [Required(ErrorMessage="O Cpf é Obrigatório")]
        [MaxLength(12)]
        public string CPF { get; set; }
        [MaxLength(150)]
        public string Adress { get; set; }
    }
}
