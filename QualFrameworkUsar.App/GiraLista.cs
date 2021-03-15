using System;
using System.Collections.Generic;
using System.Linq;

namespace QualFrameworkUsar.App
{
    public class GiraLista
    {
        public List<int> Girar(List<int> lista)
        {
            if (!lista.Any())
            {
                throw new ArgumentException("A lista precisa ter ao menos 1 item.");
            }
            var itm0 = lista[0];
            lista.RemoveAt(0);
            var nova = new List<int>();
            nova.AddRange(lista);
            nova.Add(itm0);
            return nova;
        }
    }
}
