using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public abstract class Observable<T> : IObservable<T>
    {
        List<IObserver<T>> m_observers = new List<IObserver<T>>();

        public IDisposable Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }
    }
}
