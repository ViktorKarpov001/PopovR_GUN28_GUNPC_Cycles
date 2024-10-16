class Cycles
{
    static void Main(string[] args)
    {
        //Task1

        int prev = 0;
        int current = 1;
        int result;
        Console.WriteLine("Fibonacci numbers:" + "\n\n");
        Console.Write(prev);
        for (int i = 0; i <= 10; i++)
        {
            Console.Write("\t" + current);
            result = current;
            current = current + prev;
            prev = result;
        }

        Console.WriteLine("\n\n\n");

        //Task2
        Console.WriteLine("Print all even numbers from 2 to 20:" + "\n\n");
        for (int i = 0; i <= 20; i += 2)
        {
            Console.Write(i + "\t");
        }
        Console.WriteLine("\n\n\n");

        //Task3
        Console.WriteLine("The multiplication table:" + "\n\n");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine("\n\n\n");
        }

        //Task4

        Console.WriteLine("A password entry program that reads user input Console.ReadLine:" + "\n\n");

        int count = 0;
        string password = "12345";
        bool confirmed = false;
        do
        {
            if (password != Console.ReadLine())
            {
                count++;
            }
            else
            {
                confirmed = true;
                break;
            }
        } while (count < 3);
        if (!confirmed)
        {
            Console.WriteLine("Exit");
        }
        else
        {
            Console.WriteLine("The password is correct:");
        }
    }
}
