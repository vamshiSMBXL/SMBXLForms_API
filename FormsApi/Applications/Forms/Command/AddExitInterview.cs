using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddExitInterview : BaseRequest<bool>
    {
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
        public string Designation { get; set; }
        public string StartDateWithOrganization { get; set; }
        public string DateOfResignation { get; set; }
        public string SeparationDate { get; set; }
        public string TotalLengthOfService { get; set; }
    }
    public class AddExitInterviewcsHandler : IRequestHandlerWrapper<AddExitInterview, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;

        public  AddExitInterviewcsHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }
        public async Task<ServiceResult<bool>> Handle(AddExitInterview request, CancellationToken cancellationToken)
        {
            ExitInterview data = new ExitInterview();
            data.id = _seqIdGenerator.Id;
            data.Name = request.Name;
            data.EmployeeCode = request.EmployeeCode;
            data.Designation = request.Designation;
            data.StartDateWithOrganization = request.StartDateWithOrganization;
            data.DateOfResignation = request.DateOfResignation;
            data.SeparationDate = request.SeparationDate;
            data.TotalLengthOfService = request.TotalLengthOfService;

            _context.ExitInterview.Add(data);
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
