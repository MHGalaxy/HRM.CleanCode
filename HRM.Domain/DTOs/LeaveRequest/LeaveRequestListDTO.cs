using HRM.Domain.DTOs.Common;
using HRM.Domain.DTOs.LeaveType;
using System;

namespace HRM.Domain.DTOs.LeaveRequest
{
    public class LeaveRequestListDTO : BaseDTO
    {
        public LeaveTypeDTO LeaveType { get; set; }
        public DateTime RequestDate { get; set; }
        public bool? Aproved { get; set; }
    }
}
