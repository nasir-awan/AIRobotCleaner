using System.Collections.Generic;
using AIRobotCleaner.Domain;

namespace AIRobotCleaner.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var totalNumberOfCommands = InputResolver.ResolveNumberOfCommands(System.Console.ReadLine());
            var startLocation = InputResolver.ResolveLocation(System.Console.ReadLine());

            var commands = new List<ICommand>();
            while (totalNumberOfCommands != 0)
            {
                var command = InputResolver.ResolveCommand(System.Console.ReadLine());
                commands.Add(command);
                totalNumberOfCommands--;
            }

            var robotCleaner = new RobotCleaner(startLocation, commands);
            robotCleaner.Start();

            System.Console.WriteLine(robotCleaner.DisplayResults());

            System.Console.ReadKey();

        }
    }
}
