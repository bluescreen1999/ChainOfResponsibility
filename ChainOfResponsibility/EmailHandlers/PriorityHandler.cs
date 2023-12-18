namespace ChainOfResponsibility.EmailHandlers
{
    // Second Concrete Handler
    public class PriorityHandler : EmailHandlerBase
    {
        public override void EmailProcessor(Email email)
        {
            if (email.Subject.ToLower().Contains("urgent") ||
                email.Body.ToLower().Contains("urgent"))
            {
                Console.WriteLine($"Priority Handler: Email with \"{email.Subject}\"" +
                    $" subject and \"{email.Body}\" body marked as URGENT.");
            }

            else if (_nextHandler != null)
            {
                _nextHandler.EmailProcessor(email);
            }
        }
    }


}
