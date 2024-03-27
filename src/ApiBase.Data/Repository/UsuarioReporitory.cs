using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces;
using ApiBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiBase.Infra.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        protected new readonly DataDbContext _dataDbContext;

        public UsuarioRepository(DataDbContext dataDbContext) : base(dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        public Usuario RecuperarPeloLogin(string login)
        {
            return _dataDbContext.Set<Usuario>().AsNoTracking().Where(x => x.Login == login).FirstOrDefault();   
        }

    }
}
