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
        private List<input_object> data;
        private List<IObserver<input_object>> observers; 

        public input_handler()
        {
            data = new List<input_object>();
            observers = new List<IObserver<input_object>>();
        }

        /// <summary>
        /// Inserts data into the input handler.
        /// </summary>
        /// <param name="input"></param>
        public void insert_kid(string input)
        {
            kid child = new kid(input);
            data.Add(child);
            sort_data();
            update();
        }

        //REMOVE THIS REDUNDANT CODE
        public void insert_vehicle(string input)
        {
            vehicle car = new vehicle(input);
            data.Add(car);
            sort_data();
            update();
        }

        public void sort_data()
        {
            data.Sort(delegate (input_object k1, input_object k2) { return k1.getName().CompareTo(k2.getName()); });
        }

        private void update()
        {
            foreach(var each in observers)
            {
                each.OnCompleted();
                foreach(var each2 in data)
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
                update();
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
