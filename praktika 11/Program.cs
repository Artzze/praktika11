using System;

class Program
{
    static void BubbleSortOddElements(int[] arr)
    {
        int n = arr.Length;
        // Проходим только по нечетным индексам массива
        for (int i = 1; i < n - 1; i += 2)
        {
            // Внутренний цикл для пузырьковой сортировки
            for (int j = 1; j < n - i - 1; j += 2)
            {
                // Сравниваем и меняем местами, если нужно
                if (arr[j] > arr[j + 2])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 2];
                    arr[j + 2] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] array = { 5, 1, 4, 2, 8, 0 };

        Console.WriteLine("Original array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        BubbleSortOddElements(array);

        Console.WriteLine("\nArray after sorting odd positions:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
