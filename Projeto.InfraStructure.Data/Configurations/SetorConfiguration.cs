using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.InfraStructure.Data.Configurations
{
    public class SetorConfiguration
        : IEntityTypeConfiguration<SetorEntity>
    {
        public void Configure(EntityTypeBuilder<SetorEntity> builder)
        {
            builder.HasKey(s => s.Id);
        }
    }
}
