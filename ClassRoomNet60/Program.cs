

    List<Student> students = new List<Student>
{
    new Student("Martin", 10, 15),
    new Student("Christoffer", 8, 22),
    new Student("Nicklas", 12, 3),
    new Student("Simon", 7, 3)
};

ClassRoom classRoom = new ClassRoom("Programming 3", students, new DateTime(2026, 08, 26));

Console.WriteLine($"Class Name: {classRoom.ClassName}");
Console.WriteLine($"Semester Start: {classRoom.SemesterStart}");

foreach (var student in classRoom.Students)
{
    Console.WriteLine($"{student.Name} - Birthday: {student.Birthday}/{student.BirthMonth}");
}
