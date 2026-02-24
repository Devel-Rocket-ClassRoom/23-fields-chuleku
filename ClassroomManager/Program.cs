using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
ClassRoomManager class1 = new ClassRoomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassRoomManager class2 = new ClassRoomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassRoomManager.ShowTotalClassrooms();
