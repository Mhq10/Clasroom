
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

}

