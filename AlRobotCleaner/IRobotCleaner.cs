using System.Collections.Generic;

namespace AIRobotCleaner.Domain
{
    public interface IRobotCleaner
    {
        IList<ICommand> Commands { get; }
        ILocation StartOrLastLocation { get; }
        SortedSet<ILocation> UniqueCleanedLocations { get; }
        void Start();
        void Stop();
        string DisplayResults();
    }
}
