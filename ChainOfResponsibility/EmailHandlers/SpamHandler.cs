namespace ChainOfResponsibility.EmailHandlers
{
    // First Concrete Handler
    public class SpamHandler : EmailHandlerBase
    {
        public override void EmailProcessor(Email email)
        {
            if (email.Subject.ToLower().Contains("spam") || 
                email.Body.ToLower().Contains("spam"))
            {
                Console.WriteLine($"Spam Handler: Email with " +
                    $"\"{email.Subject}\" subject and \"{email.Body}\" body marked as SPAM");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.EmailProcessor(email);
            }
        }
    }
}
