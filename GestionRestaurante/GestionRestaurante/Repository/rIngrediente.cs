using GestionRestaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Repository
{
    public class rIngrediente
    {

        public static List<Ingrediente> ingredientes = new List<Ingrediente>(); 

        public void Inicializar()
        {
            ingredientes.Add(new Ingrediente("Arroz", 100));
            ingredientes.Add(new Ingrediente("Huevo", 100));
            ingredientes.Add(new Ingrediente("Cebolla china", 100));
            ingredientes.Add(new Ingrediente("Sillao", 100));
            ingredientes.Add(new Ingrediente("Aceite", 100));
            ingredientes.Add(new Ingrediente("Pollo", 100));
            ingredientes.Add(new Ingrediente("Papa", 100));
            ingredientes.Add(new Ingrediente("Aji amarillo", 100));
            ingredientes.Add(new Ingrediente("Limon", 100));
            ingredientes.Add(new Ingrediente("Sal", 100));
            ingredientes.Add(new Ingrediente("Mayonesa", 100));
            ingredientes.Add(new Ingrediente("Pescado blanco", 100));
            ingredientes.Add(new Ingrediente("Cebolla roja", 100));
            ingredientes.Add(new Ingrediente("Aji limo", 100));
            ingredientes.Add(new Ingrediente("Cilantro", 100));
            ingredientes.Add(new Ingrediente("Pan", 100));
            ingredientes.Add(new Ingrediente("Leche", 100));
            ingredientes.Add(new Ingrediente("Queso parmesano", 100));
            ingredientes.Add(new Ingrediente("Nuez moscada", 100));
        }

        public List<Ingrediente> IngredientesConMenosStock()
        {

            List<Ingrediente> listado = new List<Ingrediente>();

            int menos = ingredientes.Min(i => i.Stock);

            foreach(Ingrediente ins in ingredientes)
            {

                if (ins.Stock == menos) listado.Add(ins);

            }

            return listado;

        }

    }
}
