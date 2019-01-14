using AIRobotCleaner.Domain;
using Machine.Specifications;

namespace AIRobotCleaner.Tests.Commands
{
    public class When_initializing_a_command
    {
        private const Direction Direction = Domain.Direction.East;
        private const int NumberOfSteps = 25;
        private static ICommand _command;

        private Establish _context = () => { _command = new Command(Direction, NumberOfSteps); };

        private It Command_direction_should_be_set_properly = () => { _command.Direction.ShouldEqual(Direction); };
        private It Command_steps_should_be_set_properly = () => { _command.NumberOfSteps.ShouldEqual(NumberOfSteps); };
    }
}
