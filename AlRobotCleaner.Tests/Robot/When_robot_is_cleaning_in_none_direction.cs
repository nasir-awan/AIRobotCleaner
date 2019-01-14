using System.Collections.Generic;
using AIRobotCleaner.Domain;
using AIRobotCleaner.Tests.Common;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Robot
{
    public class When_robot_is_cleaning_in_none_direction : When_initiazing_a_robot
    {
        private static ILocation _location;
        private static int _numberOfSteps;
        private const Direction RobotDirection = Direction.None;

        private Establish _context = () =>
        {
            XCoordinate = 50;
            YCoordinate = 100;
            _numberOfSteps = 12;

            Commands = new List<ICommand>
            {
                new Command(RobotDirection, _numberOfSteps)
            };

            _location = new Domain.Location(XCoordinate, YCoordinate);
            Setup();
        };

        private Because _because = () =>
        {
            RobotCleaner.Start();
        };

        private It Robot_last_location_x_coordinate_should_be_set_properly = () =>
        {
            RobotCleaner.StartOrLastLocation.X.ShouldEqual(_location.X);
        };

        private It Robot_last_location_y_coordinate_should_be_set_properly = () =>
        {
            RobotCleaner.StartOrLastLocation.Y.ShouldEqual(_location.Y);
        };
    }
}
