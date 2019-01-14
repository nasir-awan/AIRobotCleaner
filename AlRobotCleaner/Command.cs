namespace AIRobotCleaner.Domain
{
    public class Command : ICommand
    {
        public Direction Direction { get; set; }
        public int NumberOfSteps { get; set; }

        public Command(Direction direction, int numberOfSteps)
        {
            Direction = direction;
            NumberOfSteps = numberOfSteps;
        }
    }
}
