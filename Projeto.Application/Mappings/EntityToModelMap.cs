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
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<FuncaoEntity, FuncaoConsultaModel>();
            CreateMap<SetorEntity, SetorConsultaModel>();
            CreateMap<FuncionarioEntity, FuncionarioConsultaModel>();
        }
    }
}
