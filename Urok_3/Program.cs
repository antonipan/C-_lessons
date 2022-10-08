
/* 
// Типы методов 
Console.Clear();

// 1. Не принимает и не возвращает.
void Method1() // void - пустой метод, он ничего не возвращает. 
// Может принимать, а может и нет. 
{
    Console.WriteLine("Автор Панфёров Антон"); // Тело метода.
}
Method1(); // вызвали метод.  */

// 1. Принимает, но не возвращает. 

/* void Method2(string msg)
{
    Console.WriteLine(msg); // Тело метода.
}
Method2(msg: "Текст сообщения");  */

/* void Method21(string msg, int count) // В скобках аргументы
{
    int i = 0; // Тело метода.
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); // прописываем метод.  

Method21(count: 4, msg: "Новый текст"); // прописываем метод.   */

/* // №3. Не принимает, но возвращает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); 
Console.WriteLine(year); */

// №4. Принимает и возвращает.

/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; 
    
    while (i < count)
    {
        result = result + text; 
        i++;
        
    }
    return result;
}
string res = Method4(10, "asd "); 
Console.WriteLine(res); */

/*
 string Method4(int count, string text)
{
    string result = String.Empty; 
    for (int i = 0; i < count; i++)
    {
        result = result + text; 
    }
    return result;
}
string res = Method4(3, "Zzz... "); 
Console.WriteLine(res);  */

//Задача на закрашивание.

/* for (int i = 2; i <=10; i++)
{
        for (int j = 1; j <=10; j++)
    {
        Console.WriteLine($"{j} x {i} = {i*j}");
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
 */

/* string text = "Сергей, спасибо за лекцию."
            + "Если вы немного снизите темп изложения, "
            + "то материал будет восприниматься гораздо легче и лучше, "
            + "а лекция удлинится всего на несколько минут."
            + "Сам грешу подобным, поэтому понимаю, "
            + "что перестроить темп изложения может быть совсем не просто, "
            + "но результат все оправдает.Еще раз спасибо.";

// 
Console.WriteLine(text);
string Replace(string text, char oldValue, char newValue) // метод.
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result; 
}

string newText = Replace(text, ' ', '|'); // применение метода.
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine();
Console.WriteLine(newText);
 */


/* Console.Clear();
 int [] mass1 = {1, 3, 1, 4, 5, 8, 11, 13, 7, 9, 0, 10, 8};

void Printmass1 (int [] mass1)
{
    int count = mass1.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{mass1[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] mass1)
{
    for (int i = 0; i < mass1.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < mass1.Length; j++)
        {
            if (mass1[j] < mass1[minPosition]) 
            {
                minPosition = j;
            }
        }
        int temp = mass1[i];
        mass1[i] = mass1[minPosition];
        mass1[minPosition] = temp;

    }
    
}


Printmass1(mass1);
SelectionSort(mass1);
Printmass1(mass1);
 */