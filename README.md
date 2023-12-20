# Chain of Responsibility Pattern Implementation in C#

![Chain of Responsibility](https://www.dofactory.com/img/diagrams/net/chain.png)

*Image source: [dofactory.com](https://dofactory.com)*

This is a sample implementation of the Chain of Responsibility design pattern in C#. The Chain of Responsibility pattern is a **behavioral design pattern** that passes requests along a chain of handlers. Each handler decides either to process the request or to pass it along to the next handler in the chain.

## Table of Contents

- [Introduction](#introduction)
- [How it Works](#how-it-works)
- [Usage](#usage)
- [Example](#example)
- [License](#license)

## Introduction

The Chain of Responsibility pattern is used to achieve loose coupling in software design. It allows a set of handlers to process a request without the sender needing to know which handler will process it.

In this implementation, we have three concrete handlers: `SpamHandler`, `PriorityHandler`, and `FinalHandler`. Each handler decides whether to process the email or pass it to the next handler in the chain.

## How it Works

1. **Handler Hierarchy**: The `EmailHandlerBase` class serves as the base class for concrete handlers. It contains a reference to the next handler in the chain.

2. **Concrete Handlers**: Three concrete handlers (`SpamHandler`, `PriorityHandler`, and `FinalHandler`) implement the `EmailProcessor` method, where they decide whether to handle the email or pass it to the next handler.

3. **Setting up the Chain**: The chain is set up by calling the `SetNextHandler` method on each handler.

4. **Processing Emails**: Emails are processed by calling the `EmailProcessor` method on the first handler in the chain (`spamHandler`). The email is then passed along the chain until it is processed or the end of the chain is reached.

## Usage

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/your-repository.git
    ```

2. Open the project in your preferred C# development environment.

3. Run the application to see the Chain of Responsibility pattern in action with the provided example emails.

## Example

```csharp
// Create instances of handlers
var spamHandler = new SpamHandler();
var priorityHandler = new PriorityHandler();
var generalHandler = new FinalHandler();

// Set up the chain of responsibility
spamHandler.SetNextHandler(priorityHandler);
priorityHandler.SetNextHandler(generalHandler);

// Create example emails
var urgentEmail = new Email { Subject = "Urgent Email", Body = "Please review the Urgent Task" };
var spamEmail = new Email { Subject = "Spam Email", Body = "This is a Spam Email" };
var email = new Email { Subject = "Tasks", Body = "Please review your tasks" };

// Process the email through the chain
spamHandler.EmailProcessor(urgentEmail);
spamHandler.EmailProcessor(spamEmail);
spamHandler.EmailProcessor(email);
```
