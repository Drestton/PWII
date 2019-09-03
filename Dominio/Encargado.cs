using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Encargado
    {
        private string idEncargado;
        private string nombre;
        private string apellido;
        private int edad;
        private string documento;
        private string direccion;
        private string correoElectronico;
        private int telefono;

        public string IdEncargado { get => idEncargado; set => idEncargado = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected string Documento { get => documento; set => documento = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        protected int Telefono { get => telefono; set => telefono = value; }
    }

}
