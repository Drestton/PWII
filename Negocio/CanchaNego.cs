using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;
using System.Configuration;


namespace Negocio
{
    public class CanchaNego
    {
        CanchaRepo canchaRepo = new CanchaRepo();

        public void GuardarCancha(Cancha cancha)
        {
            canchaRepo.GuardarCancha(cancha);
        }

        public void BorrarCancha(Cancha cancha)
        {
            canchaRepo.BorrarCancha(cancha);
        }

        public DataTable ListarCancha()
        {
            return canchaRepo.ListarCancha();
        }

        

        public void ModificarCancha(Cancha cancha)
        {
            canchaRepo.ModificarCancha(cancha);
        }

        public Cancha BuscarCanchaPorID(int idCancha)
        {
            return canchaRepo.BuscarCanchaPorID(idCancha);
        }
    }
}
