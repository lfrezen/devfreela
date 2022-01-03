namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullname, string email, DateTime birthdate, string password, string role)
        {
            Fullname = fullname;
            Email = email;
            Birthdate = birthdate;
            CreatedAt = DateTime.Now;
            Active = true;
            Password = password;
            Role = role;
            Skills = new List<UserSkill>();
            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public DateTime Birthdate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
    }
}
