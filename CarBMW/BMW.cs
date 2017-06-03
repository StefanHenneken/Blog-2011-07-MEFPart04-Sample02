using System;
using System.ComponentModel.Composition;
using CarContract;

namespace CarBMW
{
    [InheritedExport(typeof(ICarContract))]
    [ExportMetadata("Name", "BMW")]
    [ExportMetadata("Price", (uint)40000)]
    public class BMW : ICarBase
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
