using System;

namespace AIRobotCleaner.Domain
{
    public interface ILocation: IComparable<ILocation>
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
