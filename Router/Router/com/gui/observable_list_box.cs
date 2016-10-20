using Router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace router.com.gui
{
    public class observable_list_box : ListBox, IObserver<input_object>
    {

        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<input_object> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            this.Items.Clear();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(input_object value)
        {
            this.Items.Add(value.getName());
        }
    }
}
