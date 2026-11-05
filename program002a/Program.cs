// Řídicí proměnná pro opakování programu
string again = "a";

// Hlavní smyčka programu: běží znovu, pokud uživatel zadá 'a' nebo 'A'
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Ciferný součet **********");
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Oleksii Petysh **********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení celého čísla od uživatele
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    // 2. Příprava pomocných proměnných pro výpočet
    int numberBackup = number; // Záloha původního čísla pro závěrečný výpis
    int sum = 0;               // Neutrální prvek pro sčítání je 0
    int digit;                 // Proměnná pro uložení právě oddělené cifry

    // 3. Ošetření záporných čísel (znaménko nemá vliv na cifry)
    if (number < 0)
    {
        number = -number;
    }

    // 4. Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na cifry (zprava doleva):");

        // 5. Matematický rozklad čísla pomocí cyklu
        while (number > 0)
        {
            digit = number % 10;            // Modulo 10 získá poslední číslici
            sum = sum + digit;              // Přičtení cifry k celkovému součtu

            Console.WriteLine($"Získána cifra: {digit}");

            number = number / 10;           // Celočíselné dělení 10 odstraní poslední číslici
        }
    }

    // 6. Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // 7. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}