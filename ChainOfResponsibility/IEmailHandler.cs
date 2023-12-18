namespace ChainOfResponsibility
{
    public sealed class Email
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public interface IEmailHandler
    {
        void EmailProcessor(Email email);
        void SetNextHandler(IEmailHandler emailHandler);
    }


    // Abstract base class for concrete handlers
    public abstract class EmailHandlerBase : IEmailHandler
    {
        protected IEmailHandler _nextHandler;

        public void SetNextHandler(IEmailHandler emailHandler)
        {
            _nextHandler = emailHandler;
        }

        public abstract void EmailProcessor(Email email);
    }

}
