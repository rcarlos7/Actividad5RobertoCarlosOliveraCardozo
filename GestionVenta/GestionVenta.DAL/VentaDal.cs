using GestionVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentasDal()
        {
            string consulta = "select * from venta";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public int InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values('" + venta.FechaVenta + "'," +
                                                        "" + venta.TotalVenta + ")";
            Conexion.Ejecutar(consulta);
            string consulta2 = "select max(idventa) from venta";
            int idventa = Conexion.EjecutarEscalar(consulta2);
            return idventa;
        }

        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                venta.FechaVenta = Convert.ToDateTime(tabla.Rows[0]["fechaVenta"]);
                venta.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["totalVenta"].ToString());
            }
            return venta;
        }

        public void EditarVentaDal(Venta venta)
        {
            string consulta = "update venta set fechaVenta ='" + venta.FechaVenta + "'," +
                                               "totalVenta =" + venta.TotalVenta + "," +
                                    "where idVenta =" + venta.IdVenta;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "BEGIN TRANSACTION " +
                              "DELETE FROM DETALLEVENTA " +
                              "WHERE IDVENTA =  " + id +
                              "DELETE FROM VENTA " +
                              "WHERE IDVENTA =  " + id +
                              "COMMIT ";

            Conexion.Ejecutar(consulta);
        }
    }
}
