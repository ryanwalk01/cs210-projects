public class PromptGenerator {
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {
        Random random = new Random();
        int prompt = random.Next(0,_prompts.Count);
        return _prompts[prompt];
    }
}