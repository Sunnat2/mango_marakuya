using System;

class Program
{
    static string[] FilterStrings(string[] arr)
    {
        int count = 0;
        // Подсчет количества строк, удовлетворяющих условию
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера и добавление подходящих строк
        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        // Примеры массивов
        string[][] arrays = new string[][]
        {
            new string[] {"Hello", "2", "world", ":-)"},
            new string[] {"1234", "1567", "-2", "computer science"},
            new string[] {"Russia", "Denmark", "Kazan"}
        };

        // Фильтрация и вывод результатов для каждого массива
        foreach (string[] arr in arrays)
        {
            string[] filteredArr = FilterStrings(arr);

            Console.WriteLine("Исходный массив:");
            Console.WriteLine($"[{string.Join(", ", arr)}]");
            Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
            Console.WriteLine($"[{string.Join(", ", filteredArr)}]");
            Console.WriteLine();
        }
    }
}  
