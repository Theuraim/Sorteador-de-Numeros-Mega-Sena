// Mega Sena generator...
string welcomeMessage = "Welcome to the Mega Sena Number Generator!";


void Main()
{
    ShowWelcomeMessage();

    do
    {
        Console.Write("Safe Numbers or Random Numbers ? (1 / 2): ");
        int sortType = Int32.Parse(Console.ReadLine());

        switch (sortType)
        {
        case 1:
                // código 1
                ShowSafeNumbers();
            break;
        case 2:
                // código 2
                ShowRandomNumbers();
            break;
        }
    } while (Continue());
}

void ShowWelcomeMessage()
{
    Console.WriteLine("\r\n███╗░░░███╗███████╗░██████╗░░█████╗░  ░██████╗███████╗███╗░░██╗░█████╗░" +
                      "\r\n████╗░████║██╔════╝██╔════╝░██╔══██╗  ██╔════╝██╔════╝████╗░██║██╔══██╗" +
                      "\r\n██╔████╔██║█████╗░░██║░░██╗░███████║  ╚█████╗░█████╗░░██╔██╗██║███████║" + 
                      "\r\n██║╚██╔╝██║██╔══╝░░██║░░╚██╗██╔══██║  ░╚═══██╗██╔══╝░░██║╚████║██╔══██║" + 
                      "\r\n██║░╚═╝░██║███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗██║░╚███║██║░░██║" +
                      "\r\n╚═╝░░░░░╚═╝╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝\r\n");
    Console.WriteLine(welcomeMessage);

}

void ShowSafeNumbers()
{
    int[] safeNumbers = { 25, 9, 41, 8, 55, 60, 53,
                        36, 59, 21, 30, 18, 46, 4, 18, 38};

    Random random = new Random();
    int rand;

    Console.Write("How many numbers to be sorted ?: ");

    int MaxNumber = Int32.Parse(Console.ReadLine());

    int[] numbers = new int[MaxNumber];

    Console.Write("The lucky Mega Sena numbers are: ");

    for (int c = 0; c < MaxNumber; c++)
    {
        rand = random.Next(0, safeNumbers.Length);

        while (numbers.Contains(safeNumbers[rand]))
        {
            rand = random.Next(0, safeNumbers.Length);
        }

        numbers[c] = safeNumbers[rand];

        //Console.Write(numbers[c] + " ");
    }

    Array.Sort(numbers);
    //Console.Write("\n\n");
    foreach (int p in numbers) Console.Write(p + " ");
}

void ShowRandomNumbers()
{
    Random random = new Random();
    int rand;

    Console.Write("How many numbers to be sorted ?: ");

    int MaxNumber = Int32.Parse(Console.ReadLine());

    int[] numbers = new int[MaxNumber];

    Console.Write("The lucky Mega Sena numbers are: ");

    for (int c = 0; c < MaxNumber; c++)
    {
        rand = random.Next(1, 61);

        while (numbers.Contains(rand))
        {
            rand = random.Next(1, 61);
        }

        numbers[c] = rand;

        //Console.Write(numbers[c] + " ");
    }

    Array.Sort(numbers);
    //Console.Write("\n\n");
    foreach (int p in numbers) Console.Write(p + " ");
}

bool Continue()
{
    Console.Write("\r\nDo you wanna continue (Y/N) ?: ");

    String confirm = Console.ReadLine();

    if ((confirm == "Y") || (confirm == "y")){
        return true;
    }else if ((confirm == "N") || (confirm == "n"))
    {
        return false;
    }


    Console.Write("\r\nAnswer must be Yes or No");

    return Continue();
}

Main();