// Module 02, Lesson 08


// Exercise 01

Console.WriteLine("Sprawdzanie liczb pierwszych w zakresie od 0 do 100");
int countNumbers = 0;

for (int i = 0; i <= 100; i++)
{
    if (IsPrime(i))
    {
        countNumbers++;
    }
}
static bool IsPrime(int number)
{
    if (number <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}
Console.WriteLine($"W zakresie od 0 do 100 znajduje się {countNumbers} liczb pierwszych.");


// Exercise 02

Console.WriteLine("Poniżej wszystkie liczby parzyste z zakresu 0 - 1000");

for (int val = 2; val <= 1000; val += 2)
{
    Console.WriteLine(val);
}


// Exercise 03

Console.Write("Podaj długość ciągu Fibonacciego: ");
int valFibonacci = int.Parse(Console.ReadLine());

Console.WriteLine("Ciąg Fibonacciego:");

int a = 0, b = 1;
for (int i = 0; i < valFibonacci; i++)
{
    Console.Write(a + " , ");
    int temp = a;
    a = b;
    b = temp + b;
}


// Exercise 04

Console.Write("Podaj liczbę całkowitą: ");
int n = int.Parse(Console.ReadLine());

int currentNumber = 1;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(currentNumber + " ");
        currentNumber++;
        if (currentNumber > n)
            break;
    }
    Console.WriteLine();
    if (currentNumber > n)
        break;
}

// Exercise 05

Console.Write("Liczby oraz ich trzecie potęgi: ");

for (int i = 1; i <= 20; i++)
{
    int cube = (int)Math.Pow(1, 3);
    Console.WriteLine($"{i} ^ 3 = {cube}");
}


// Exercise 06 

double sum = 0;
for (double i = 1; i <= 20; i++)
{
    sum = sum + (1.0 / i);
}

Console.WriteLine(sum);


// Exercise 07

Console.Write("Podaj długość przekątnej diamentu: ");
int diamondDiagonal = int.Parse(Console.ReadLine());

if (diamondDiagonal < 1 || diamondDiagonal % 2 == 0)
{
    Console.WriteLine("Długość przekątnej diamentu musi być liczbą nieparzystą większą od 0.");
    return;
}

int midpoint = diamondDiagonal / 2 + 1;

for (int i = 1; i <= midpoint; i++)
{
    for (int j = 1; j <= diamondDiagonal; j++)
    {
        if (j >= midpoint - i + 1 && j <= midpoint + i - 1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

for (int i = midpoint - 1; i >= 1; i--)
{
    for (int j = 1; j <= diamondDiagonal; j++)
    {
        if (j >= midpoint - i + 1 && j <= midpoint + i - 1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

// Exercise 08

Console.Write("Wyraz, który zostanie zapisany od tyłu: ");
string wordFromConsole = Console.ReadLine();
string reverse = "";

for (int i = wordFromConsole.Length - 1; i >= 0; i--)
{
    reverse += wordFromConsole[i];
}
Console.WriteLine(reverse);
Console.WriteLine();


// Exercise 09

Console.Write("Wpisz liczbę dzisiętną: ");
int decimalNumber = int.Parse(Console.ReadLine());

string binary = "";

while (decimalNumber > 0)
{
    int i = decimalNumber % 2;
    decimalNumber /= 2;
    binary = i + binary;

}
Console.WriteLine($"Liczba binarna = {binary}");


// Exercise 10

Console.WriteLine("Program pozwoli znaleźć najmniejszą wspólną wielokrotność dla dwóch liczb.");
Console.Write("Podaj pierwszą liczbę: ");
int valA = int.Parse(Console.ReadLine());

Console.Write("Podaj drugą liczbę: ");
int valB = int.Parse(Console.ReadLine());

static int NWD(int valA, int valB)
{
    while (valA != 0 && valB != 0)
    {
        if (valA > valB)
        {
            valA = valA % valB;
        }
        else
        {
            valB = valB % valA;
        }
    }
    if (valA != 0)
    {
        return valA;
    }
    else
    {
        return valB;
    }
}
int nww = (valA * valB / NWD(valA, valB));
Console.WriteLine($"Najmniejsza wspólna wielokrotność dla liczb {valA} i {valB} = {nww}");

