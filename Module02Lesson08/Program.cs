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

for (int val = 2; val <= 1000; val +=2)
{
    Console.WriteLine(val);
}


// Exercise 03

Console.Write("Podaj długość ciągu Fibonacciego: ");
int valFibonacci = Int32.Parse(Console.ReadLine());

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

Console.WriteLine("Podaj liczbę całkowitą:");
int pyramid = Int32.Parse(Console.ReadLine());

    int currentNumber = 1;

    for (int i = 1; i <= pyramid; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(currentNumber + " ");
            currentNumber++;
        }
        Console.WriteLine();
    }


// Exercise 05

Console.WriteLine("Liczby oraz ich trzecie potęgi:");

    for (int i = 1; i <= 20; i++)
    {
        int cube = i * i * i;
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

Console.WriteLine("Podaj długość krótszej przekątnej diamentu:");
int lenght = Int32.Parse(Console.ReadLine());

    
    for (int i = 1; i <= lenght; i++)
    {
        for (int j = 1; j <= lenght - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    
    for (int i = lenght - 1; i >= 1; i--)
    {
        for (int j = 1; j <= lenght - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
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
int decimalNumber = Int32.Parse(Console.ReadLine());

    string binary = "";

    while (decimalNumber > 0)
    {
        int i = decimalNumber % 2;
        decimalNumber /= 2;
        binary = i + binary;
        
    }
Console.WriteLine($"Liczba binarna = {binary}");


// Exercise 10

Console.WriteLine("Program pozwoli znaleźć najmniejsząwspólną wielokrotność dla dwóch liczb.");
Console.Write("Podaj pierwszą liczbę:");
int valA = Int32.Parse(Console.ReadLine());

Console.Write("Podaj drugą liczbę:");
int valB = Int32.Parse(Console.ReadLine());

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

