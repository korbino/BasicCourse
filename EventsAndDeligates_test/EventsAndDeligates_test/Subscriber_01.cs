using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDeligates_test
{
   public class Subscriber_01
    {
        public void OnPublished(object source, SomeObjectEventArgs e)
        {
            Console.WriteLine("Message from Subscriber_01 class...." + e.Title.Title);
        }
    }
}
