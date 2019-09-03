using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cancha
    {
        private int idCancha;
        private string[] tipoCancha = { "Paddle", "Tennis", "Mixta" };
        private int numeroCancha;
        private string[] estado = { "Ocupado", "Libre" };
        private string seleCancha;
        private string seleEstado;

        public int IdCancha { get => idCancha; set => idCancha = value; }
        public int NumeroCancha { get => numeroCancha; set => numeroCancha = value; }
        public string[] TipoCancha { get => tipoCancha; set => tipoCancha = value; }
        public string[] Estado { get => estado; set => estado = value; }
        public string SeleCancha { get => seleCancha; set => seleCancha = value; }
        public string SeleEstado { get => seleEstado; set => seleEstado = value; }
    }
}
