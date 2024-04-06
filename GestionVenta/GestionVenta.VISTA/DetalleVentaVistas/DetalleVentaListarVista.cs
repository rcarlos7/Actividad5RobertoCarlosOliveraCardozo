using GestionVenta.BSS;
using GestionVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVenta.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaListarVista : Form
    {
        int idVentax = 0;
        VentaBss bssventa = new VentaBss();
        Venta venta = new Venta();  
        DetalleVentaBss bssdetalleventa = new DetalleVentaBss();
        public DetalleVentaListarVista(int id)
        {
            idVentax = id;
            InitializeComponent();
        }

        private void DetalleVentaListarVista_Load(object sender, EventArgs e)
        {
            venta = bssventa.ObtenerVentaIdBss(idVentax);
            dateTimePicker1.Value = venta.FechaVenta;
            label4.Text = Convert.ToString(venta.TotalVenta);

            DataTable datos = bssdetalleventa.ListarDetalleXVentaBss(idVentax);
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["NOMBREPRODUCTO"], fila["PRECIOUNITARIO"], fila["CANTIDAD"], fila["TOTALDETALLE"]);
            }
        }
    }
}
