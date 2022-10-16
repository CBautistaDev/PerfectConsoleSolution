using HelloWorldLibrary.BusiessLogic;

public class App
{
    private IMessages _messages;

    public App(IMessages messages)
    {
        _messages = messages;
    }


    //ultimevateHelloworld.exe -lang-es
    public void Run(string[] args)
    {
        string lang = "en";

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].ToLower().StartsWith("lang="))
            {
                lang = args[i].Substring(5);
                break;
            }
        }
        string message = _messages.Greeting(lang);
        Console.WriteLine(message);
    }
}