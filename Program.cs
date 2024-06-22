
using Admin_User;

//List<string> skills1 = new List<string> { "C#", "JavaScript", "SQL" };
//List<string> skills2 = new List<string> { "C#", "JavaScript", "SQL" };

//List<string> companies1 = new List<string> { "A Group Consulting", "Socar" };
//List<string> companies2 = new List<string> { "BP", "DLB Consulting" };

//List<string> language1 = new List<string> { "English", "Russian", "Japanese" };
//List<string> language2 = new List<string> { "Germany", "Russian", "Portuguese" };

//List<string> certificate1 = new List<string> { "Microsoft Office", "Soft Skills" };
//List<string> certificate2 = new List<string> { "DLB Certificate", "BP Certificate" };

//CV cv1 = new CV("Computer Engineer", "ADA", 650, skills1, companies1, new DateOnly(2020, 05, 23), new DateOnly(2022, 05, 22), language1, certificate1, "https://github.com/aqsinehmedli/Bank_Tasks.git", "aqsinhmdli");
//CV cv2 = new CV("OIL - GAS ENGINEERING", "BANM", 600, skills2, companies2, new DateOnly(2019, 05, 03), new DateOnly(2023, 01, 24), language2, certificate2, "https://github.com/aqsinehmedli/aqsinehm.git", "mehmand1");



Employer employer1 = new Employer(1, "Nizami", "Amirov", "Sheki", "0513224466", 21, "C# Developer");
Employer employer2 = new Employer(2, "Revan", "Agazade", "Sumgayit", "0993232323", 21, "C++ Developer");

List<Employer>employers = new List<Employer>();
List<Worker> workers = new List<Worker>
    {
        new Worker(1, "Mehemmed", "Turkogu", "Yevlax", "0706455678", 23, new CV("Computer Engineer", "ADA", 650, new List<string> { "C#", "JavaScript", "SQL" }, new List<string> { "A Group Consulting", "Socar" }, new DateOnly(2020, 05, 23), new DateOnly(2022, 05, 22), new List<string> { "English", "Russian", "Japanese" }, new List<string> { "Microsoft Office", "Soft Skills" }, "https://github.com/aqsinehmedli/Bank_Tasks.git", "aqsinhmdli")),
        new Worker(2, "Daglar", "Daglaroglu", "Qebele", "0506455678", 27, new CV("OIL - GAS ENGINEERING", "BANM", 600, new List<string> { "C#", "JavaScript", "SQL" }, new List<string> { "BP", "DLB Consulting" }, new DateOnly(2019, 05, 03), new DateOnly(2023, 01, 24), new List<string> { "Germany", "Russian", "Portuguese" }, new List<string> { "DLB Certificate", "BP Certificate" }, "https://github.com/aqsinehmedli/aqsinehm.git", "mehmand1"))
    };

void Display()
{
    string username = Console.ReadLine();
    foreach (Worker item in workers)
    {
        if (item.Name == username)
        {
            Console.WriteLine(item.ToString());
        }
        else
        {
            foreach (Employer item1 in employers)
            {
                Console.WriteLine(item1);
            }
        }
    }




}
Display();