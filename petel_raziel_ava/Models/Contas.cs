using petel_raziel_ava.Controller;
using petel_raziel_ava.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace petel_raziel_ava.Models
{
    public class Contas
    {
        public List<Informacoes> Amarzenamento = new List<Informacoes>();
        public ICadastro<Usuarios> Amarzenamento_ = new Repository<Usuarios>();
    }
}
