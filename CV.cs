namespace Admin_User;

public class CV
{
    public string Occupation { get; set; }
    public string School { get; set; }
    public int Score { get; set; }
    public List<string> Skills { get; set; } = new List<string>();
    public List<string> Companies { get; set; } = new List<string>();
    public DateOnly StartWork { get; set; }
    public DateOnly EndWork { get; set; }
    public List<string> Languages { get; set; } = new List<string>();
    public List<string> Certificate { get; set; } = new List<string>();
    public string GitLink { get; set; }
    public string Linkedin { get; set; }

    
    public CV()
    {
        
    }

    public CV(string occupation, string school, int score, List<string> skills, List<string> companies, DateOnly startWork, DateOnly endWork, List<string> languages, List<string> certificate, string gitLink, string linkedin)
    {
        Occupation = occupation;
        School = school;
        Score = score;
        Skills = skills;
        Companies = companies;
        StartWork = startWork;
        EndWork = endWork;
        Languages = languages;
        Certificate = certificate;
        GitLink = gitLink;
        Linkedin = linkedin;
    }

    public override string ToString() =>
        $"Occupation:{Occupation}\nSchool:{School}\nScore:{Score}\nSkills:{Skills}\nCompanies:{Companies}\nStartWork:{StartWork}\nEndWork{EndWork}\nLanguages:{Languages}\nCertificate:{Certificate}\nGitlink:{GitLink}\nLinkedin:{Linkedin}";
}
