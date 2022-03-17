
Person User1 = new Person();
Console.WriteLine("Enter your first name");
User1.FirstName = Console.ReadLine();

Console.WriteLine("Enter your last name");
User1.LastName = Console.ReadLine();

Console.WriteLine("Enter your Id card number");
User1.IdNumber = Console.ReadLine();

Console.WriteLine("Enter your Height");
User1.Height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Mobile number");
User1.Mobile = Console.ReadLine();

Console.WriteLine("Enter your father name");
User1.FatherName = Console.ReadLine();

Console.WriteLine("Enter your weight");
User1.Weight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birth date");
User1.BirthDate = Console.ReadLine();

Console.WriteLine("Enter your address");
User1.Address = Console.ReadLine();

List<Person> list = new List<Person>();
list.Add(User1);

var path = "d://Maktab//Information.txt";
File.Create(path);



string info = User1.FirstName + "," + User1.LastName + "," + User1.IdNumber + "," + User1.Height + "," + User1.Mobile + "," + User1.FatherName + "," + User1.Weight + "," + User1.BirthDate + "," + User1.Address;
string showinfo = User1.FirstName + "," + User1.LastName + "," + User1.IdNumber;



