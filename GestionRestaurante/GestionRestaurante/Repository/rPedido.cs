using GestionRestaurante.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurante.Repository
{
    public class rPedido
    {

        public static List<Pedido> pedidos = new List<Pedido>();

        public int idPedido = 1;

        public void Registrar(Pedido pedido)
        {
            pedido.Id = idPedido;

            pedidos.Add(pedido);

            idPedido++;

        }

        public void Eliminar(int id)
        {

            Pedido pe = pedidos.Find(p => p.Id == id);

            pedidos.Remove(pe);

        }

        public List<Pedido> Listar()
        {

            return pedidos;

        }

        public int CantVendidos()
        {

            int agm = 0;

            foreach (Pedido pe in pedidos)
            {
                agm += pe.Cantidad;
            }

            return agm;

        }

        public List<String> MenusMasVendidos()
        {

            List<String> listado = new List<string>();

            int cont1 = 0, cont2 = 0, cont3 = 0, cont4= 0;

            foreach (Pedido p in pedidos)
            {

                switch(p.Producto)
                {
                    case "Aji de gallina": cont1+=p.Cantidad; break;
                    case "Ceviche": cont2 += p.Cantidad; break;
                    case "Causa": cont3 += p.Cantidad; break;
                    case "Chaufa": cont4 += p.Cantidad; break;
                }


            }

            if (cont1 >= cont2 && cont1 >= cont3 && cont1 >= cont4) listado.Add("Aji de gallina");
            if (cont2 >= cont1 && cont2 >= cont3 && cont2 >= cont4) listado.Add("Ceviche");
            if (cont3 >= cont2 && cont3 >= cont1 && cont3 >= cont4) listado.Add("Causa");
            if (cont4 >= cont2 && cont4 >= cont3 && cont4 >= cont1) listado.Add("Chaufa");

            return listado;
        }

        public int TotalRecaudadoPorFecha(DateTime fecha)
        {

            int acm = 0;

            List<Pedido> filtrado = pedidos.Where(p => p.Fecha.Day == fecha.Day && p.Fecha.Month == fecha.Month).ToList();

            foreach(Pedido p in filtrado)
            {

                acm = acm + (p.Cantidad * 14);  

            }

            return acm;
        }

        public void AsignarEstado(int id)
        {

            Pedido pedido = pedidos.Find(p => p.Id == id);

            pedido.Estado = "Listo";

            switch(pedido.Producto)
            {
                case "Aji de gallina":
                    string[] ingredientes = { "Pollo", "Papa", "Arroz", "Pan", "Leche", "Aji amarillo", "Queso parmesano" };

                    foreach (string it in ingredientes)
                    {

                        Ingrediente indt = rIngrediente.ingredientes.Find(i => i.Nombre == it);

                        indt.Stock = indt.Stock + (-1 * pedido.Cantidad);

                    }


                    break;

                case "Ceviche":

                    string[] ingredientes2 = { "Pescado blanco", "Limon", "Cebolla roja", "Aji limo", "Sal", "Cilantro" };

                    foreach (string it in ingredientes2)
                    {

                        Ingrediente indt = rIngrediente.ingredientes.Find(i => i.Nombre == it);

                        indt.Stock = indt.Stock + (-1 * pedido.Cantidad);

                    }

                    break;


                case "Causa":

                    string[] ingredientes3 = { "Papa", "Aji amarillo", "Limon", "Sal", "Aceite", "Pollo", "Mayonesa" };

                    foreach (string it in ingredientes3)
                    {

                        Ingrediente indt = rIngrediente.ingredientes.Find(i => i.Nombre == it);

                        indt.Stock = indt.Stock + (-1 * pedido.Cantidad);

                    }

                    break;


                case "Chaufa":

                    string[] ingredientes4 = { "Arroz", "Huevo", "Cebolla china", "Pollo", "Aceite", "Sillao" };

                    foreach (string it in ingredientes4)
                    {

                        Ingrediente indt = rIngrediente.ingredientes.Find(i => i.Nombre == it);

                        indt.Stock = indt.Stock + (-1 * pedido.Cantidad);

                    }

                    break;
            }

        }

    }
}
