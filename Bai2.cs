using System;
using System.Linq;

struct Student
{
    public string Name;
    public string ClassCode;
    public double MathScore;
    public double PhysicsScore;
    public double ChemistryScore;

    public double AverageScore => (MathScore + PhysicsScore + ChemistryScore) / 3;
}

class Bai2
{
    static Student[] students = new Student[15];
    static int studentCount = 0;

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Menu Bài 2:");
            Console.WriteLine("1. Nhập thông tin sinh viên");
            Console.WriteLine("2. Hiển thị thông tin sinh viên");
            Console.WriteLine("3. Tính điểm trung bình cho sinh viên vừa nhập");
            Console.WriteLine("4. Cập nhật thông tin sinh viên");
            Console.WriteLine("5. Xóa thông tin sinh viên");
            Console.WriteLine("6. Sắp xếp danh sách sinh viên theo điểm trung bình");
            Console.WriteLine("7. Sắp xếp danh sách sinh viên theo tên");
            Console.WriteLine("8. Quay lại");
            Console.Write("Chọn một tùy chọn: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 8) break;

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
                case 3:
                    CalculateAverageScores();
                    break;
                case 4:
                    UpdateStudent();
                    break;
                case 5:
                    DeleteStudent();
                    break;
                case 6:
                    SortStudentsByAverageScore();
                    break;
                case 7:
                    SortStudentsByName();
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        if (studentCount >= 15)
        {
            Console.WriteLine("Đã đạt đến số lượng sinh viên tối đa.");
            return;
        }

        Student student = new Student();

        Console.Write("Nhập họ tên: ");
        student.Name = Console.ReadLine();
        Console.Write("Nhập mã lớp: ");
        student.ClassCode = Console.ReadLine();
        Console.Write("Nhập điểm toán: ");
        student.MathScore = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm lý: ");
        student.PhysicsScore = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm hóa: ");
        student.ChemistryScore = double.Parse(Console.ReadLine());

        students[studentCount] = student;
        studentCount++;
    }

    static void DisplayStudents()
    {
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Sinh viên {i + 1}:");
            Console.WriteLine($"Họ tên: {students[i].Name}");
            Console.WriteLine($"Mã lớp: {students[i].ClassCode}");
            Console.WriteLine($"Điểm toán: {students[i].MathScore}");
            Console.WriteLine($"Điểm lý: {students[i].PhysicsScore}");
            Console.WriteLine($"Điểm hóa: {students[i].ChemistryScore}");
            Console.WriteLine($"Điểm trung bình: {students[i].AverageScore}");
            Console.WriteLine();
        }
    }

    static void CalculateAverageScores()
    {
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Điểm trung bình của sinh viên {students[i].Name}: {students[i].AverageScore}");
        }
    }

    static void UpdateStudent()
    {
        Console.Write("Nhập số thứ tự của sinh viên cần cập nhật: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= studentCount)
        {
            Console.WriteLine("Số thứ tự không hợp lệ.");
            return;
        }

        Console.Write("Nhập họ tên mới: ");
        students[index].Name = Console.ReadLine();
        Console.Write("Nhập mã lớp mới: ");
        students[index].ClassCode = Console.ReadLine();
        Console.Write("Nhập điểm toán mới: ");
        students[index].MathScore = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm lý mới: ");
        students[index].PhysicsScore = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm hóa mới: ");
        students[index].ChemistryScore = double.Parse(Console.ReadLine());
    }

    static void DeleteStudent()
    {
        Console.Write("Nhập số thứ tự của sinh viên cần xóa: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= studentCount)
        {
            Console.WriteLine("Số thứ tự không hợp lệ.");
            return;
        }

        for (int i = index; i < studentCount - 1; i++)
        {
            students[i] = students[i + 1];
        }

        studentCount--;
    }

    static void SortStudentsByAverageScore()
    {
        students = students.Take(studentCount).OrderByDescending(s => s.AverageScore).ToArray();
        Console.WriteLine("Danh sách sinh viên đã được sắp xếp theo điểm trung bình.");
    }

    static void SortStudentsByName()
    {
        students = students.Take(studentCount).OrderBy(s => s.Name).ToArray();
        Console.WriteLine("Danh sách sinh viên đã được sắp xếp theo tên.");
    }
}