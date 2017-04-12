using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDeligates_test
{
    public class Subscriber_02
    {
        public void OnPublished(object obj, SomeObjectEventArgs args)
        {
            Console.WriteLine("Message from Subsciber_02 class...." + args.Title.Title);
        }
    }
}
