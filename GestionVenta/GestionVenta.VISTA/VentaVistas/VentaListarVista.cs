using GestionVenta.BSS;
using GestionVenta.VISTA.DetalleVentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVenta.VISTA.VentaVistas
{
    public partial class VentaListarVista : Form
    {
        public VentaListarVista()
        {
            InitializeComponent();
        }

        VentaBss bssventa = new VentaBss();
        private void VentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssventa.ListarVentasBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista insertarDetalle = new DetalleVentaInsertarVista();
            if (insertarDetalle.ShowDialog() == DialogResult.OK)
            {
                VentaListarVista ListarVenta = new VentaListarVista();
                ListarVenta.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaListarVista listarDetalleVenta = new DetalleVentaListarVista(IdVentaSeleccionado);
            listarDetalleVenta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar esta venta con sus detalles ?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bssventa.EliminarVentaBss(IdVentaSeleccionado);
                dataGridView1.DataSource = bssventa.ListarVentasBss();
            }
        }
    }
}
