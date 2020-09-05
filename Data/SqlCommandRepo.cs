using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommandRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommandRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            _context.Commands.Add(command);
        }

        public void DeleteCommand(Command command)
        {
            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllCommands() =>
            _context.Commands.ToList();

        public Command GetCommandById(int id) =>
            _context.Commands.FirstOrDefault(p => p.id == id);

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCommand(Command command)
        {
            // Do nothing as this is being tracked by data context.
        }
    }
}
