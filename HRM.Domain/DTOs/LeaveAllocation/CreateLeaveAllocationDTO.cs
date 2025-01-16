using HRM.Domain.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Domain.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDTO : BaseDTO
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
