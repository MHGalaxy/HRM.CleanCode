using HRM.Domain.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Domain.DTOs.LeaveType
{
    public class CreateLeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string DefaultDay { get; set; }
    }
}
