using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAppTurismo.model
{
    public class Comentario
    {
        public long Id { get; set; }
        public Usuario Usuario { get; set; }
        public Monumento Monumento { get; set; }
        public string Mensaje { get; set; }
        public double Puntuacion { get; set; }
    }
}
