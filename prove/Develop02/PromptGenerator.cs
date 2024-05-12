public class PromptGen
{
    private List<string> _prompts;

    public PromptGen()
    {// Prompts---------------
        _prompts = new List<string>
        { "Who was the most interesting person I talked to this today?",
        "What was the best part of your day?",
        "How did I see the hand of the Lord in your life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you do today?",
        "Pick a random scripture. What does it mean to you?",
        "If you're posterity saw this entry, what would you want them to know about you?",
        "What new thing did you learn today?",
        "What was the song that you listened to today?",
        "Who was on your mind the most of the time today?",
        "Tough day? Tell me all about it.",
        "How are you REALLY doing today?",
        "What are you thinking about literally right now?",
        "Why do you still write in your journal?",
        "Whos have you helped today?",
        "If I had one thing I could do over today, what would it be?"
        };
    }
public string GenPrompt()
    {
        Random _rnd = new Random();
        int _rngIndex = _rnd.Next(_prompts.Count);
        return _prompts[_rngIndex];
    }
}