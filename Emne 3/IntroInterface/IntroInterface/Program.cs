using IntroInterface;

 var questions = new ???[]
 {
    new SimpleAnswerQuestion("Hva er 2+2?", "4"),
        new MultipleChoiceQuestions("Hva er hovedstaden i Norge?", 3,"Stavern", "Larvik","Oslo"),
 };
 
 var points = 0;
 foreach (var question in questions)
 {
     var isCorrect = question.Run();
     if (isCorrect)
     {
         Console.WriteLine("Riktig!");
         points++;
     }
     else
     {
         Console.WriteLine("Feil! :-(");
     }
 }
 
 Console.WriteLine($"Du fikk {points} poeng.");