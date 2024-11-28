using petel_raziel_ava.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petel_raziel_ava.Models
{
    public class Usuarios
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public string? Tipo { get; set; }
        
        public Guid UserId { get; set; }
        
        

       
        public List<Informacoes>? Informacoes_usuario { get; set; }
    }
}
