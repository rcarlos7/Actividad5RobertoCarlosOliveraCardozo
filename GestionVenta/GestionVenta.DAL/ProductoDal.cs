using GestionVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from producto";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values('" + producto.NombreProducto + "'," +
                                                           "" + producto.PrecioUnitario + ")";
            Conexion.Ejecutar(consulta);
        }

        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                producto.NombreProducto = tabla.Rows[0]["nombreProducto"].ToString();
                producto.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["precioUnitario"].ToString());
            }
            return producto;
        }

        public void EditarProductoDal(Producto producto)
        {
            string consulta = "update producto set nombreProducto ='" + producto.NombreProducto + "'," +
                                                  "precioUnitario =" + producto.PrecioUnitario + "," +
                                    "where idproducto =" + producto.IdProducto;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idProducto =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
