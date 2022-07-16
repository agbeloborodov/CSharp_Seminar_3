internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        Console.WriteLine("Введите координаты точки А (x1, y1, z1) относительно выбранной Вами инерциальной системы координат.");
        Console.Write("Введите x1 : ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Введите y1 : ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("Введите z1 : ");
        int z1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x2, y2, z2) относительно выбранной Вами инерциальной системы координат.");
        Console.Write("Введите x2 : ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Введите y2 : ");
        int y2 = int.Parse(Console.ReadLine());
        Console.Write("Введите z2 : ");
        int z2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Расстояние между выбранными Вами точками в Вашей системе координат и Ваших единицах измерений равно " + Duration(x1, y1, z1, x2, y2, z2));

        double Duration(int x1, int y1, int z1, int x2, int y2, int z2)    // IMHO - не нужно показательно изменять имена передаваемых параметров. Комфорт превыше.
        {
            double lenOfVector = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
            return Math.Round(lenOfVector, 2);
        }
    }
}