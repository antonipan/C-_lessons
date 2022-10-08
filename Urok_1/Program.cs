// Пример №1. 

Console.WriteLine("Hello, World! 234");

// Пример №2. 
// Console.WriteLine("Введите ваше имя");
// string user_name = Console.ReadLine();
// Console.Write("Здравствуйте, ");
// Console.Write(user_name);// Пример №3. 

// Пример №3.


// int numberA = 14;
// int numberB = 5;
// int sum = numberA + numberB;

// Console.WriteLine(sum);

// Пример №4. 
int numberA = new Random().Next(1,10); // числа от одного до десяти
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int diff = numberA + numberB;
Console.WriteLine(diff);

// Пример №5. 
// Console.WriteLine("Введите ваше имя");
// string username = Console.ReadLine();

// if (username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура! Это же Маша!");
// }
// else{
//     Console.Write("Привет, ");
//     Console.Write(username);
// }

// Пример №6. 
int a = 2;
int b = 4;
int c = 7;
int d = 1;
int e = 5; 
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("это максимальное = ");
Console.Write(max);

// Пример №7. 
Console.Clear();
//Console.SetCursorPosition(10,4); 
//Console.WriteLine("+");

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;
while(count < 20000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}

// Пример №8. 
int Max (int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int [] array = {1, 3, 18, 48, 35, 61, 102, 79, 50, 35, 64}; 


Console.WriteLine(Max(3,2,4));






// Пример №9. 
