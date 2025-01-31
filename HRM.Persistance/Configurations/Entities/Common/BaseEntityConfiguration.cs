using HRM.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistance.Configurations.Entities.Common
{
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(e => e.CreatedBy)
                   .HasMaxLength(100);

            builder.Property(e => e.LastModifiedBy)
                   .HasMaxLength(100);

            //Set DeleteBehavior.Restrict for all foreign keys
            foreach (var foreignKey in builder.Metadata.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
        }
    }
}
