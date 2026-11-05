﻿﻿string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*****************************************");
    Console.WriteLine("*********** Název programu B ************");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************ Oleksii Petysh *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();

    // Načtení první hodnoty 
    Console.Write("Zadejte číslo (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }
    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Zadane cislo {first}");
    Console.WriteLine("=============================");
    Console.WriteLine();
 

    // Zde budeme pokračovat konkrétním algoritmem
    // Uložení původního čísla
    int numberBackup = first;

    // Ošetření záporného čísla
    if (first < 0)
    {
        first = -first;
    }

    // Převod čísla na text
    string textNumber = first.ToString();

    // Příprava proměnných
    int sum = 0;
    int digit;
    int tens = first / 10;

    // Procházení jednotlivých číslic
    for (int i = 0; i < textNumber.Length; i++)
    {
        digit = int.Parse(textNumber[i].ToString());
        sum = sum + digit;
    }

    // Výpis výsledků
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Počet desítek: {tens}");
    Console.WriteLine("====================================");

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine("1 - Pro opakování programu stislněte klávesu 'a'");
    Console.WriteLine("2 - Následně potvrďte klávesou Enter.");
    Console.WriteLine("3 - Jakoukoliv jinou klávesou program ukončíte.");
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}