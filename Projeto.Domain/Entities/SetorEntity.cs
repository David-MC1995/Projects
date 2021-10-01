using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class SetorEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        #region Associações

        public List<FuncionarioEntity> Funcionarios { get; set; }

        #endregion
    }
}
