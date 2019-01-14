using System.Collections.Generic;
using AIRobotCleaner.Domain;
using AIRobotCleaner.Tests.Common;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Robot
{
    public class When_processing_robot_commands : When_initiazing_a_robot
    {
        private const int NumberofUniqueCleanedLocations = 4;

        private Establish _context = () =>
        {
            XCoordinate = 10;
            YCoordinate = 22;
            Commands = new List<ICommand>
            {
                new Command(Direction.East, 2),
                new Command(Direction.North, 1)
            };

            Setup();
        };

        private Because _because = () =>
        {
            RobotCleaner.Start();
        };

        private It Robot_should_cleaned_atleast_one_location = () =>
        {
            RobotCleaner.UniqueCleanedLocations.Count.ShouldBeGreaterThan(0);
        };

        private It Robot_should_cleaned_locations = () =>
        {
            RobotCleaner.UniqueCleanedLocations.Count.ShouldEqual(NumberofUniqueCleanedLocations);
        };

        private It Robot_should_generate_proper_output = () =>
        {
            RobotCleaner.DisplayResults().ShouldEqual($"Cleaned {NumberofUniqueCleanedLocations}");
        };
    }
}
