using System;
namespace FormsApi.Applications.Common.Interface
{
    public interface ISeqIdGenerator
    {
        Guid Id { get; }
    }
}
