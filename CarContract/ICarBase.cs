using System;
using System.ComponentModel.Composition;

namespace CarContract
{
    [InheritedExport(typeof(ICarContract))]    
    [ExportMetadata("Name", "no name")]
    [ExportMetadata("Color", "no color")]
    public interface ICarBase : ICarContract {  }
}
