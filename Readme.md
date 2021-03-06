# Знакомство с языком C#
## Оглавление:
1. [Урок № 1. Знакомство с языком программирования C#](#lesson1)
2. [Урок № 2. Знакомство с функцияи и массивами](#lesson2)
3. [Урок № 3. Знакомство с функцияи и массивами (продолжение)](#lesson3)
4. [Урок № 4. Рекурсия и двумерные массивы](#lesson4)

## <a name="lesson1"></a> Урок № 1. Знакомство с языком программирования C#

### **Работа в консоле c компонентом DotNet**:

* dotnet new console

    *Создание простого консольного приложения (также создает все нужные файлы)*

* dotnet run

    *Запуск текущего проекта*

### **Перечень операторов для языка C#:**

Комманда|Описание|Дополнительная информация
:-|:-|:-
**Console.WriteLine(variable)**|*Выводит переменную на экран консоли c переносом строки*
**Console.WriteLine($"Пример {variable}")**|Пример вставки переменной в строку и ввод ее на экран
**Console.Write(variable)**|*Выводит переменную на экран консоли без переноса строки*
**Console.SetCursorPosition(x,y)**|Установка позиции курсора в терминале x,y|Если при установке позии x,y выйдет за границы терминала будет выведена ошибка
**While (условие){}**|Цикл c условием внутри (условие условие возвращает true условие выполняется если, false завершается)|если внутри цикла выполнить оператор **break;** цикл завершиться
**for(int i=start;i<end;i++){}**|Стандартный цикл for где start стартовый счетчик end конечный счетчик|
**If {} Else {}**|Условие если то|
**variable++**|увеличить значение на 1|

## <a name="lesson2"></a> Урок № 2. Знакомство с функцияи и массивами

### Пример определения функции:

```C#
int max(int arg)
{
    return retVal;    
}
```

>* **int** => тип возвращаемого значения (тип **void** функция не возвращает значение)
>* **max** => название функции *(название не должно совпадать с названиями других функций)*
>* **int arg** => тип и значение входящего аргумента
>* **return retVal** => функция возвращает значение переменной retVal *(важно! что после вызова этой команды функция сразу завершается)*

### Пример определения массива:
```C#
//инициализация массива сразу значениями
int[] arg = {1,2,3,4,5,6,7,8,9};
//инициализация массива без значений
int[] arg = new int[8];
//установка значения в массиве
arg[0]=1;
arg[1]=5;
```
>* **int[]** => указывает тип и что данная переменная является массивом
>* **{1,2,3,4,5,6,7,8,9}** => инициализация массива значениями
>* **new int[8]** => **int[]** тип массива, **8** кол-во элементов в массиве *(0 тоже считается поэтому в массиве будет 9 элементов хотя пишем 8)*
>* *Важно понимать что когда инициализируется массив без значений все его элементы заполнются значениями по умолчанию данного типа. Например числовые типы заполняются 0 то есть массив **new int[8];** в каждой своей ячейке содержит 0*

## <a name="lesson3"></a> Урок № 3. Знакомство с функцияи и массивами (продолжение)

### Пример использования именованных аргументов функции:
```C#
void Method21(string msg, int count)
{
    int i =0;
    while (i<count)
    {
        Console.WriteLine(msg);
    }
}
//обычный вид использования
Method21("Hello world", 4);
//при использовании именнованных аргументов порядок не важен
Method21(count:4, msg:"Hello World");
```
### Пример использования цикла for:

```C#
//Вывести на экран "Hello world" 9 раз
for(int i=1; i<=9; i++)
{
    Console.WriteLine("Hello World");
}
```

## <a name="lesson4"></a> Урок № 4. Рекурсия и двумерные массивы

### Пример инициализации многомерного массива:

```C#
// Двумерный массив
string [,] table = new string[2,5];
// Важно! Массив начинается с нуля поэтому максимальный индекс при обращении на 1 меньше
Console.WriteLine($"... new string[2,5]=> строк {table.GetLength(0)}, столбцов {table.GetLength(1)}");
//В данном случае максимальные индексы по строкам это table[1,0], по столбцам это table[0,4] итого table[1,4]
int[,] matrix = new int[3,8];
Console.WriteLine($"... new int[3,8]=> строк {matrix.GetLength(0)}, столбцов {matrix.GetLength(1)}");
//В данном случае максимальные индексы по строкам это matrix[2,0], по столбцам это matrix[0,7] итого matrix[2,7]

// Трехмерный массив
string[,,] MultiArray = new string[2,3,4];
MultiArray[1,1,1] = "Ок";
Console.WriteLine($"... new string[2,3,4]=> 1-вложеность {MultiArray.GetLength(0)}, 2-вложеность  {MultiArray.GetLength(1)}, 3-вложеность  {MultiArray.GetLength(2)},");
//Тут максимальные индексы MultiArray[1,2,3]
```

### Пример рекурсии:
>Рекурсия это ситация когда метод вызывает сам себя

```C#
Console.WriteLine(Factorial(5));
int Factorial (int n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
// фукция вызывает саму себя пока не достигнет условия когда n=1
```
