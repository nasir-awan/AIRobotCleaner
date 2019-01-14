using System.Collections.Generic;
using AIRobotCleaner.Domain;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Robot
{
    public class When_initiazing_a_robot_cleaner
    {
        private const int XCoordinate = 100;
        private const int YCoordinate = 500;
        private static ILocation _startLocation;
        private static IRobotCleaner _robotCleaner;
        private static IList<ICommand> _commands;

        private Establish _context = () =>
        {
            _startLocation = new Domain.Location(XCoordinate, YCoordinate);
            _commands = new List<ICommand>
            {
                new Command(Direction.North, 35),
                new Command(Direction.South, 20)
            };
            _robotCleaner = new RobotCleaner(_startLocation, _commands);
        };

        private It Location_x_coordinate_should_be_set_properly = () =>
        {
            _robotCleaner.StartOrLastLocation.X.ShouldEqual(XCoordinate);
        };

        private It Location_y_coordinate_should_be_set_properly = () =>
        {
            _robotCleaner.StartOrLastLocation.Y.ShouldEqual(YCoordinate);
        };

        private It Number_of_commands_should_be_set_properly = () =>
        {
            _robotCleaner.Commands.Count.ShouldEqual(_commands.Count);
        };

        private It First_command__should_be_set_properly = () =>
        {
            _robotCleaner.Commands[0].Direction.ShouldEqual(_commands[0].Direction);
            _robotCleaner.Commands[0].NumberOfSteps.ShouldEqual(_commands[0].NumberOfSteps);
        };

        private It Second_command_should_be_set_properly = () =>
        {
            _robotCleaner.Commands[1].Direction.ShouldEqual(_commands[1].Direction);
            _robotCleaner.Commands[1].NumberOfSteps.ShouldEqual(_commands[1].NumberOfSteps);
        };
    }
}
