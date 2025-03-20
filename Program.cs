using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Bài 1: Các chức năng với số nguyên dương");
            Console.WriteLine("2. Bài 2: Quản lý thông tin sinh viên");
            Console.WriteLine("3. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            int mainChoice = int.Parse(Console.ReadLine());

            if (mainChoice == 3) break;

            switch (mainChoice)
            {
                case 1:
                    Bai1.Run();
                    break;
                case 2:
                    Bai2.Run();
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ");
                    break;
            }
        }
    }
}