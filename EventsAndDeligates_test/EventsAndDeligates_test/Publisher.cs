using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDeligates_test
{

    public class SomeObjectEventArgs : EventArgs
    {
        public SomeObject Title { get; set; }
    }


    public class Publisher
    {
        //1 - define a deligate
        //2 - define an event, based on that deligate
        //3 - raise the event

        //declare the delgate:
        //public delegate void PublishedEventHandler(object source, SomeObjectEventArgs args); 
        //define event:
        public event EventHandler<SomeObjectEventArgs> Published; //in case we need to send addtional data to event
      
        //public event EventHandler Published; // in case we don't need to send addtional data to event

        public void DoSomethingInPublisherClass(SomeObject someObject)
        {            
            Console.WriteLine("There is some work in  <DoSomethingInPublisherClass method>, please wait...");
            Thread.Sleep(3000);

            //raise the event:
            OnPublished(someObject);
        }

        //raise the event:
        protected virtual void OnPublished(SomeObject someObject)
        {
            if (Published != null)
            {
                Published(this,new SomeObjectEventArgs(){Title = someObject});
            }

        }
    }
}
