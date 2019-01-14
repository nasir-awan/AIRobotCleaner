using System;
using AIRobotCleaner.Domain;

namespace AIRobotCleaner.Console
{
    public class InputResolver
    {
        public static ICommand ResolveCommand(string input)
        {
            var stringInput = input.Split(' ');
            var direction = stringInput[0];
            var numberOfSteps = Convert.ToInt32(stringInput[1]);

            switch (direction)
            {
                case "E":
                    return new Command(Direction.East, numberOfSteps);
                case "W":
                    return new Command(Direction.West, numberOfSteps);
                case "N":
                    return new Command(Direction.North, numberOfSteps);
                case "S":
                    return new Command(Direction.South, numberOfSteps);
                default:
                    return new Command(Direction.None, numberOfSteps);
            }
        }

        public static ILocation ResolveLocation(string input)
        {
            var coordinates = input.Split(' ');
            return new Location(int.Parse(coordinates[0]), int.Parse(coordinates[1]));
        }

        public static int ResolveNumberOfCommands(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}
