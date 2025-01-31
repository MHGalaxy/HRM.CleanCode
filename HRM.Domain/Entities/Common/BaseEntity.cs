using System;

namespace HRM.Domain.Entities.Common
{
    public abstract class BaseEntity //abstract is for not to create instance of the class
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
