
int[] numbers = new int[4];
        
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
        
string[] _fourletterwords =
    {
        "WORD", "DATA", "CODE", "TEXT", "VIEW", "TASK", "FILE"
    };
        
    
List<int> numbers2 = new List<int>();
numbers2.Add(1);
numbers2.Add(2);
numbers2.Add(3);
numbers2.Add(4);
void Run()
{
    Console.WriteLine(string.Join(' ',numbers));
    Console.WriteLine(string.Join('\t',_fourletterwords));
    Console.WriteLine(string.Join(',', numbers2));
    }

Run();

