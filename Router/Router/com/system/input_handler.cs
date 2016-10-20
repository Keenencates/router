using router.com.gui;
using Router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace router.com.system
{
    public class input_handler : IObservable<input_object>
    {
        private List<kid> kid_data;
        private List<IObserver<input_object>> observers; 

        public input_handler()
        {
            kid_data = new List<kid>();
            observers = new List<IObserver<input_object>>();
        }

        /// <summary>
        /// Inserts data into the input handler.
        /// </summary>
        /// <param name="input"></param>
        public void insert_kid(string input)
        {
            kid child = new kid(input);
            kid_data.Add(child);
            update();
        }

        private void update()
        {
            foreach(var each in observers)
            {
                each.OnCompleted();

                foreach(var each2 in kid_data)
                {
                    each.OnNext(each2);
                }
            }
        }

        public IDisposable Subscribe(IObserver<input_object> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var each in kid_data)
                    observer.OnNext(each);
            }
            return new Unsubscriber<input_object>(observers, observer);
        }

        private class Unsubscriber<input_object> : IDisposable
        {
            private List<IObserver<input_object>> _observers;
            private IObserver<input_object> _observer;

            public Unsubscriber(List<IObserver<input_object>> observers, IObserver<input_object> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }
    }
}
