using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petel_raziel_ava.Models
{
    public class Informacoes
    {
        public string? Nome_evento { get; set; }
        public string? Descricao { get; set; }
        public string? Data { get; set; }
        public string? Nome_criador { get; set; }
        public List<Guid>? inscritos_em = new();

    }
}
