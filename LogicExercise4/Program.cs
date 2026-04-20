LogicExerciseClass tes = new LogicExerciseClass();
tes.AddRules(3, "foo");
tes.AddRules(7, "jazz");
tes.AddRules(9, "huzz");
tes.AddRules(4, "baz");
tes.AddRules(5, "bar");
tes.AddRules(6, "qux");

tes.DisplayRules();

tes.RemoveRules(6);
tes.DisplayRules();

tes.RunRules(20);
tes.AllString();
tes.AllInt();



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
        Console.WriteLine("\n");
    }

    public void AllString()
    {
        int i =0;

        Console.WriteLine("All String:");
        foreach(var rule in rules)
        {
            Console.Write(rule.Value);

            if (i < rules.Count-1)
            {
                Console.Write(", ");
            }
            i++;
        }
        Console.WriteLine("\n");
    }
    public void AllInt()
    {
        int i =0;

        Console.WriteLine("All Int:");
        foreach(var rule in rules)
        {
            Console.Write(rule.Key);

            if (i < rules.Count-1)
            {
                Console.Write(", ");
            }
            i++;
        }
        Console.WriteLine("\n");
    }
}
    