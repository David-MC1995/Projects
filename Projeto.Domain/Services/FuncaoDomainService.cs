using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FuncaoDomainService
        : BaseDomainService<FuncaoEntity>, IFuncaoDomainService
    {
        private readonly IFuncaoRepository repository;

        public FuncaoDomainService(IFuncaoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
