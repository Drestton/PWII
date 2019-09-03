using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        private int turnos_Id;
        private int idCliente;
        
        private int idCancha;
        private DateTime fecha;
        private string FranjaHoraria;        
        private string estado;

        public int Turnos_Id { get => turnos_Id; set => turnos_Id = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCancha { get => idCancha; set => idCancha = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string FranjaHoraria1 { get => FranjaHoraria; set => FranjaHoraria = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
