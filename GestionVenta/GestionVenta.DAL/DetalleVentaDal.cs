using GestionVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetallesVentaDal()
        {
            string consulta = "select * from detalleVenta";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable ListarDetalleXVentaDal(int id)
        {
            string consulta = "SELECT PRODUCTO.NOMBREPRODUCTO, DETALLEVENTA.PRECIOUNITARIO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.TOTALDETALLE " +
                              "FROM DETALLEVENTA INNER JOIN " +
                                        "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN " +
                                        "VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA " +
                              "WHERE VENTA.IDVENTA = " + id;

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                               "" + detalleVenta.IdProducto + "," +
                                                               "" + detalleVenta.Cantidad + "," +
                                                               "" + detalleVenta.PrecioUnitario + "," +
                                                               "" + detalleVenta.TotalDetalle + ")";
            Conexion.Ejecutar(consulta);
        }

        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleVenta.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["precioUnitario"].ToString());
                detalleVenta.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totalDetalle"].ToString());
            }
            return detalleVenta;
        }

        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "update detalleventa set idVenta =" + detalleVenta.IdVenta + "," +
                                                      "idProducto =" + detalleVenta.IdProducto + "," +
                                                      "cantidad =" + detalleVenta.Cantidad + "," +
                                                      "precioUnitario =" + detalleVenta.PrecioUnitario + "," +
                                                      "totalDetalle =" + detalleVenta.TotalDetalle + "," +
                                    "where iddetalleventa =" + detalleVenta.IdDetalleVenta;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
