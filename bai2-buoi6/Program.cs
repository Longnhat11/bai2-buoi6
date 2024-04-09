using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_buoi6
{
     public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class StudentManager
{
    private Dictionary<string, Student> students;

    public StudentManager()
    {
        students = new Dictionary<string, Student>();
    }

    public void AddItem(string id, Student student)
    {
        students.Add(id, student);
    }

    public Student GetItem(string id)
    {
        return students[id];
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();

        Student student1 = new Student() { Name = "Nguyen Van A", Age = 20 };
        Student student2 = new Student() { Name = "Tran Thi B", Age = 22 };

        manager.AddItem("1", student1);
        manager.AddItem("2", student2);

        Console.WriteLine("Danh sach sinh vien:");
        for (int i = 1; i <= 2; i++)
        {
            Student student = manager.GetItem(i.ToString());
            Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}");
        }
        Console.ReadKey();
    }
}
}
