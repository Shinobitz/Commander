using System.Collections.Generic;
using Commander.Models;

// mock data with fake data for testing
namespace Commander.Data{ 
    public class MockCommanderRepo : ICommanderRepo
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
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Make toast", Line="Buy bread", Platform="Toaster"},
                new Command{Id=1, HowTo="Boil an egg", Line="Place an egg in a pod", Platform="Pod and cooker"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Get a tea bag", Platform="Cup and kettle"}
            };
            return commands;
        }

        public Command getCommandById(int id)
        {
            return new Command {Id=0, HowTo="Make toast", Line="Buy bread", Platform="Toaster"};
        }

        public bool SaveChnages()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}