using AutoMapper;
using Projeto.Application.Models.Funcao;
using Projeto.Application.Models.Funcionario;
using Projeto.Application.Models.Setor;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<FuncaoCadastroModel, FuncaoEntity>();
            CreateMap<FuncaoEdicaoModel, FuncaoEntity>();

            CreateMap<SetorCadastroModel, SetorEntity>();
            CreateMap<SetorEdicaoModel, SetorEntity>();

            CreateMap<FuncionarioCadastroModel, FuncionarioEntity>();
            CreateMap<FuncionarioEdicaoModel, FuncionarioEntity>();
        }
    }
}
