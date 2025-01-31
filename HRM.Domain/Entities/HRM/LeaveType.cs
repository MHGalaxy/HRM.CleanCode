using HRM.Domain.Entities.Common;

namespace HRM.Domain.Entities.HRM
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
