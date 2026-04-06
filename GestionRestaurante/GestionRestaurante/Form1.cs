using GestionRestaurante.Entities;
using GestionRestaurante.Repository;
using GestionRestaurante.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRestaurante
{
    public partial class Form1 : Form
    {

        sPedido serPe = new sPedido();
        sIngrediente serIng = new sIngrediente();

        public Form1()
        {
            InitializeComponent();

            serIng.Inicializar();

            dgIngredientes.DataSource = rIngrediente.ingredientes;
        }

        public void MostrarNormal()
        {

            dgPedidos.DataSource = null;

            if (serPe.Listar().Where(p => p.Estado != "Listo").ToList().Count != 0)
            {

                dgPedidos.DataSource = serPe.Listar().Where(p => p.Estado != "Listo").ToList();

            }

        }

        public void MostrarEstado()
        {
            dgPedidosTwo.DataSource = null;

            if (serPe.Listar().Where(p => p.Estado != "Listo").ToList().Count != 0)
            {

                dgPedidosTwo.DataSource = serPe.Listar().Where(p => p.Estado != "Listo").ToList();

            }
        }

        private void bRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (pickerFecha.Text == "" || cbPlato.Text == "" || tCantidad.Text == "")
            {

                MessageBox.Show("Completa los campos.");
                return;

            }

            int cantidad = int.Parse(tCantidad.Text);

            if (cantidad <= 0)
            {

                MessageBox.Show("La cantidad no puede ser 0 o menor.");
                return;

            }

            Pedido pe = new Pedido(0, "Pendiente", cbPlato.Text, pickerFecha.Value, cantidad);

            serPe.Registrar(pe);

            MostrarNormal();
            MostrarEstado();
        }

        private void bEliminarPedido_Click(object sender, EventArgs e)
        {

            if(dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona el pedido a eliminar.");
                return;
            }

            int id = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());

            serPe.Eliminar(id);

            MostrarNormal();
            MostrarEstado();
        }

        private void cantidadMenus_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cantidad de menus vendidos: " + serPe.CantVendidos().ToString());

        }

        private void ingConStockBajo_Click(object sender, EventArgs e)
        {

            dgReportes.DataSource = null;
            dgReportes.DataSource = serIng.IngredientesConMenosStock();

        }

        private void MenusMasVendidos_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Los menus mas vendidos: " + String.Join(", ", serPe.MenusMasVendidos()));

        }

        private void totalRecaudado_Click(object sender, EventArgs e)
        {

            if (pickerReporte.Text == "")
            {
                MessageBox.Show("Debes seleccionar la fecha.");
                return;
            }

            MessageBox.Show("Total recaudado: " + serPe.TotalRecaudadoPorFecha(pickerReporte.Value).ToString());

        }

        private void bResgistrarEstado_Click(object sender, EventArgs e)
        {

            if (dgPedidosTwo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona el pedido a cambiar estado.");
                return;
            }

            if (cbEstado.Text == "")
            {

                MessageBox.Show("Completa los campos.");
                return;

            }

            int id = int.Parse(dgPedidosTwo.SelectedRows[0].Cells[0].Value.ToString());

            serPe.AsignarEstado(id);

            MostrarEstado();
            MostrarNormal();
        }
    }
}
