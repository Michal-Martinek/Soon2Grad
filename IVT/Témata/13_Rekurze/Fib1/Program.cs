start:

int a, b;

Console.Write("Input a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b: ");
b = Convert.ToInt32(Console.ReadLine());


int GCD(int a, int b) {
    if (a == b) return a;
    if (a > b) return GCD(a - b, b);
    else return GCD(a, b - a);
}
int MUL(int a, int b) {
    if (a == 0) return 0;
    return b + MUL(a - 1, b);
}
int power(int a, int b) {
    if (b == 1) return a;
    return a * power(a, b-1);
}

int gcd = GCD(a, b);
Console.WriteLine("GCD({0}, {1}) = {2}", a, b, gcd);


int mul = MUL(a, b);
Console.WriteLine("{0} * {1} = {2}", a, b, mul);


int pow = power(a, b);
Console.WriteLine("{0}^{1} = {2}", a, b, pow);

Console.Write("\nAgain? ");
if (Console.ReadLine().Length == 0) {
    Console.WriteLine();
    goto start;
}
