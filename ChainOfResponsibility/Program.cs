using ChainOfResponsibility.EmailHandlers;
using ChainOfResponsibility;


// Create instances of handlers
var spamHandler = new SpamHandler();
var priorityHandler = new PriorityHandler();
var generalHandler = new FinalHandler();


// Set up the chain of responsibility
spamHandler.SetNextHandler(priorityHandler);
priorityHandler.SetNextHandler(generalHandler);


var urgentEmail = new Email
{
    Subject = "Urgent Email",
    Body = "Please review the Urgent Task"
};

var spamEmail = new Email
{
    Subject = "Spam Email",
    Body = "This is a Spam Email"
};

var email = new Email
{
    Subject = "Tasks",
    Body = "Please review your tasks"
};


// Process the email through the chain
spamHandler.EmailProcessor(urgentEmail);
spamHandler.EmailProcessor(spamEmail);
spamHandler.EmailProcessor(email);


