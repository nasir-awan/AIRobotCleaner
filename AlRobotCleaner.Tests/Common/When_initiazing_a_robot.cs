using System.Collections.Generic;
using AIRobotCleaner.Domain;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Common
{
    public class When_initiazing_a_robot
    {
        protected static int XCoordinate ;
        protected static int YCoordinate ;
        protected static ILocation StartLocation;
        protected static IRobotCleaner RobotCleaner;
        protected static IList<ICommand> Commands;

        public When_initiazing_a_robot()
        {
            Commands = new List<ICommand>();
            Setup();
        }

        protected static void Setup()
        {
            StartLocation = new Domain.Location(XCoordinate, YCoordinate);
            RobotCleaner = new RobotCleaner(StartLocation, Commands);
        }

        private It Location_x_coordinate_should_be_set_properly = () =>
        {
            RobotCleaner.StartOrLastLocation.X.ShouldEqual(XCoordinate);
        };

        private It Location_y_coordinate_should_be_set_properly = () =>
        {
            RobotCleaner.StartOrLastLocation.Y.ShouldEqual(YCoordinate);
        };

        private It Number_of_commands_should_be_set_properly = () =>
        {
            RobotCleaner.Commands.Count.ShouldEqual(Commands.Count);
        };

        private It Robot_commands_should_be_set_properly = () =>
        {
            foreach (var command in RobotCleaner.Commands)
            {
               Commands.ShouldContain(command);
            }
        };
    }
}
