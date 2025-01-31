using HRM.Application.DTOs.Common;
using System;

namespace HRM.Application.DTOs.HRM.LeaveRequest
{
    public class CreateLeaveRequestDTO : BaseDTO, ILeaveRequestDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
    }
}
