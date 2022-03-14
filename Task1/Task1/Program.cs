// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Runtime.CompilerServices;
using Strategies.OrderStrategies;
using Strategies.SortStrategies;
using Strategies.SwapStrategies;

namespace Solution;

public class Program
{
    public static void Main(string[] args)
    {
        IOrderStrategy orderer = new AscendingOrder();
        ISwapStrategy swaper = new MaxSwap();
        ISortStrategy sorter = new BubbleSort();
        double[][] arr = new[]
        {
            new double[] {1, 2, 3},
            new double[] {4, 5, 6},
            new double[] {0, 0, 0},
        };
        string output = "1 - Выбор стратегии сортировки\n" +
                        "2 - Выбор стратегии сравнения элементов\n" +
                        "3 - Запуск сортировки\n" +
                        "4 - Вывод результирующей матрицы\n" +
                        "0 - Выйти из программы";
        char input;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Матрица:");
            ShowMatrix(arr);
            Console.WriteLine("Меню сортировки матрицы");
            Console.WriteLine(output);
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    swaper = ChooseSwapStrategy();
                    break;
                case '2':
                    orderer = ChooseOrderStrategy();
                    break;
                case '3':
                    sorter.Sort(ref arr, orderer, swaper);
                    break;
                case '4':
                    Console.Clear();
                    ShowMatrix(arr);
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    break;
                case '0':
                    return;
            }
        }
    }

    public static void ShowMatrix(double[][] arr)
    {
        foreach (var row in arr)
        {
            foreach (var item in row)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static ISwapStrategy ChooseSwapStrategy()
    {
        string output = "1 - По сумме элементов строки\n" +
                        "2 - По максимальному элементу строки\n" +
                        "3 - По минимальному элементу строки\n";
        char input;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(output);
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    return new SumSwap();
                case '2':
                    return new MaxSwap();
                case '3':
                    return new MinSwap();
            }
        }
    }
    
    public static IOrderStrategy ChooseOrderStrategy()
    {
        string output = "1 - По возрастанию\n" +
                        "2 - По убыванию\n";
        char input;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(output);
            input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    return new AscendingOrder();
                case '2':
                    return new DescendingOrder();
            }
        }
    }
}
