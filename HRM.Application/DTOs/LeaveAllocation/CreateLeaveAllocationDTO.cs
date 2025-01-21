﻿using HRM.Application.DTOs.Common;

namespace HRM.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDTO : BaseDTO, ILeaveAllocationDTO
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
