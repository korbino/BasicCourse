using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDeligates_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var someObject = new SomeObject() {Title = "Object 1" };
            var publisher = new Publisher();
            var subscriber_01 = new Subscriber_01(); 
            var subscriber_02 = new Subscriber_02(); 

            //linking event from publisher with method from subscrriber.
            publisher.Published += subscriber_01.OnPublished;
            publisher.Published += subscriber_02.OnPublished;


            publisher.DoSomethingInPublisherClass(someObject);


            Console.ReadKey();
        }
    }


}
