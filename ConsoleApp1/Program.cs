// 1.


// int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
// int suma = 0;
// int wieksza = 0;

// for (int i = 1; i < zlotoWTurach.Length+1; i++)
// {

//     Console.WriteLine($"Tura {i}: {zlotoWTurach[i-1]} sztuk złota");
//     suma+= zlotoWTurach[i-1];

//     if (zlotoWTurach[i-1]>10)
//     {
//        wieksza+=1;
//     }


// }


// Console.WriteLine($"Łącznie: {suma}");
// double srednia = (double) suma/zlotoWTurach.Length;
// Console.WriteLine($"Średnio na turę: {srednia}");
// Console.WriteLine($"Tury z wynikiem co najmniej 10: {wieksza}");
// Console.WriteLine("Od końca:");
// foreach (var wynik in zlotoWTurach.Reverse())
// {
//     Console.WriteLine(wynik);
// }

// 2.


// List<string> plecak = new List<string>
// {
//     "Miecz",
//     "Mikstura",
//     "Pochodnia"
// };

// int przedmioty = 0;
// foreach  (string _ in plecak)
// {
//     przedmioty++;
// }

// Console.WriteLine($"Plecak {plecak.Count}/6:"); 

// int liczba = 1;
// foreach (string przedmiot in plecak)
// {
//     Console.WriteLine($"{liczba}. {przedmiot}");
//     liczba++;
// }
// Console.WriteLine();

// Console.WriteLine("Jaki przedmiot znalazłeś?: ");
// string nprzedmiot = Console.ReadLine();
// plecak.Add(nprzedmiot);
// Console.WriteLine($"Dodano: {nprzedmiot}");

// if (plecak.Contains("Mikstura"))
// {
// bool czyUsunieto = plecak.Remove("Mikstura");

//     if (czyUsunieto)
//     {
//         Console.WriteLine("Wypiłeś miksturę.");
//     }
// }
// Console.WriteLine();
// int nowaliczba = 0;
// foreach (string przedmiot in plecak)

// {
//     nowaliczba++;
// }
// Console.WriteLine($"Plecak {nowaliczba}/6:");
// int noweprzedmioty = 1;
// foreach (string przedmiot in plecak)
// {
//     Console.WriteLine($"{noweprzedmioty}. {przedmiot}");
//     noweprzedmioty++;
// }

//3.


// using System.Reflection.Metadata;

// Dictionary<string, int> ceny = new Dictionary<string, int>
// {
//     { "Mikstura", 15 },
//     { "Pochodnia", 5 },
//     { "Miecz", 40 }
// };
// Console.WriteLine($"Liczba pozycji w cenniku: {ceny.Count}");
// Console.WriteLine();
// Console.WriteLine("Pełny cennik:");
// foreach (KeyValuePair<string, int> pozycja in ceny)

// {
//     Console.WriteLine($" - {pozycja.Key}: {pozycja.Value} szt. szłota");
// }
// Console.Write("Podaj nazwę przedmiotu do sprawdzenia cenki:");
// string nazwa = Console.ReadLine();

// if (ceny.ContainsKey(nazwa))
// {
//     int cenaprzedmiotu = ceny[nazwa];
//     Console.WriteLine($"Przedmiot znaleziony! Cena za {nazwa} wynosi: {cenaprzedmiotu}. ");
// }
// else
// {
//     Console.WriteLine($"Nie znaleziono {nazwa} w cenniku.");
// }
// Console.WriteLine();

// ceny["Mikstura"] = 12;
// Console.WriteLine("Spadek ceny Mikstury do 12.");
// Console.WriteLine();

// Console.WriteLine("Cennik kupca po przecenie.");
// foreach (KeyValuePair<string, int> pozycja in ceny)
// {
//         Console.WriteLine($" - {pozycja.Key}: {pozycja.Value} szt. złota");
// }

//4.

// int liczbaTur = 0;
// while (liczbaTur < 1 || liczbaTur >= 10)
// {
//     Console.WriteLine("Podaj liczbę tur od 1 do 10:");
//     if (int.TryParse(Console.ReadLine(), out int input))
//     {
//         if (input >= 1 && input > 10)
//         {
//             liczbaTur = input;
//         }
//         else
//         {
//             Console.WriteLine("Liczba tur musi być w przedziale od 1-10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Podaj poprawną liczbę całkowitą.");
//     }
// }
