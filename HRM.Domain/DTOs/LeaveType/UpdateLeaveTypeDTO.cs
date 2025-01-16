using HRM.Domain.DTOs.Common;

namespace HRM.Domain.DTOs.LeaveType
{
    public class UpdateLeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string DefaultDay { get; set; }
    }
}
