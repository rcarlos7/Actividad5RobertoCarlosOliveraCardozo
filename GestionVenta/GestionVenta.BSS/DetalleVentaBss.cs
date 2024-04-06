using GestionVenta.DAL;
using GestionVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenta.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetallesVentaBss()
        {
            return dal.ListarDetallesVentaDal();
        }

        public DataTable ListarDetalleXVentaBss(int id)
        {
            return dal.ListarDetalleXVentaDal(id);  
        }

        public void InsertarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.InsertarDetalleVentaDal(detalleVenta);
        }

        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return dal.ObtenerDetalleVentaId(id);
        }

        public void EditarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.EditarDetalleVentaDal(detalleVenta);
        }

        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
    }
}
