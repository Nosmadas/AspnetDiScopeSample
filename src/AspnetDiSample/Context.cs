using System;
using System.Diagnostics;

namespace AspnetDiSample
{
    public class Context
    {
        private readonly Guid _name = Guid.NewGuid();

        public Context()
        {
            Trace.WriteLine($"Created { this.GetType().Name } : { _name.ToString() }");
        }
    }
}
