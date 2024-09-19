using Decorator;
using Decorator.Decorators;
using Decorator.Interfaces;


try
{

    string userInput = "";
    bool isValidInput = false;
    bool shouldEncrypt = false;


    while (!isValidInput)
    {
        Console.WriteLine("Do you want to encrypt the logs? (yes/no): ");
        userInput = Console.ReadLine()?.Trim().ToLower();

        switch (userInput)
        {
            case "yes":
                shouldEncrypt = true;
                isValidInput = true;
                break;
            case "no":
                shouldEncrypt = false;
                isValidInput = true;
                break;
            default:
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                break;
        }
    }

    ILogger logger = new ConsoleLogger();

    logger = new TimestampDecorator(logger);

    logger = new LevelDecorator(logger, "INFO");

    if (shouldEncrypt)
        logger = new EncryptDecorator(logger);

    logger.Log("Application initialized");


    throw new Exception("Simulated error for file logger usage");

}
catch (Exception ex)
{
    //if Debug mode:The log file is located inside the bin/Debug/net8.0 folder.
    //if Release mode:The log file is located inside the bin/Release/net8.0 folder.
    ILogger fileLogger = new FileLogger("log.txt");
    fileLogger = new TimestampDecorator(fileLogger);
    fileLogger = new LevelDecorator(fileLogger, "ERROR");
    fileLogger.Log(ex.Message);
}





