using HRM.Application.DTOs.Common;

namespace HRM.Application.DTOs.LeaveType
{
    public class UpdateLeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
