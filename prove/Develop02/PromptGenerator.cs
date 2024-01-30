public class PromptGenerator
{
    public List<string> _prompts;
    public Random _random;
    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts ?? throw new ArgumentNullException(nameof(prompts));
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        return "";
    }

}


    

    
