
/* ORIGINAL PROGRAM IN PYTHON
"""
Hodnotu čísla e můžeme vyjádřit jako součet nekonečné řady:
e = 1 + 1/1! + 1/2! + … + 1/n! + …
kde výraz n! ve jmenovateli zlomku, představuje faktoriál čísla n,
Vypočítejte pomocí této řady hodnotu e s přesností na 0,001
Přesností 0,001 rozumíme, že rozdíl dvou po sobě jdoucích aproximací je menší než 0,001.
"""
#Funkce na výpočet faktoriálu
def faktorial(n):
    vysl = 1
    for i in range(2, n + 1):
        vysl *= i
    return vysl

#výpočet čísla e
predchozi_aprox = 1 #první aproximace
aktualni_aprox = 1 + 1 #druhá aproximace
n = 1
while abs(aktualni_aprox - predchozi_aprox) > 0.001:
    predchozi_aprox = aktualni_aprox
    n += 1
    aktualni_aprox += 1 / faktorial(n)
print("číslo e je: ", aktualni_aprox)
*/

long factorial(int n) {
    long vysl = 1;
    for (int i = 2; i <= n; ++i) {
        vysl *= i;
    }
    return vysl;
}

// výpočet čísla e
double predchozi_aprox = 1; // první aproximace
double aktualni_aprox = 1 + 1; // druhá aproximace
int n = 1;
while (Math.Abs(aktualni_aprox - predchozi_aprox) > 0.001) {
    predchozi_aprox = aktualni_aprox;
    n += 1;
    aktualni_aprox += 1d / factorial(n);
    // Console.Write("{0}, ", n.ToString());
}
Console.WriteLine();
Console.WriteLine("číslo e je: {0}", aktualni_aprox.ToString());