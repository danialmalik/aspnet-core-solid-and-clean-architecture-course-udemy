using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    // public class GetAllLeaveTypesQuery: IRequest<List<LeaveTypeDto>>
    // {
    // }

    public record GetAllLeaveTypesQuery: IRequest<List<LeaveTypeDto>>;

}
