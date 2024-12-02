namespace ParProgrammering2;

public class BotReplies
{
    private static Random random = new Random();
    public static string getRandomReply(List<string> allReplies)
    {
        int index = random.Next(0, allReplies.Count);
        return allReplies[index];
    }
}