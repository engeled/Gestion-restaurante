using GestionRestaurante.Entities;
using GestionRestaurante.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Services
{
    public class sPedido
    {

        rPedido repository = new rPedido();

        public void Registrar(Pedido pedido)
        {

            repository.Registrar(pedido);

        }

        public void Eliminar(int id)
        {

            repository.Eliminar(id);

        }

        public List<Pedido> Listar()
        {

            return repository.Listar();

        }

        public int CantVendidos()
        {

            return repository.CantVendidos();

        }

        public List<String> MenusMasVendidos()
        {

            return repository.MenusMasVendidos();

        }

        public int TotalRecaudadoPorFecha(DateTime fecha)
        {

            return repository.TotalRecaudadoPorFecha(fecha);

        }

        public void AsignarEstado(int id)
        {

            repository.AsignarEstado(id);
            
        }

    }
}
