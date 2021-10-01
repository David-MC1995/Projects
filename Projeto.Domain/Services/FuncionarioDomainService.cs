using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FuncionarioDomainService
        : BaseDomainService<FuncionarioEntity>, IFuncionarioDomainService
    {
        private readonly IFuncionarioRepository repository;

        public FuncionarioDomainService(IFuncionarioRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public override List<FuncionarioEntity> ObterTodos()
        {
            return base.ObterTodos();
        }

        public override FuncionarioEntity ObterPorId(int id)
        {
            return base.ObterPorId(id);
        }
    }
}
