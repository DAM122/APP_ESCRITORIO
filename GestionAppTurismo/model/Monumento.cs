using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAppTurismo.model
{
    public class Monumento
    {
        public long Id { get; set; }
        public Localidad Localidad { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estilo { get; set; }
        public string Descripcion { get; set; }
        public bool Visitable { get; set; }
        public bool Parking { get; set; }
        public string Telefono { get; set; }
        public string Imagen { get; set; }
        public double? Valoracion { get; set; }
    }
}
