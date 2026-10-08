string again = "a";

// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpis řady čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("****** Oleksii Petysh ******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // 1. Vstup počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
    }

    // 2. Vstup koncové hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo znovu: ");
    }

    // 3. Vstup diference s kontrolou na kladnou hodnotu
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo větší než 0. Zadejte znovu: ");
    }

    // 4. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference: {step}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // 5. Výpis řady
    Console.WriteLine("Výpis číselné řady:");
    if (first <= last)
    {
        int current = first;
        while (current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }
    }
    else
    {
        Console.WriteLine("První číslo je větší než poslední — pro vzestupnou řadu nelze vypsat žádné prvky.");
    }

    // 6. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}