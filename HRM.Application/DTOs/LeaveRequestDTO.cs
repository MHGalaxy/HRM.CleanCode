using HRM.Application.DTOs.Common;
using HRM.Domain;
using System;

namespace HRM.Application.DTOs
{
    public class LeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
        public DateTime ActionDate { get; set; }
        public bool? Aproved { get; set; }
        public bool Canceled { get; set; }
    }
}
