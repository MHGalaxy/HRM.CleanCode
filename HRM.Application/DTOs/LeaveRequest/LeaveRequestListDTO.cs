using HRM.Application.DTOs.Common;
using HRM.Application.DTOs.LeaveType;
using System;

namespace HRM.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDTO : BaseDTO
    {
        public LeaveTypeDTO LeaveType { get; set; }
        public DateTime RequestDate { get; set; }
        public bool? Aproved { get; set; }
    }
}
