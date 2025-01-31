using HRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.Persistence.Configurations.Entities
{
    public class LeaveAllocationConfiguration : IEntityTypeConfiguration<LeaveAllocation>
    {
        public void Configure(EntityTypeBuilder<LeaveAllocation> builder)
        {
            builder.ToTable("LeaveAllocations", "HRM");

            builder.Property(e => e.NumberOfDays).IsRequired();
            builder.Property(e => e.Priod).IsRequired();

            builder.HasOne(e => e.LeaveType)
                   .WithMany()
                   .HasForeignKey(e => e.LeaveTypeId)
                   .OnDelete(DeleteBehavior.Restrict);// Remove cascade delete for LeaveType
        }
    }
}
