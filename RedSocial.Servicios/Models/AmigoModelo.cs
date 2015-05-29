using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSocial.Servicios.Models
{
    public class AmigoModelo
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

    }
}