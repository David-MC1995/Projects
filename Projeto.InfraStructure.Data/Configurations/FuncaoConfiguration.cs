using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Configurations
{
    public class FuncaoConfiguration
        : IEntityTypeConfiguration<FuncaoEntity>
    {
        public void Configure(EntityTypeBuilder<FuncaoEntity> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
