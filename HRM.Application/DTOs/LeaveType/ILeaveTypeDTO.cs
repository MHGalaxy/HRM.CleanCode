using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Application.DTOs.LeaveType
{
    public interface ILeaveTypeDTO
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
