namespace IntroInterface;

public class MultipleChoiceQuestions
{
    private readonly string _question;
    private readonly string[] _answers;
    private readonly int _correctAnswerNo;

    public MultipleChoiceQuestions(string question, int correctAnswerNo, params string[] answers)
    {
        _question = question;
        _correctAnswerNo = correctAnswerNo;
        _answers = answers;
    }

    public bool Run()
    {
        Console.WriteLine(_question);
        Console.WriteLine("Svaralternativer: ");
        for (var i = 0; i < _answers.Length; i++)
        {
            var answerNo = i + 1;
            var answer = _answers[i];
            Console.WriteLine(answerNo + ": " + answer);
        }
    }
}