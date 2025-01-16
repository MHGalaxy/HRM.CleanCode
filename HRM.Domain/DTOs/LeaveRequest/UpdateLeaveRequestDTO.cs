﻿using HRM.Domain.DTOs.Common;
using System;

namespace HRM.Domain.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDTO : BaseDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public int RequestComment { get; set; }
        public bool Canceled { get; set; }
    }
}
