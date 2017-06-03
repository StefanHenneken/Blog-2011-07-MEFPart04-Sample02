using System;
using CarContract;

namespace CarMercedes
{
    public class Mercedes : ICarBase
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
