using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models.Funcionario
{
    public class FuncionarioCadastroModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdFuncao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdSetor { get; set; }
    }
}
