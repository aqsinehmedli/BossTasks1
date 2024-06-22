namespace Admin_User;

public class Worker
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public CV CV { get; set; }

    public Worker(int id, string name, string surname, string city, string phone, int age, CV cV)
    {
        Id = id;
        Name = name;
        Surname = surname;
        City = city;
        Phone = phone;
        Age = age;
        CV = cV;
    }

    public override string ToString() =>
       $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nCity:{City}\nPhone:{Phone}\nAge:{Age}\nCV:{CV}";

}
