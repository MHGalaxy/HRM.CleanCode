using HRM.Domain.Entities.HRM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistance.Configurations.Entities.HRM
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.ToTable("LeaveRequests", "HRM");

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
