namespace ServiceB
{
    public interface ISomeService
    {
    }
    
    public class SomeService : ISomeService
    {
        private readonly ISomeOtherService otherService;

        public SomeService(ISomeOtherService otherService)
        {
            this.otherService = otherService;
        }
    }
}