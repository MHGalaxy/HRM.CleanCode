using HRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistence.Configurations.Entities
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();
            builder.Property(e => e.RequestDate).IsRequired();
            builder.Property(e => e.RequestComment).IsRequired();
            builder.Property(e => e.Canceled).HasDefaultValue(false);
            builder.Property(e => e.Aproved).IsRequired(false);

            builder.HasOne(e => e.LeaveType)
                   .WithMany()
                   .HasForeignKey(e => e.LeaveTypeId)
                   .OnDelete(DeleteBehavior.Restrict);// Remove cascade delete for LeaveType
        }
    }
}
