using System.Text.RegularExpressions;


bool TestOnRegex(string reg, string test)
{
    Regex r = new Regex(reg);
    var match = r.Match(test);
    return (match.Success && match.Value.Length == test.Length);
}


int[] polynom = { 2, 1, -3 };


float cislo;
string cisloText;
//do {
    Console.Write("Zadejte x pro vyhodnocení ");
    cisloText = Console.ReadLine();
    while (!float.TryParse(cisloText, out cislo)) {
        Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
        cisloText = Console.ReadLine();
    }
//} while (!TestOnRegex("^-?\\d+\\.?\\d*$", cisloText));

float.TryParse(cisloText, out cislo);

float power = 1.0f;
float value = 0.0f;
for (int i = polynom.Length - 1; i >= 0; i--) {
    value += polynom[i] * power;
    power *= cislo;
}

Console.WriteLine("Hodnota polynomu: ");
Console.WriteLine(value);
Console.ReadKey();



