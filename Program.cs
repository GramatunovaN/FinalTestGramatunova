//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
Код: 
string [] GenerateArray(string elements)
{
string[] arrayFirst= new string[elements.Length];
arrayFirst = elements.Split(",");
return arrayFirst;
}

string [] Check(string [] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {count++;}
     }
string[] arrayFinal= new string[count];
    for (int i = 0, j=0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayFinal[j] = simvol;
            j++;
        }
    }
    return arrayFinal;
}    

void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, " );
    }
    Console.WriteLine();
}
Console.WriteLine("Введите элементы в массивеав разделяя их запятой");
Console.Write("Элементы:");
string elements = Console.ReadLine();
string [] arrayFirst = GenerateArray(elements); 
string [] arrayFinal = Check(arrayFirst);
Console.WriteLine();
Console.Write("Массив из элементов, длина которых меньше, либо равна 3 символам: ");
Print(arrayFinal);
