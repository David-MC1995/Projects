using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.InfraStructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Repositories
{
    public class SetorRepository
        : BaseRepository<SetorEntity>, ISetorRepository
    {
        private readonly DataContext context;

        public SetorRepository(DataContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
