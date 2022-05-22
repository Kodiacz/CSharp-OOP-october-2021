using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IDriveable
    {
        public void Drive(double distance);
        public void Refuel(double fuel);
    }
}
