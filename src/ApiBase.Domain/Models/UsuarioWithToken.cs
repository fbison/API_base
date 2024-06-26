﻿using ApiBase.Domain.Entities;

namespace ApiBase.Domain.Models
{
    public class UsuarioWithToken
    {
        public Usuario Usuario { get; set; }
        public string Token { get; set; }

        public UsuarioWithToken(Usuario usuario, string token)
        {
            Usuario = usuario;
            Token = token;
        }
    }
}
