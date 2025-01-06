namespace IntroInterface;

public class SingleAnswerQuestion: IQuestion
{
    private readonly string _question;
    private readonly string _correctanswer;

    public SingleAnswerQuestion(string question, string correctanswer)
    {
        _correctanswer = correctanswer;
        _question = question;
    }

    public bool Run()
    {
        Console.Write(_question + " ");
        var answer = Console.ReadLine();
        return answer == _correctanswer;
    }
}