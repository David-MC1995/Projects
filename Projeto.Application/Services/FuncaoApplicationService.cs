using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Funcao;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class FuncaoApplicationService : IFuncaoApplicationService
    {
        private readonly IFuncaoDomainService domainService;
        private readonly IMapper mapper;

        public FuncaoApplicationService(IFuncaoDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Inserir(FuncaoCadastroModel model)
        {
            var funcao = mapper.Map<FuncaoEntity>(model);
            domainService.Inserir(funcao);
        }

        public void Atualizar(FuncaoEdicaoModel model)
        {
            var funcao = mapper.Map<FuncaoEntity>(model);
            domainService.Atualizar(funcao);
        }

        public void Excluir(int id)
        {
            var funcao = domainService.ObterPorId(id);
            domainService.Excluir(funcao);
        }

        public List<FuncaoConsultaModel> ObterTodos()
        {
            var lista = domainService.ObterTodos();
            return mapper.Map<List<FuncaoConsultaModel>>(lista);
        }

        public FuncaoConsultaModel ObterPorId(int id)
        {
            var funcao = domainService.ObterPorId(id);
            return mapper.Map<FuncaoConsultaModel>(funcao);
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
