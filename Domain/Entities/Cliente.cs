using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("CLIENTE")]
    public class Cliente
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Telefone{ get; set; }
        public string Endereco { get; set; }
        public List<Dependente> Dependentes { get; set; }
    }
}
