using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddEducationDetails : BaseRequest<bool>
    { 
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public string CollageOrUniversity { get; set; }
        public string YearOfPassing { get; set; }
        public string Percentage { get; set; }
    }

    public class AddEducationDetailsHandler : IRequestHandlerWrapper<AddEducationDetails, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;
        public AddEducationDetailsHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }

        public async Task<ServiceResult<bool>> Handle(AddEducationDetails request, CancellationToken cancellationToken)
        {
            EducationDetails data = new EducationDetails();
            data.Id = _seqIdGenerator.Id;
            data.Degree = request.Degree;
            data.Specialization = request.Specialization;
            data.CollageOrUniversity = request.CollageOrUniversity;
            data.YearOfPassing = request.YearOfPassing;
            data.Percentage = request.Percentage;

            _context.EducationDetails.Add(data);
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
