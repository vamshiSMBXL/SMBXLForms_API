using FormsApi.data;

namespace FormsApi.Models
{
    public class ExitInterviewModel
    {
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
        public string Designation { get; set; }
        public string StartDateWithOrganization { get; set; }
        public string DateOfResignation { get; set; }
        public string SeparationDate { get; set; }
        public string TotalLengthOfService { get; set; }
        public string? FormFillDate { get; set; }
        public string? Signature { get; set; }

        public  List<intervieweeAnswersModel> EmployeeAnswerList { get; set; }
    }
}
