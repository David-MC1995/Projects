using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Funcao;
using Projeto.Application.Models.Funcionario;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class FuncionarioApplicationService : IFuncionarioApplicationService
    {
        private readonly IFuncionarioDomainService domainService;
        private readonly IMapper mapper;

        public FuncionarioApplicationService(IFuncionarioDomainService domainService, IMapper mapper)
        {
            this.domainService = domainService;
            this.mapper = mapper;
        }

        public void Inserir(FuncionarioCadastroModel model)
        {
            var funcionario = mapper.Map<FuncionarioEntity>(model);
            domainService.Inserir(funcionario);
        }

        public void Atualizar(FuncionarioEdicaoModel model)
        {
            var funcionario = mapper.Map<FuncionarioEntity>(model);
            domainService.Atualizar(funcionario);
        }

        public void Excluir(int id)
        {
            var funcionario = domainService.ObterPorId(id);
            domainService.Excluir(funcionario);
        }

        public List<FuncionarioConsultaModel> ObterTodos()
        {
            var lista = domainService.ObterTodos();
            return mapper.Map<List<FuncionarioConsultaModel>>(lista);
        }

        public FuncionarioConsultaModel ObterPorId(int id)
        {
            var funcionario = domainService.ObterPorId(id);
            return mapper.Map<FuncionarioConsultaModel>(funcionario);
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
