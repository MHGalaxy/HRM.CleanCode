using HRM.Application.DTOs.Common;

namespace HRM.Application.DTOs
{
    public class LeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string DefaultDay { get; set; }
    }
}
