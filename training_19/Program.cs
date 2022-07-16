internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
        Console.Write("Введите число, исследуемое на принадлежность к палиандромам: ");
        int inputDigit = int.Parse(Console.ReadLine());
        if (inputDigit < 10000 || inputDigit > 99999)
            Console.WriteLine("Вы ввели неверное число. Попытайтесь ещё раз...");
        else
            Console.WriteLine("Исследуемое число " + inputDigit + Investigation(inputDigit));
        string Investigation(int varDigit)
        {
            if (varDigit / 10000 % 10 == varDigit / 1 % 10 && varDigit / 1000 % 10 == varDigit / 10 % 10)
                return " является палиандромом";
            else
                return " не является палиандромом";
        }
    }
}