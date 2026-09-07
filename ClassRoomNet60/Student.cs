

    public class Student

{
    public string Name { get; set; }
    public int BirthMonth { get; set; }
    public int Birthday { get; set; }

    public Student(string name, int birthMonth, int birthday)
    {
        if (birthMonth < 1 || birthMonth > 12)
            throw new ArgumentException("Birth month must be between 1 and 12");

        Name = name;
        BirthMonth = birthMonth;
        Birthday = birthday;
    }

    public string Season ()
    {
        if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
        {
            return "Winter";
        }
        else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
        {
            return "Spring";
        }
        else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
        {
            return "Summer";
        }
        else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
        {
            return "Autumn";
        }
        else
        {
            return "Invalid month";
        }

    }




}

