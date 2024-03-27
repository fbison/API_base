using System;
using ApiBase.Domain.Consts;
using ApiBase.Domain.Models;

namespace ApiBase.Application.DTOs
{
    public class ObterDadosUsuarioLogado
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public byte? Tipo { get; set; }
        public bool? Ativo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Profissao { get; set; }

    }
}
