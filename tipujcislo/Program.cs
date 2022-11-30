bool Play()
{
    Console.WriteLine("Chcete si zahrát?");
    if (Console.ReadLine() != "ano") return false;

    int number = new Random().Next(1, 100);
    Console.WriteLine("(vygenerováno " + number + ")");

    int attempts = 0;

    bool Guess()
    {
        int guess = int.Parse(Console.ReadLine());

        attempts += 1;

        if (guess == number)
        {
            Console.WriteLine("Výhra! (pokusů: " + attempts + ")");
            return false;
        }
        if (guess < number)
        {
            Console.WriteLine("Vygenerované číslo je větší.");
        }
        else
        {
            Console.WriteLine("Vygenerované číslo je menší.");
        }
        return true;
    }

    while (Guess())
    {

    }

    return true;
}

while (Play())
{

}