using Projeto.Application.Models.Funcao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IFuncaoApplicationService : IDisposable
    {
        void Inserir(FuncaoCadastroModel model);
        void Atualizar(FuncaoEdicaoModel model);
        void Excluir(int id);

        List<FuncaoConsultaModel> ObterTodos();
        FuncaoConsultaModel ObterPorId(int id);
    }
}
