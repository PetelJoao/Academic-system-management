using petel_raziel_ava.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace petel_raziel_ava.Controller
{
    public class Repository<T> : ICadastro<T> where T : class
    {
        private List<T> Lista = new List<T>();
        public void Adicionar(T item)
        {
            Lista.Add(item);
        }

        public void Atualizar(T item, int index)
        {
            Lista[index] = item;
        }



        public bool Deletar(T item)
        {
            return Lista.Remove(item);
        }

        public T Get(T item)
        {
            var  obj =Lista.IndexOf(item);
            return Lista[obj];
            
        }

        public List<T> GetAll()
        {
            return Lista;
        }
        public int Tamanho_lista()
        {

            return Lista.Count();
        }
    }
}
