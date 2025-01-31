using HRM.Application.DTOs.Common;
using HRM.Application.DTOs.HRM.LeaveType;

namespace HRM.Application.DTOs.HRM.LeaveAllocation
{
    public class LeaveAllocationDTO : BaseDTO
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
