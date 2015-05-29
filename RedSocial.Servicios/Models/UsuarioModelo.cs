using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSocial.Servicios.Models
{
    public class UsuarioModelo
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Foto { get; set; }

        public string NombreUsuario { get; set; }

       
        public string Contraseña { get; set; }


        public string ConfirmacionContraseña { get; set; }

        public bool BloqueoCuenta { get; set; }

        public string intentosFallidos { get; set; }


        public virtual List<AmigoModelo> Amigos { get; set; }

        //public virtual List<SolicitudAmistad> solicitudes { get; set; }

    }
}