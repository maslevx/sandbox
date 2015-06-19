using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Janitor : IDisposable
    {
        readonly Action Cleanup;

        public Janitor(Action dispose)
        {
            Cleanup = dispose;
        }

        void IDisposable.Dispose()
        {
            Cleanup();
        }
    }
}
