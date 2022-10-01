Console.Clear();

/* string[,] table = new string [2,5]; // Задан двумерный массив строк. 
int [,] matrix = new int [5,8]; // Задан думерный [5,8] массив чисел. 
// 5 - количество строк, 8 - количество столбцов.
table [1,2] = "Виктор";
// table [0,0] - первый элемент первого столбца.
// [0, 4] - первый элемент пятого столбика. 

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"{table [rows, columns]}-");
    }
}
 */

/*  int [,] matrix = new int [3,4]; // Задан думерный [5,8] массив чисел. 
 for (int i = 0; i < matrix.GetLength(0); i++) // определяет количество строк.
{
    for (int f = 0; f < matrix.GetLength(1); f++)
    {
        Console.Write($"{matrix [i, f]} ");
    }
    Console.WriteLine();
} */


// Метод вывода массива двумерного массива. 

/* void PrintArrai(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // определяет количество строк.
    {
        for (int f = 0; f < matr.GetLength(1); f++)
        {
            Console.Write($"{matr [i, f]} ");
        }
        Console.WriteLine();
    }
}

void FillRandom (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // определяет количество строк.
    {
        for (int f = 0; f < matr.GetLength(1); f++)
        {
            matr[i,f] = new Random().Next(0, 10);
        }
    }
}
int [,] matrix = new int [4,10];
PrintArrai(matrix); // Инициализация массива
FillRandom(matrix); // Заполнение массива.
Console.WriteLine();
PrintArrai(matrix); // Распечатка текущего массива. */

// рекурсия - это когда функциия вызывает сама себя. 
// чтобы понять рекурсию, надо понять рекурсии. 

/* // Пример рекурсии в задаче на поиск Факториал.

double Factorial(int n)
{
    if(n == 1) return 1; 
    else return n*Factorial(n-1);
}
// Console.WriteLine(Factorial(3)); // 1*2*3=6
// Console.WriteLine(Factorial(5)); 

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // при сорока переполняется тип.
} */


// Задача поиска чисел Фибоначчи.
/* double Fibonacci(int f)
{
    if (f == 1 || f == 2) return 1; 
    else return Fibonacci (f - 1) + Fibonacci (f - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}"); // при сорока переполняется тип.
} */