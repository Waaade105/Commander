using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            //Command com = new Command();
            return new Command { Id = 0, HowTo = "Boil An Egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command>()
            {
            new Command { Id = 0, HowTo = "Boil An Egg", Line = "Boil Water", Platform = "Kettle & Pan" },
            new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & chopping board" },
            new Command { Id = 2, HowTo = "Make cup of tea", Line = "place teabag in cup", Platform = "Kettle & cup" }
            };

            return  commands;
        }
    }
}
