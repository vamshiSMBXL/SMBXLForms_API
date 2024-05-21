using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddProfessionalRefernces : BaseRequest<bool>
    {
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
    }
    public class AddProfessionalReferncesHandler : IRequestHandlerWrapper<AddProfessionalRefernces, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;

        public AddProfessionalReferncesHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }

        public async Task<ServiceResult<bool>> Handle(AddProfessionalRefernces request, CancellationToken cancellationToken)
        {
            ProfessionalRefernces data = new ProfessionalRefernces();
            data.Id = _seqIdGenerator.Id;
            data.Name = request.Name;
            data.Organisation = request.Organisation;
            data.Designation = request.Designation;
            data.ContactNo = request.ContactNo;
            data.EmailId = request.EmailId;

            _context.ProfessionalRefernces.Add(data);
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
