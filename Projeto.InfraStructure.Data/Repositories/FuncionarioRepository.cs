using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.InfraStructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.InfraStructure.Data.Repositories
{
    public class FuncionarioRepository
        : BaseRepository<FuncionarioEntity>, IFuncionarioRepository
    {
        private readonly DataContext context;

        public FuncionarioRepository(DataContext context)
            : base(context)
        {
            this.context = context;
        }

        public override List<FuncionarioEntity> GetAll()
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .ToList();
        }

        public override FuncionarioEntity GetById(int id)
        {
            return context.Funcionario
                .Include(f => f.Setor)
                .Include(f => f.Funcao)
                .Where(f => f.Id == id)
                .FirstOrDefault();
        }
    }
}
