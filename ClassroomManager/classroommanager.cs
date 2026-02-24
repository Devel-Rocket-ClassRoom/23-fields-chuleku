using System;
using System.Collections.Generic;
using System.Text;
class ClassRoomManager
{
    private const int MaxStudent = 5;
    private readonly string ClassroomName;
    private string[] StudentName;
    private int student = 0;
    private static int ClassRoom = 0;

    public ClassRoomManager(string ClassroomName)
    {
        ClassRoom++;
        StudentName = new string[MaxStudent];
    }
    public void AddStudent(string name)
    {
        student++;
        StudentName[student] = name;
        if (student > MaxStudent)
        {
            Console.WriteLine("정원 초과");
        }
    }
    public void ShowStudents()
    {
        Console.WriteLine($"=== {ClassroomName} 학생 목록 ({student}/{MaxStudent}) ===");
        for (int i = 1; i < StudentName.Length - 1; i++)
        {
            if (StudentName[i] != null)
            {
                Console.WriteLine($"{i}. {StudentName[i]}");
            }
        }

    }
    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {ClassRoom}");
    }
}
