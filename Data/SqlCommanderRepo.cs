using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if ( command == null )
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Commands.Add(command);
        }

        public void DeleteCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command getCommandById(int id)
        {
            // use commands set and use first element or default of Command object "p", and when p's Id is the same as id, return the "p" object.
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChnages()
        {
            return (_context.SaveChanges() >= 0 );
        }

        public void UpdateCommand(Command command)
        {
            // Do nothing
        }
    }
}