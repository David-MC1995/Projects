using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        
        public BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Inserir(TEntity entity)
        {
            repository.Insert(entity);
        }

        public virtual void Atualizar(TEntity entity)
        {
            repository.Update(entity);
        }

        public virtual void Excluir(TEntity entity)
        {
            repository.Delete(entity);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return repository.GetAll();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return repository.GetById(id);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
