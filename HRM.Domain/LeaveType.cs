using HRM.Domain.Common;

namespace HRM.Domain
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public string DefaultDay { get; set; }
    }
}
