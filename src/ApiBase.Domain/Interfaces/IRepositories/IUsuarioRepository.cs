using ApiBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiBase.Domain.Interfaces
{
    public interface IUsuarioRepository: IBaseRepository<Usuario>
    {
        public Usuario RecuperarPeloLogin(string login);
    }
}
