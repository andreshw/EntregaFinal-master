using RedSocial.Dominio.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSocial.Servicios.Models
{
    public static class FabricaUsuariosModelo
    {
        public static UsuarioModelo CrearUsuarioModelo(Usuario usuario)
        {
            if (usuario == null)
            {
                return null;
            }

            UsuarioModelo usuarioModelo = new UsuarioModelo
            {
                Id = usuario.Id,
                Apellidos = usuario.Apellidos,
                BloqueoCuenta = usuario.BloqueoCuenta,
                ConfirmacionContraseña = usuario.ConfirmacionContraseña,
                Contraseña = usuario.Contraseña,
                Email = usuario.Email,
                Foto = usuario.Foto,
                intentosFallidos = usuario.intentosFallidos,
                Nombre = usuario.Nombre,
                NombreUsuario = usuario.NombreUsuario,
                Amigos = CrearListaAmigosModelo(usuario.Amigos)
            };
            return usuarioModelo;
        }

        public static List<AmigoModelo> CrearListaAmigosModelo(List<Usuario> amigos)
        {
            if (amigos == null || amigos.Count() == 0)
            {
                return null;
            }

            List<AmigoModelo> amigosModelo = new List<AmigoModelo>();

            foreach (var amigo in amigos)
            {
                amigosModelo.Add(new AmigoModelo 
                { 
                    Id = amigo.Id,
                    Email = amigo.Email,
                    Apellidos = amigo.Apellidos,
                    Nombre = amigo.Apellidos
                });
            }

            return amigosModelo;
        }

        public static List<UsuarioModelo> CrearListaUsauriosModelo(List<Usuario> usuarios)
        {
            if(usuarios != null || usuarios.Count() == 0)
            {
                return null;
            }

            List<UsuarioModelo> usuariosModelo = new List<UsuarioModelo>();

            foreach (var usuario in usuarios)
            {
                usuariosModelo.Add(CrearUsuarioModelo(usuario));   
            }

            return usuariosModelo;
        }
    }
}