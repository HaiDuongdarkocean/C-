using System;

class Bai1
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Menu Bài 1:");
            Console.WriteLine("1. Kiểm tra số nguyên tố");
            Console.WriteLine("2. Tính giai thừa");
            Console.WriteLine("3. Kiểm tra số chính phương");
            Console.WriteLine("4. Kiểm tra số Fibonacci");
            Console.WriteLine("5. Tính tổng các chữ số");
            Console.WriteLine("6. Tìm số lớn nhất, bé nhất");
            Console.WriteLine("7. Quay lại");
            Console.Write("Chọn một tùy chọn: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 7) break;

            Console.Write("Nhập một số nguyên dương: ");
            int number = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(IsPrime(number) ? "Là số nguyên tố" : "Không phải số nguyên tố");
                    break;
                case 2:
                    Console.WriteLine($"Giai thừa của {number} là {Factorial(number)}");
                    break;
                case 3:
                    Console.WriteLine(IsPerfectSquare(number) ? "Là số chính phương" : "Không phải số chính phương");
                    break;
                case 4:
                    Console.WriteLine(IsFibonacci(number) ? "Là số Fibonacci" : "Không phải số Fibonacci");
                    break;
                case 5:
                    Console.WriteLine($"Tổng các chữ số của {number} là {SumOfDigits(number)}");
                    break;
                case 6:
                    (int maxDigit, int minDigit) = FindMaxMinDigit(number);
                    Console.WriteLine($"Chữ số lớn nhất: {maxDigit}, Chữ số nhỏ nhất: {minDigit}");
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ");
                    break;
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static long Factorial(int number)
    {
        if (number == 0) return 1;
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static bool IsPerfectSquare(int number)
    {
        int sqrt = (int)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }

    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        if (number == a || number == b) return true;
        int c = a + b;
        while (c <= number)
        {
            if (c == number) return true;
            a = b;
            b = c;
            c = a + b;
        }
        return false;
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static (int, int) FindMaxMinDigit(int number)
    {
        int maxDigit = int.MinValue;
        int minDigit = int.MaxValue;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > maxDigit) maxDigit = digit;
            if (digit < minDigit) minDigit = digit;
            number /= 10;
        }
        return (maxDigit, minDigit);
    }
}