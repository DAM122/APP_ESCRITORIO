using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAppTurismo.model
{
    public class Artista
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Profesion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaMuerte { get; set; }
        public string Procedencia { get; set; }
        public string PaisOrigen { get; set; }
        public string Historia { get; set; }
    }
}
