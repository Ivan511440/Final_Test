// Задача.
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомдуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello","2","world",":-)"] → ["2",":-)"]
// ["1234","1567","-2","computer science"] → ["-2"]
// ["Russia","Denmark","Kazan"] → []

// Решение 1.(с использованием двух массивов)
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine()!);
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(arrayStrings);



      
   







