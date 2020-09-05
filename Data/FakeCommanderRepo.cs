using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class FakeCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            List<Command> commands =
                new List<Command> {
                    new Command {
                        id = 1,
                        HowTo = "run a dotnet project in VS code",
                        CommandLine = "dotnet run",
                        Platform = "Platform Neutral"
                    },
                    new Command {
                        id = 2,
                        HowTo = "get the latest dotnet version installed",
                        CommandLine = "dotnet --version",
                        Platform = "Windows"
                    },
                    new Command {
                        id = 3,
                        HowTo = "open vs code",
                        CommandLine = "code .",
                        Platform = "Platform Neutral"
                    }
                };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                id = 1,
                HowTo = "run a dotnet project in VS code",
                CommandLine = "dotnet run",
                Platform = "Platform Neutral"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}
