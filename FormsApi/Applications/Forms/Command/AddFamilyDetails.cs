using FormsApi.Applications.Common;
using FormsApi.Applications.Common.Interface;
using FormsApi.Applications.Common.Models;
using FormsApi.data;
using MediatR.Wrappers;

namespace FormsApi.Applications.Forms.Command
{
    public class AddFamilyDetails : BaseRequest<bool>
    {
        public string Name { get; set; }
        public string RelationShip { get; set; }
        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }
    }
    public class AddFamilyDetailsHandler : IRequestHandlerWrapper<AddFamilyDetails, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly ISeqIdGenerator _seqIdGenerator;
        public AddFamilyDetailsHandler(IApplicationDbContext context, ISeqIdGenerator seqIdGenerator)
        {
            _context = context;
            _seqIdGenerator = seqIdGenerator;
        }

        public async Task<ServiceResult<bool>> Handle(AddFamilyDetails request, CancellationToken cancellationToken)
        {
            FamilyDetails data = new FamilyDetails();
            data.Id = _seqIdGenerator.Id;
            data.Name = request.Name;
            data.RelationShip = request.RelationShip;
            data.DateOfBirth = request.DateOfBirth;
            data.Occupation = request.Occupation;

            _context.FamilyDetails.Add(data);   
            _context.SaveChanges();

            return ServiceResult.Success(true);
        }
    }
}
