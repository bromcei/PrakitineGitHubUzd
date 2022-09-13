double kintamasis1 = 0;
double kintamasis2 = 0;
double kintamasis3 = 0;

// 1 Variantas
double r1 = 6371;
kintamasis1 = 4 * Math.PI * Math.Pow(r1, 2);
// 2 Variantas

double r2 = 6371;

kintamasis2 = 4 / 3.0 * Math.PI * r2 * r2 * r2;

Console.WriteLine($"Rutulio tūris: V = {kintamasis2}");

// 3 Variantas

// Rezultatas
Console.WriteLine("*********************************");
Console.WriteLine("* Viso kintamųjų: 3");
Console.WriteLine($"* Kintamasis1; {kintamasis1}");
Console.WriteLine($"* Kintamasis2; {kintamasis2}");
Console.WriteLine($"* Kintamasis3; {kintamasis3}");
Console.WriteLine($"* Suma: {kintamasis1 + kintamasis2 + kintamasis3}");
Console.WriteLine($"* Visurkis: {(kintamasis1 + kintamasis2 + kintamasis3) / 3}");