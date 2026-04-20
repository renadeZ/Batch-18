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
    private List<int> numRules = new List<int>();
    private List<string> textRules = new List<string>();


    public void AddRules(int numberInput, string textOutput)
    {
        numRules.Add(numberInput);
        textRules.Add(textOutput);
        SortRules();
    }

    public void DisplayRules()
    {
        Console.WriteLine("Rules:");
        foreach(int rule in numRules)
        {
            Console.WriteLine($"{rule} : {textRules[numRules.IndexOf(rule)]}");
        }
        Console.WriteLine();
    }

    public void RemoveRules(int numberInput)
    {
        int index = numRules.IndexOf(numberInput);
        numRules.RemoveAt(index);
        textRules.RemoveAt(index);
    }

    public void RunRules(int number)
    {
        Console.WriteLine($"N : {number}");
        for(int i = 1; i <= number; i++)
        {
            bool tagged = false;
            foreach(int rule in numRules)
            {
                if(i % rule == 0)
                {
                    Console.Write(textRules[numRules.IndexOf(rule)]);
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

    private void SortRules()
    {
        for(int i = 0; i < numRules.Count()-1; i++)
        {
            int min = i;
            for(int j = i + 1; j < numRules.Count(); j++)
            {
                if(numRules[j] < numRules[min])
                    min = j;
            }
            if(min != i)
            {
                int temp = numRules[i];
                numRules[i] = numRules[min];
                numRules[min] = temp;

                string temp2 = textRules[i];
                textRules[i] = textRules[min];
                textRules[min] = temp2;
            }
        }
    }
        
}
    