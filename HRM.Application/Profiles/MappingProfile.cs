using AutoMapper;
using HRM.Application.DTOs;
using HRM.Domain;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType,LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
        }
    }
}
