namespace AIRobotCleaner.Domain
{
    public interface ICommand
    {
        Direction Direction { get; set; }
        int NumberOfSteps { get; set; }
    }
}
