using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Application.Contracts;
using Projeto.Application.Services;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.InfraStructure.Data.Context;
using Projeto.InfraStructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation
{
    public class DependencyResolver
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFuncaoApplicationService, FuncaoApplicationService>();
            services.AddTransient<ISetorApplicationService, SetorApplicationService>();
            services.AddTransient<IFuncionarioApplicationService, FuncionarioApplicationService>();

            services.AddTransient<IFuncaoDomainService, FuncaoDomainService>();
            services.AddTransient<ISetorDomainService, SetorDomainService>();
            services.AddTransient<IFuncionarioDomainService, FuncionarioDomainService>();

            services.AddTransient<IFuncaoRepository, FuncaoRepository>();
            services.AddTransient<ISetorRepository, SetorRepository>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();

            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("ProjetoDDD")));
        }
    }
}
