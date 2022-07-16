internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        Console.Write("Введите натуральное число N, обозначающее границу выводимой строки кубов чисел от 1 до N :  ");
        int borderNumber = int.Parse(Console.ReadLine());
        int[] arrayOfCube = new int[borderNumber];
        FillArrayWithCubeNums(arrayOfCube);
        PrintArray(arrayOfCube);

        void FillArrayWithCubeNums(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                array[i] = (i + 1) * (i + 1) * (i + 1);
                i++;
            }
        }
        void PrintArray(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.Write(array[i] + " ");
                i++;
            }
            Console.WriteLine();
        }
    }
}