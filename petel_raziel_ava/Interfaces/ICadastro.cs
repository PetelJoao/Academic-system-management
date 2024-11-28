using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace petel_raziel_ava.Interfaces
{
    public interface ICadastro<T>
    {
        public void Adicionar(T item);
        public void Atualizar(T item, int index);
        public bool Deletar(T item);
       
        public int Tamanho_lista();
        public T Get(T item);
        List<T> GetAll();
    }
}
