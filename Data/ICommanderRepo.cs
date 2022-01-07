using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChnages();

        // Get request
        IEnumerable<Command> GetAllCommands();
        Command getCommandById(int id);

        // Create request
        void CreateCommand(Command command);

        // PATCH request
        void UpdateCommand(Command command);

        // DELETE request
        void DeleteCommand(Command command);
    }
}