LogicExerciseClass tes = new LogicExerciseClass();
tes.AddRules(3, "foo");
tes.AddRules(7, "jazz");
tes.AddRules(9, "huzz");
tes.AddRules(4, "baz");
tes.AddRules(5, "bar");

tes.DisplayRules();
tes.RunRules(20);



public class LogicExerciseClass
{
    //If not sorted, the printout of will not be on order
    private SortedDictionary<int, string> rules = new SortedDictionary<int, string>();

    public void AddRules(int numberInput, string textOutput)
    {
        rules.Add(numberInput, textOutput);
    }

    public void DisplayRules()
    {
        Console.WriteLine("Rules:");
        foreach(var rule in rules)
        {
            Console.WriteLine($"{rule.Key} : {rule.Value}");
        }
        Console.WriteLine();
    }

    public void RemoveRules(int numberInput)
    {
        rules.Remove(numberInput);
    }

    public void RunRules(int number)
    {
        Console.WriteLine($"N : {number}");
        for(int i = 1; i <= number; i++)
        {
            bool tagged = false;

            foreach(var rule in rules)
            {
                if(i % rule.Key == 0)
                {
                    Console.Write(rule.Value);
                    tagged = true;
                }
            }

            if( tagged == false )
            {
                Console.Write(i);
            }

            if(i != number)
            {
                Console.Write(", ");
            }
        }
    }
}
    