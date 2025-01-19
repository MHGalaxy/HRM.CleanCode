using HRM.Application.DTOs.Common;

namespace HRM.Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDTO : BaseDTO
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
