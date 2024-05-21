using FormsApi.Applications.Common.Interface;
using RT.Comb;
namespace FormsApi.Applications.Common
{
    public class SeqIdGenerator : ISeqIdGenerator
    {
        public Guid Id => new RT.Comb.SqlCombProvider(new UnixDateTimeStrategy(), new UtcNoRepeatTimestampProvider().GetTimestamp).Create();
    }
}
