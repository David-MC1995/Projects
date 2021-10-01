using Projeto.Application.Models.Setor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface ISetorApplicationService : IDisposable
    {
        void Inserir(SetorCadastroModel model);
        void Atualizar(SetorEdicaoModel model);
        void Excluir(int id);

        List<SetorConsultaModel> ObterTodos();
        SetorConsultaModel ObterPorId(int id);
    }
}
