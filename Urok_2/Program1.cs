//Пример №9

int Max (int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int [] array = {1, 3, 18, 48, 35, 61, 102, 79, 50}; 

array[0] = 12; 

int result = Max (
    Max(array[0], array[1], array [2]),
    Max(array[3], array[4], array [5]),
    Max(array[6], array[7], array [8])    
);

Console.WriteLine(result);


// Пример №10
int [] array1 = {1,5,5,5,6,7,8,5,14,5,23};

int n = array1.Length;

int find = 5;
int index = 0;

while (index < n)
{
    if (array1[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}

// Пример №11.
Console.Clear();
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]=new Random().Next(1, 10);
        index++;
    
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
// retutn не используем

int Indexof(int[]collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0; 
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            Console.WriteLine(position);
        }
        index++;
    }
    return position; 
}
int [] array2 = new int [10];
FillArray(array2);
array2[4] = 5;
array2[7] = 5;
PrintArray(array2);

Console.WriteLine("А теперь позиция");

int pos = Indexof(array2, 5);
Console.WriteLine(pos);


