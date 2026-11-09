// See https://aka.ms/new-console-template for more information


using Week4_AbstractClasses;
using Week4_AbstractClasses.Worksheet_AbstractClasses;

List<Subscriber> subscribers = new List<Subscriber>();
subscribers.Add(new Subscriber(1, "Joe", "joeborg@mcast.edu.mt", "+35679797979"));



Notification myEmailNotification = new EmailNotification("hello there", "hello message");
//Notification mySmsNotification = new SmsNotification("hello there", "hello message");
foreach (Subscriber subscriber in subscribers)
{
    myEmailNotification.Send(subscriber);
    //mySmsNotification.Send(subscriber);
}
