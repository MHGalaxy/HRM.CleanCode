using HRM.Application.DTOs.Common;
using HRM.Application.DTOs.LeaveType;
using System;

namespace HRM.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
        public DateTime? ReactionDate { get; set; }
        public bool? Aproved { get; set; }
        public bool Canceled { get; set; }
    }
}
