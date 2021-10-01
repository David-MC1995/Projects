using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public int IdFuncao { get; set; }
        public int IdSetor { get; set; }

        #region Associações

        public FuncaoEntity Funcao { get; set; }
        public SetorEntity Setor { get; set; }

        #endregion
    }
}
