using System;
using System.Collections.Generic;

namespace AIRobotCleaner.Domain
{
    public class RobotCleaner : IRobotCleaner
    {
        public IList<ICommand> Commands { get; }
        public ILocation StartOrLastLocation { get; private set; }
        public SortedSet<ILocation> UniqueCleanedLocations { get; }
        public RobotCleaner(ILocation startLocation, IList<ICommand> commands)
        {
            StartOrLastLocation = startLocation;
            Commands = commands;
            UniqueCleanedLocations = new SortedSet<ILocation> { startLocation };
        }

        public void Start()
        {
            foreach (var command in Commands)
            {
                ProcessCommand(command);
            }
        }

        public void Stop()
        {
            //TODO: Auto stop once commands are processed
            throw new NotImplementedException();
        }

        public string DisplayResults()
        {
            return $"Cleaned {UniqueCleanedLocations.Count}";
        }

        private void ProcessCommand(ICommand command)
        {
            var location = new Location(StartOrLastLocation.X, StartOrLastLocation.Y);
            var steps = 1;
            while (command.NumberOfSteps != 0)
            {
                ILocation cleanedLocation;
                switch (command.Direction)
                {
                    case Direction.East:
                        cleanedLocation = new Location(location.X + steps, location.Y);
                        AddCleanedLocation(cleanedLocation);
                        break;
                    case Direction.West:
                        cleanedLocation = new Location(location.X - steps, location.Y);
                        AddCleanedLocation(cleanedLocation);
                        break;
                    case Direction.North:
                        cleanedLocation = new Location(location.X , location.Y + steps);
                        AddCleanedLocation(cleanedLocation);
                        break;
                    case Direction.South:
                        cleanedLocation = new Location(location.X, location.Y - steps);
                        AddCleanedLocation(cleanedLocation);
                        break;
                    case Direction.None:
                        cleanedLocation = new Location(location.X, location.Y);
                        AddCleanedLocation(cleanedLocation);
                        break;
                }
                steps++;
                command.NumberOfSteps--;
            }
        }

        private void AddCleanedLocation(ILocation location)
        {
            UniqueCleanedLocations.Add(location);
            StartOrLastLocation = location;
        }
    }
}
