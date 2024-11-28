using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite reč: ");
        string rec = Console.ReadLine();

        char[] obrnuto = rec.ToCharArray();
        Array.Reverse(obrnuto);

        Console.WriteLine("Reč obrnuto: " + new string(obrnuto));
    }
}

