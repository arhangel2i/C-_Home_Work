

for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}


double Factorial (double n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1);
}

double Fibonacci(double n)
{
    if (n==1 || n== 2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}