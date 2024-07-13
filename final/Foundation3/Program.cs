using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Address address1 = new Address("175 Valley River", "Rexburg", "ID", "USA");
        Address address2 = new Address("145 Brooklyn Ave", "Brooklyn", "NY", "USA");
        Address address3 = new Address("789 Beach Rd", "Coastal City", "FL", "USA");

        Event lecture = new LectureEvent("Intership Talk", "A talk about intership", address1, "2024-07-09", "2:00 PM", "Joseph Smith", 250);
        Event reception = new ReceptionEvent("Professional Meet and Greet", "Newworking event for professionals", address2, "2024-07-11", "9:00 AM","contact@gmail.com");
        Event outdoorEvent = new OutdoorEvernt("Beach Party", "Girl's birthday party at the beach", address3, "2024-07-13", "3:oo PM", "Sunny and warm");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoorEvent);
    
    }
    public static void PrintEventDetails(Event EventItem)
    {
        Console.WriteLine(EventItem.GetStandarDetails());
        Console.WriteLine();
        Console.WriteLine(EventItem.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(EventItem.GetShortDescription());
        Console.WriteLine("-----------");
    }
}