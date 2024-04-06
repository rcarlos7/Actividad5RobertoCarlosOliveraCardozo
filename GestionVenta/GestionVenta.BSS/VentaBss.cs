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
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentasBss()
        {
            return dal.ListarVentasDal();
        }

        public int InsertarVentaBss(Venta venta)
        {
            return dal.InsertarVentaDal(venta);
        }

        public Venta ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaId(id);
        }

        public void EditarVentaBss(Venta venta)
        {
            dal.EditarVentaDal(venta);
        }

        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }
    }
}
