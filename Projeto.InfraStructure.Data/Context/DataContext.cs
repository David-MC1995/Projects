using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.InfraStructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new FuncaoConfiguration());
            modelBuilder.ApplyConfiguration(new SetorConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }

        public DbSet<FuncaoEntity> Funcao { get; set; }
        public DbSet<SetorEntity> Setor { get; set; }
        public DbSet<FuncionarioEntity> Funcionario { get; set; }
    }
}
