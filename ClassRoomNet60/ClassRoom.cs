
public class ClassRoom
{
    public string ClassName { get; set; }
    public List<Student> Students { get; set; }
    public DateTime SemesterStart { get; set; }

    public ClassRoom(string className, List<Student> students, DateTime semesterStart)
    {
        ClassName = className;
        Students = students;
        SemesterStart = semesterStart;
    }

    public void CountBirthdaysBySeason()
    {
        int winterCount = Students.Count(s => s.Season() == "Winter");
        int springCount = Students.Count(s => s.Season() == "Spring");
        int summerCount = Students.Count(s => s.Season() == "Summer");
        int autumnCount = Students.Count(s => s.Season() == "Autumn");

        Console.WriteLine($"Winter birthdays: {winterCount}");
        Console.WriteLine($"Spring birthdays: {springCount}");
        Console.WriteLine($"Summer birthdays: {summerCount}");
        Console.WriteLine($"Autumn birthdays: {autumnCount}");
    }
}

