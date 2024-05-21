using FormsApi.Applications.Common.Models;
using MediatR;

namespace FormsApi.Applications.Common.Interface
{
    public interface IRequestWrapper<T> : IRequest<ServiceResult<T>>
    {

    }

    public interface IRequestHandlerWrapper<TIn, TOut> : IRequestHandler<TIn, ServiceResult<TOut>> where TIn : IRequestWrapper<TOut>
    {
        // You can add any additional methods or properties here if needed
    }
}
