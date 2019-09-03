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
    public class TurnoNego
    {
        TurnoRepo turnoRepo = new TurnoRepo();

        public void GuardarTurno(Turnos turno)
        {
            turnoRepo.GuardarTurno(turno);
        }

        public void ModificarTurno(Turnos turno)
        {
            turnoRepo.ModificarTurno(turno);
        }

        public void BorrarTurno(Turnos turno)
        {
            turnoRepo.BorrarTurno(turno);
        }

        public DataTable ListarTurno()
        {
            return turnoRepo.ListarTurno();
        }        

        public Turnos BuscarTurnoPorId(int turnos_Id)
        {
            return turnoRepo.BuscarTurnoPorId(turnos_Id);
        }
    }
}
