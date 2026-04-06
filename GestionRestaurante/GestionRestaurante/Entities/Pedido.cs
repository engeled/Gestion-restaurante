using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public String Estado { get; set; }
        public String Producto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        public Pedido(int id, string estado, string producto, DateTime fecha, int cantidad)
        {
            Id = id;
            Estado = estado;
            Producto = producto;
            Fecha = fecha;
            Cantidad = cantidad;
        }
    }
}
