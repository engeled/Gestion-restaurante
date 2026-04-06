using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Entities
{
    public class Ingrediente
    {

        public String Nombre { get; set; }

        public int Stock { get; set; }

        public Ingrediente(string nombre, int stock)
        {
            this.Nombre = nombre;
            Stock = stock;
        }
    }
}
