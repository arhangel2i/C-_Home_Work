//Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg:"Hello World");

void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        i++;
        Console.WriteLine(msg);
    }
}

//Method21("Hello World", 3);
//Method21(count:3, msg:"Hello World");

//Вид3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

//Вид4

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i=0; i<count; i++)
    {
        result+=text;
    }
    return result;
}

string retStr = Method4(10, "1");
//Console.WriteLine(retStr);

for(int i=2; i<10; i++)
{
    for(int j=1;j<10;j++)
    {
        string msg = $"{i} х {j} = {i*j}";
        Console.Write(msg + "   ");
        if (j%3==0) Console.WriteLine();
    }
    Console.WriteLine();
}