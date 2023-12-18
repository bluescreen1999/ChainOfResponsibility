namespace ChainOfResponsibility.EmailHandlers
{
    // Third Concrete Handler
    public class FinalHandler : EmailHandlerBase
    {
        public override void EmailProcessor(Email email)
        {
            Console.WriteLine($"Final Handler: Finishing the process for " +
                $"email with \"{email.Subject}\" subject and \"{email.Body}\" body.");
        }
    }

}
