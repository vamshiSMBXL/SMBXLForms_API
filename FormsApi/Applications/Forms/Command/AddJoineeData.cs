using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddJoineeData : BaseRequest<bool>
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Dateofbirth { get; set; }
        public string Dateofjoining { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string age { get; set; }
        public string AdhaarCard { get; set; }
        public string? UanPf { get; set; }
        public string? PanCardNo { get; set; }
        public bool PassportFlag { get; set; }
        public string PassportNo { get; set; }
        public string PlaceOfIssue { get; set; }
        public string IssuedOn { get; set; }
        public string ValidUpto { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string ContactNo { get; set; }
        public string? ExistBank { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCcode { get; set; }
        public string Branch { get; set; }
        public string DeclarationDate { get; set; }
        public string DeclarationPlace { get; set; }
        public string DeclarationSignature { get; set; }
    }
    public class UpdateCustomerCommandHandler : IRequestHandlerWrapper<AddJoineeData, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;

        public UpdateCustomerCommandHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }
        public async Task<ServiceResult<bool>> Handle(AddJoineeData request, CancellationToken cancellationToken)
        {
            JoiningForm data = new JoiningForm();
            data.Id = _seqIdGenerator.Id;
            data.Name = request.Name;
            data.FatherName = request.FatherName;
            data.CorrespondenceAddress = request.CorrespondenceAddress;
            data.PermanentAddress = request.CorrespondenceAddress;
            data.MobileNumber = request.MobileNumber;
            data.EmailId = request.EmailId;
            data.Dateofbirth = request.Dateofbirth;
            data.Dateofjoining = request.Dateofjoining;
            data.Designation = request.Designation;
            data.Department = request.Department;
            data.BloodGroup = request.BloodGroup;
            data.MaritalStatus = request.MaritalStatus;
            data.age = request.age;
            data.AdhaarCard = request.AdhaarCard;
            data.UanPf = request.UanPf;
            data.PanCardNo = request.PanCardNo;
            data.PassportFlag = request.PassportFlag;
            data.PassportNo = request.PassportNo;
            data.PlaceOfIssue = request.PlaceOfIssue;
            data.IssuedOn = request.IssuedOn;
            data.ValidUpto = request.ValidUpto;
            data.EmergencyContactName = request.EmergencyContactName;
            data.EmergencyContactRelation = request.EmergencyContactRelation;
            data.ContactNo = request.ContactNo;
            data.ExistBank = request.ExistBank;
            data.AccountNumber = request.AccountNumber;
            data.IFSCcode = request.IFSCcode;
            data.Branch = request.Branch;
            data.DeclarationDate = request.DeclarationDate;
            data.DeclarationPlace = request.DeclarationPlace;
            data.DeclarationSignature = request.DeclarationSignature;

            _context.JoiningForm.Add(data);
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
