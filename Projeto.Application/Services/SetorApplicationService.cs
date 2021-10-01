using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Funcao;
using Projeto.Application.Models.Funcionario;
using Projeto.Application.Models.Setor;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class SetorApplicationService : ISetorApplicationService
    {
        private readonly ISetorDomainService domainService;
        private readonly IMapper mapper;

        public SetorApplicationService(ISetorDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Inserir(SetorCadastroModel model)
        {
            var setor = mapper.Map<SetorEntity>(model);
            domainService.Inserir(setor);
        }

        public void Atualizar(SetorEdicaoModel model)
        {
            var setor = mapper.Map<SetorEntity>(model);
            domainService.Atualizar(setor);
        }

        public void Excluir(int id)
        {
            var setor = domainService.ObterPorId(id);
            domainService.Excluir(setor);
        }

        public List<SetorConsultaModel> ObterTodos()
        {
            var lista = domainService.ObterTodos();
            return mapper.Map<List<SetorConsultaModel>>(lista);
        }

        public SetorConsultaModel ObterPorId(int id)
        {
            var setor = domainService.ObterPorId(id);
            return mapper.Map<SetorConsultaModel>(setor);
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
