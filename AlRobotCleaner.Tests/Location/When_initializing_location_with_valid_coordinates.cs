using AIRobotCleaner.Domain;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Location
{
    public class When_initializing_location_with_valid_coordinates
    {
        private const int XCoordinate = 100;
        private const int YCoordinate = -500;
        private static ILocation _location;

        private Establish _context = () =>
        {
            _location = new Domain.Location(XCoordinate, YCoordinate);
        };

        private It x_coordinate_should_be_set_properly = () => { _location.X.ShouldEqual(XCoordinate); };
        private It y_coordinate_should_be_set_properly = () => { _location.Y.ShouldEqual(YCoordinate); };
    }
}
