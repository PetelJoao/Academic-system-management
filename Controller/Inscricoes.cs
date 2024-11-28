using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petel_raziel_ava.Controller
{
    public class Inscricoes<T>
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public List<T> GetAll()
        {
            return list;
        }
    }
}
