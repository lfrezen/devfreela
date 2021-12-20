using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Joao Silva", "joao@teste.com", new DateTime(1990, 1, 1)),
                new User("Robert C Martin", "robert@teste.com", new DateTime(1959, 1, 1)),
                new User("Anderson", "anderson@teste.com", new DateTime(1976, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
