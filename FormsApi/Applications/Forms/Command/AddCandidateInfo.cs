using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddCandidateInfo : BaseRequest<bool>
    {
        public string Date { get; set; }
        public string PositionAppliedFor { get; set; }
        public string ReferredBy { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string CompleteAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string MartalStatus { get; set; }
        public string Reasons { get; set; }
        public string NoticePeriod { get; set; }
        public string ExpectedCTC { get; set; }
        public string DeclarationDate { get; set; }
        public string DeclarationSignature { get; set; }
    }
    public class AddCandidateInfoHandler : IRequestHandlerWrapper<AddCandidateInfo, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;

        public AddCandidateInfoHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }

        public async Task<ServiceResult<bool>> Handle(AddCandidateInfo request, CancellationToken cancellationToken)
        {
            CandidateInfo data = new CandidateInfo();
            data.ID = _seqIdGenerator.Id;
            data.Date = request.Date;
            data.PositionAppliedFor = request.PositionAppliedFor;
            data.Name = request.Name;   
            data.DateOfBirth = request.DateOfBirth;
            data.CompleteAddress = request.CompleteAddress;
            data.MobileNumber = request.MobileNumber;
            data.EmailId = request.EmailId;
            data.MartalStatus = request.MartalStatus;
            data.Reasons = request.Reasons;
            data.NoticePeriod = request.NoticePeriod;
            data.ExpectedCTC = request.ExpectedCTC;
            data.DeclarationDate = request.DeclarationDate; 
            data.DeclarationSignature = request.DeclarationSignature;

            _context.CandidateInfo.Add(data);
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
