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
            if (m_observers.Contains(observer) == false)
                m_observers.Add(observer);

            return new Janitor(() =>
            {
                if (m_observers.Contains(observer)) 
                    m_observers.Remove(observer);
            });
        }

        protected void Publish(T item)
        {
            m_observers.ForEach(sub => sub.OnNext(item));
        }
    }
}
