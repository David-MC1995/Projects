using Projeto.Application.Models.Funcao;
using Projeto.Application.Models.Setor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Models.Funcionario
{
    public class FuncionarioConsultaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public FuncaoConsultaModel Funcao { get; set; }
        public SetorConsultaModel Setor { get; set; }
    }
}
