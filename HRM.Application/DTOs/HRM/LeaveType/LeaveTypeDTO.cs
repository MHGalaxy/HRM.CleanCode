using HRM.Application.DTOs.Common;

namespace HRM.Application.DTOs.HRM.LeaveType
{
    public class LeaveTypeDTO : BaseDTO, ILeaveTypeDTO
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
