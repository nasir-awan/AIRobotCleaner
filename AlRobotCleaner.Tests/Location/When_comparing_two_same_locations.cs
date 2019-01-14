using AIRobotCleaner.Domain;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Location
{
    public class When_comparing_two_same_locations
    {
        private const int FirstLocationXCoordinate = 100;
        private const int FirstLocationYCoordinate = -500;
        private const int SecondLocationXCoordinate = 100;
        private const int SecondLocationYCoordinate = -500;
        private static ILocation _firstLocation;
        private static ILocation _secondLocation;
        private const int ExpectedOutput = 0;
        private static int _result;

        private Establish _context = () =>
        {
            _firstLocation = new Domain.Location(FirstLocationXCoordinate, FirstLocationYCoordinate);
            _secondLocation = new Domain.Location(SecondLocationXCoordinate, SecondLocationYCoordinate);
        };

        private Because _because = () =>
        {
            _result = _firstLocation.CompareTo(_secondLocation);
        };

        private It location_comparison_should_be_properly_generated = () => { ExpectedOutput.ShouldEqual(_result); };
    }
}
