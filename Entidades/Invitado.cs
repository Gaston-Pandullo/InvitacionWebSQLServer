using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invitacion.Entidades
{
    internal class Invitado
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public bool Confirmado { get; set; }
    }
}
