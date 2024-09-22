using DataAcsessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Data.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(1,1);
            builder.Property(d => d.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(d => d.Code).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(d => d.CreatedAt).HasDefaultValueSql("GETDATE()");

        }
    }
}
