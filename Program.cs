/*
Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
int GetDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
void InitialArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Console.ReadLine();
    }
}
void EditArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
int razmer = GetDataFromUser("Введите количество элементов первоначального массива");
Console.WriteLine($"Массив будет состоять из {razmer} элементов");
Console.WriteLine();
string[] array = new string[razmer];
InitialArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый массив: [{string.Join(", ", array)}]");
Console.Write($"Полученный массив: ");
EditArray(array);
Console.WriteLine();