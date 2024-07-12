using System;
using System.Collections.Generic;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.Write("Nhập ID của sinh viên (nhập '#' để dừng): ");
            string id = Console.ReadLine();

            if (id == "#")
            {
                break;
            }

            Console.Write("Nhập GPA của sinh viên: ");
            string gpaInput = Console.ReadLine();
            double gpa;

            if (!double.TryParse(gpaInput, out gpa))
            {
                Console.WriteLine("GPA không hợp lệ, bỏ qua mục nhập này.");
                continue;
            }

            students.Add(new Student { ID = id, GPA = gpa });
        }

        // Tạo Dictionary từ danh sách sinh viên
        Dictionary<string, double> dict1 = new Dictionary<string, double>();
        foreach (var student in students)
        {
            dict1[student.ID] = student.GPA;
        }

        // Xác định điểm trung bình của sinh viên có ID là "123456"
        string searchID = "123456";
        double gpaOfStudent;

        if (dict1.TryGetValue(searchID, out gpaOfStudent))
        {
            Console.WriteLine($"Điểm trung bình của sinh viên có ID '{searchID}' là: {gpaOfStudent}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên có ID '{searchID}' trong danh sách.");
        }
    }
}