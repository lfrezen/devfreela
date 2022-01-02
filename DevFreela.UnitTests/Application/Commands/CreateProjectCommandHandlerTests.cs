using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task InputDateIsOk_Executed_ReturnProjectId()
        {
            // Arrange
            var projectRepository = new Mock<IProjectRepository>();

            var createProjectCommand = new CreateProjectCommand
            {
                Title = "Titulo de Teste",
                Description = "Descricao de Teste",
                TotalCost = 50000,
                IdClient = 1,
                IdFreelancer = 2,
            };

            var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepository.Object);

            // Act
            var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());

            // Assert
            Assert.True(id >= 0);

            projectRepository.Verify(p => p.AddAsync(It.IsAny<Project>()), Times.Once);
        }
    }
}
