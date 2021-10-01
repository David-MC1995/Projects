using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class SetorDomainService
        : BaseDomainService<SetorEntity>, ISetorDomainService
    {
        private readonly ISetorRepository repository;

        public SetorDomainService(ISetorRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
