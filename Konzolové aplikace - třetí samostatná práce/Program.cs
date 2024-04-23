using System;
using System.Collections.Generic;

class Slovnik
{
    static void Main(string[] args)
    {
        // List pro ukládání slov
        List<string> words = new List<string>();
        // Index aktuálního slova v seznamu
        int currentIndex = -1;

        while (true)
        {
            // Získání příkazu od uživatele
            string input = Console.ReadLine().Trim();
            string[] command = input.Split(':');
            string action = command[0].ToLower();

            switch (action)
            {
                case "pridat":
                    // Přidání nového slova do seznamu
                    if (command.Length == 2)
                    {
                        string word = command[1];
                        words.Add(word);
                        // Aktualizace indexu pro nově přidané slovo
                        currentIndex = words.Count - 1;
                        Console.WriteLine($"{word}");
                    }
                    else
                    {
                        Console.WriteLine("Neplatný formát příkazu.");
                    }
                    break;
                case "zpet":
                    // Posun na předchozí slovo v seznamu
                    if (currentIndex > 0)
                    {
                        currentIndex--;
                        Console.WriteLine($"{words[currentIndex]}");
                    }
                    else
                    {
                        Console.WriteLine("Není možné se posunout zpět, zobrazeno první přidané slovo.");
                    }
                    break;
                case "vpred":
                    // Posun na následující slovo v seznamu
                    if (currentIndex < words.Count - 1)
                    {
                        currentIndex++;
                        Console.WriteLine($"{words[currentIndex]}");
                    }
                    else
                    {
                        Console.WriteLine("Není možné se posunout vpřed, zobrazeno poslední přidané slovo.");
                    }
                    break;
                default:
                    // Neplatný příkaz
                    Console.WriteLine("Neznámý příkaz. Podporované příkazy jsou 'Pridat:slovo', 'Zpet' a 'Vpred'.");
                    break;
            }
        }
    }
}
