using GestionRestaurante.Entities;
using GestionRestaurante.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Services
{
    public class sIngrediente
    {

        rIngrediente repository = new rIngrediente();

        public void Inicializar()
        {
            repository.Inicializar();
        }

        public List<Ingrediente> IngredientesConMenosStock()
        {

            return repository.IngredientesConMenosStock();

        }

    }
}
