﻿using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.HRM.LeaveAllocation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Queries;

namespace HRM.Application.Features.HRM.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public GetLeaveAllocationListRequestHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<List<LeaveAllocationDTO>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocationList = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
            var mappedLeaveAllocationList = _mapper.Map<List<LeaveAllocationDTO>>(leaveAllocationList);
            return mappedLeaveAllocationList;
        }
    }
}
