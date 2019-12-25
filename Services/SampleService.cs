namespace AspectCoreIssue.Services
{
    public interface ISampleService
    {
        [Authorization]
        string Get(string str);
    }

    public class SampleService : ISampleService
    {
        public string Get(string str) => "Hi";
    }
}
