using HRM.Application.DTOs.HRM.LeaveAllocation;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveAllocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveAllocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<LeaveAllocationsController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveAllocationDTO>>> Get()
        {
            var leaveAllocations = await _mediator.Send(new GetLeaveAllocationListRequest());
            return Ok(leaveAllocations);
        }

        // GET api/<LeaveAllocationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveAllocationDTO>> Get(int id)
        {
            var leaveAllocation = await _mediator.Send(new GetLeaveAllocationDetailRequest() { Id = id });
            return Ok(leaveAllocation);
        }

        // POST api/<LeaveAllocationsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveAllocationDTO input)
        {
            var command = new CreateLeaveAllocationCommand() { CreateLeaveAllocationDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<LeaveAllocationsController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateLeaveAllocationDTO input)
        {
            var command = new UpdateLeaveAllocationCommand() { UpdateLeaveAllocationDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // DELETE api/<LeaveAllocationsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveAllocationCommand() { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
