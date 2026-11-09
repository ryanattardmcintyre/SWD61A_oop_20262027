using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_AbstractClasses
{
    public abstract class Notification
    {
        public Notification(string message)
        { 
            Message = message;
            Subscribers = new List<Subscriber>();
        }

        public List<Subscriber> Subscribers { get; set; }
        public string Message { get; set; }

        public void AddSubscriber(Subscriber s)
        {
            Subscribers.Add(s);

        }
        public void RemoveSubscriber(Subscriber s) {
            Subscribers.Remove(s);
        }
        public void RemoveSubscriber(int id)
        {
            /* int indexOfSubscriber = -1;
             for (int i = 0; i < Subscribers.Count; i++)
             {
                 if (Subscribers[i].Id == id)
                 { indexOfSubscriber = i; break; }
             }

             Subscribers.RemoveAt(indexOfSubscriber);
            */

            var subscriberToRemove = Subscribers.FirstOrDefault(x => x.Id == id);
            if (subscriberToRemove != null) Subscribers.Remove(subscriberToRemove);
        }

        public abstract void Send(Subscriber s);
        public void NotifySubscribers() {
            foreach (Subscriber s in Subscribers)
                Send(s);
        
        }
    }
}
