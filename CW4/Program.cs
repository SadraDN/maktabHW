
class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => FirstName + " " + LastName;
    public string City { get; set; }
    public bool IsMale { get; set; }
}



static class progtam
{
    public static void Main()
    {
        List<Student> students = new List<Student>();



        students.Add(new Student()
        {
            Id = 100,
            FirstName = "Mahdi",
            LastName = "Ahmadian",
            City = "Tehran",
            IsMale = true
        });
        students.Add(new Student()
        {
            Id = 101,
            FirstName = "Sina",
            LastName = "Akhavan",
            City = "Tehran",
            IsMale = true
        });
        students.Add(new Student()
        {
            Id = 102,
            FirstName = "Nima",
            LastName = "Ahmadi",
            City = "Kish",
            IsMale = true
        });
        students.Add(new Student()
        {
            Id = 103,
            FirstName = "Sara",
            LastName = "Amini",
            City = "Shiraz",
            IsMale = false
        });
        students.Add(new Student()
        {
            Id = 104,
            FirstName = "Maryam",
            LastName = "Khoshtinat",
            City = "Isfahan",
            IsMale = false
        });

        var x = students.Where(x => x.FirstName.Contains("Ma")).ToList();





    }

}