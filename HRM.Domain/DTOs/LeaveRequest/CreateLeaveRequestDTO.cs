using HRM.Domain.DTOs.Common;
using HRM.Domain.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Domain.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
    }
}
