using AspectCore.DynamicProxy;
using AspectCoreIssue.Services;
using System;
using System.Threading.Tasks;

namespace AspectCoreIssue
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AuthorizationAttribute : AbstractInterceptorAttribute
    {
        public async override Task Invoke(AspectContext context, AspectDelegate next)
        {
            var service = (IUsedInInterceptor)context.ServiceProvider.GetService(typeof(IUsedInInterceptor));

            var failsInThisInvocation = service.Get();

            await next(context).ConfigureAwait(false);
        }
    }
}
