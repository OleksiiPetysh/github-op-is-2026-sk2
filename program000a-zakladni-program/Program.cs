﻿string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*****************************************");
    Console.WriteLine("************ Název programu *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine("************ Oleksii Petysh *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení první hodnoty 
    Console.Write("Zadejte číslo (celé číslo): ");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Načtení druhé hodnoty řady
    Console.Write("Zadejte další číslo (celé číslo): ");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb)) {
        Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"První číslo: {aaa}; Další číslo: {bbb};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}