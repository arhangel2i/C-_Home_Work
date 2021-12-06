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
    int i=0;
    string result = string.Empty;
    while(i<count)
    {
        i++;
        result+=text;
    }
    return result;
}

string retStr = Method4(10, "asdf");
Console.WriteLine(retStr);