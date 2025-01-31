using HRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistence.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(e => e.DefaultDay)
                    .IsRequired();


            #region Seed Data

            builder.HasData(
                new LeaveType
                {
                    Id = 1,
                    DefaultDay = 10,
                    Name = "Vacation",
                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDay = 12,
                    Name = "Sick",
                }
            );

            #endregion

        }
    }
}
