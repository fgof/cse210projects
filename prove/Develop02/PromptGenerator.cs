class PromptGenerator
{

    List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
        "What was the best part of your day?", 
        "What did you learn during your scripture study?",
        "Who did you miss the most today?",
        "What was your strongest feeling today?",
        "What is the best thing that happened to you today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(prompts.Count);
        return prompts[number];
    }
}