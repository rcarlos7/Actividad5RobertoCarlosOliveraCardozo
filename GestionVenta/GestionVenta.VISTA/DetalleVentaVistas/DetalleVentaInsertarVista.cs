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
    public partial class DetalleVentaInsertarVista : Form
    {
        private List<Producto> productosSeleccionados = new List<Producto>();


        public DetalleVentaInsertarVista()
        {

            InitializeComponent();
        }

        ProductoBss bssproducto = new ProductoBss();
        private void DetalleVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bssproducto.ListarProductosBss();
        }

        private void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto != null)
            {
                decimal totalDetalle = producto.PrecioUnitario * cantidad;
                productosSeleccionados.Add(producto);
                dataGridView1.Rows.Add(
                    producto.NombreProducto,
                    producto.PrecioUnitario,
                    cantidad,
                    totalDetalle
                );
                ActualizarTotalVenta();
            }
        }

        private void ActualizarTotalVenta()
        {
            {
                decimal totalVenta = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    totalVenta += precioUnitario * cantidad;
                }
                textBox1.Text = totalVenta.ToString();
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int cantidad = 1;
            Producto productoSeleccionado = ObtenerProductoSeleccionado();
            AgregarProducto(productoSeleccionado, cantidad);
        }

        private Producto ObtenerProductoSeleccionado()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView2.Rows[index];
                Producto producto = new Producto
                {
                    IdProducto = Convert.ToInt32(selectedRow.Cells["IdProducto"].Value),
                    NombreProducto = Convert.ToString(selectedRow.Cells["NombreProducto"].Value),
                    PrecioUnitario = Convert.ToDecimal(selectedRow.Cells["PrecioUnitario"].Value)
                };
                return producto;
            }
            else
            {
                return null;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Cantidad"].Index)
            {
                DataGridViewCell cantidadCell = dataGridView1.Rows[e.RowIndex].Cells["Cantidad"];
                int cantidad = Convert.ToInt32(cantidadCell.Value);
                if (cantidad < 0)
                {
                    cantidadCell.Value = 0;
                }

                DataGridViewCell precioUnitarioCell = dataGridView1.Rows[e.RowIndex].Cells["PrecioUnitario"];
                decimal precioUnitario = Convert.ToDecimal(precioUnitarioCell.Value);

                decimal totalDetalle = precioUnitario * cantidad;

                DataGridViewCell totalDetalleCell = dataGridView1.Rows[e.RowIndex].Cells["TotalDetalle"];
                totalDetalleCell.Value = totalDetalle;

                ActualizarTotalVenta();
            }
        }

        DetalleVentaBss bssdetalle = new DetalleVentaBss();
        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaBss bssventa = new VentaBss();

            venta.FechaVenta = dateTimePicker1.Value;
            venta.TotalVenta = Convert.ToDecimal(textBox1.Text);

            int id = bssventa.InsertarVentaBss( venta );

            foreach (Producto producto in productosSeleccionados)
            {
                DetalleVenta detalleVenta = new DetalleVenta
                {
                    IdVenta = id,
                    IdProducto = producto.IdProducto,
                    Cantidad = Convert.ToInt32(dataGridView1.Rows[productosSeleccionados.IndexOf(producto)].Cells["Cantidad"].Value),
                    PrecioUnitario = producto.PrecioUnitario,
                    TotalDetalle = producto.PrecioUnitario * Convert.ToDecimal(dataGridView1.Rows[productosSeleccionados.IndexOf(producto)].Cells["Cantidad"].Value)
                };

                bssdetalle.InsertarDetalleVentaBss(detalleVenta);
            }

            MessageBox.Show("Se guardo correctamente la venta ");

        }
    }
}
