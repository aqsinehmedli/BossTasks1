namespace Admin_User;

public class Employer
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public string Vacancies { get; set; }

    public Employer(int id, string name, string surname, string city, string phone, int age, string vacancies)
    {
        Id = id;
        Name = name;
        Surname = surname;
        City = city;
        Phone = phone;
        Age = age;
        Vacancies = vacancies;
    }
    public override string ToString() =>
        $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nCity:{City}\nPhone:{Phone}\nAge:{Age}\nVacancies{Vacancies}";
}
