double kintamasis1 = 0;
double kintamasis2 = 0;
double kintamasis3 = 0;

// 1 Variantas

// 2 Variantas

double r2 = 6371;

kintamasis2 = 4 / 3.0 * Math.PI * r2 * r2 * r2;

Console.WriteLine($"Rutulio tūris: V = {kintamasis2}");

// 3 Variantas

// Rezultatas

Console.WriteLine($"Rezultatas: {kintamasis1 + kintamasis2 + kintamasis3}");