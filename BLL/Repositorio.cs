using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
            public List<Cliente> ItemLista { get; set; } = new List<Cliente>();

            public void Incluir(Cliente _Item)
            {
                ItemLista.Add(_Item);
            }

            public void Remover(Cliente _Item)
            {
                ItemLista.Remove(_Item);

            }
    }
}
