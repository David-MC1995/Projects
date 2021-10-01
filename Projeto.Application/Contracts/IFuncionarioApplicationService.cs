using Projeto.Application.Models.Funcionario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IFuncionarioApplicationService : IDisposable
    {
        void Inserir(FuncionarioCadastroModel model);
        void Atualizar(FuncionarioEdicaoModel model);
        void Excluir(int id);

        List<FuncionarioConsultaModel> ObterTodos();
        FuncionarioConsultaModel ObterPorId(int id);
    }
}
