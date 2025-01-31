using HRM.Domain.Entities.HRM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistance.Configurations.Entities.HRM
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.ToTable("LeaveTypes", "HRM");

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
                    DateCreated = DateTime.Now,
                    LastModifiedDate = DateTime.Now,
                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDay = 12,
                    Name = "Sick",
                    DateCreated = DateTime.Now,
                    LastModifiedDate = DateTime.Now,
                }
            );

            #endregion

        }
    }
}
