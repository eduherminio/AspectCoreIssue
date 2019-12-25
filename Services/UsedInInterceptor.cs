namespace AspectCoreIssue.Services
{
    public interface IUsedInInterceptor
    {
        string Get();
    }

    public class UsedInInterceptor : IUsedInInterceptor
    {
        public string Get() => "Bye";
    }
}
