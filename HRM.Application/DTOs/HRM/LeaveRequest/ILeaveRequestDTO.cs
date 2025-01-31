using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Application.DTOs.HRM.LeaveRequest
{
    public interface ILeaveRequestDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
