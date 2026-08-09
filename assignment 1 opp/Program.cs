using System;

namespace Assignment_1_oop
{
    internal class Program
    {
        static void Main()
        {

            //q1
            //a) once create the variable and the values stored in heap and the var1 in stack has the refrance of this valuea then creat acopy from the var1 to var2 here var2 has the same refrance of var1 after modified var2 has another refrence fot the new values wihtout any changes for var1 . Why ? . because it is from value type
            //b) once create the variable and the values stored in heap and the var1 in stack has the refrance of this valuea then creat acopy from the var1 to var2 here var2 has the same refrance of var1 after modified has var2 has thw same refrance with var1 has the refrence for the new values wihh changes for var1 . Why ? . because it is from refrance type


            //q2
            //a) 1.fields has a public access modifier    , 2.has not setter   , 3.has not getter
            //b) data becomes more secure && data is fully controlled &&  data is read and written via public prperties by setter and getter, preventing any illogical changes



            //q3 project

            DeliveryCenter center = new DeliveryCenter();

            Console.WriteLine("Enter Shipment 1 Data");

            Console.Write("Tracking Code: ");
            string code1 = Console.ReadLine();

            Console.Write("Description: ");
            string desc1 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, building1);

            Shipment shipment1 =
                new Shipment(code1, desc1, weight1, fee1, address1);

            Console.WriteLine(center.AddShipment(shipment1)
                ? "Shipment added successfully."
                : "Delivery center is full.");


            Console.WriteLine();
            Console.WriteLine("Enter Shipment 2 Data");

            Console.Write("Tracking Code: ");
            string code2 = Console.ReadLine();

            Console.Write("Description: ");
            string desc2 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building2 = int.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, building2);

            Shipment shipment2 =
                new Shipment(code2, desc2, weight2, fee2, address2);

            Console.WriteLine(center.AddShipment(shipment2)
                ? "Shipment added successfully."
                : "Delivery center is full.");


            Console.WriteLine();
            Console.WriteLine("Enter Shipment 3 Data");

            Console.Write("Tracking Code: ");
            string code3 = Console.ReadLine();

            Console.Write("Description: ");
            string desc3 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight3 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building3 = int.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, building3);

            Shipment shipment3 =
                new Shipment(code3, desc3, weight3, fee3, address3);

            Console.WriteLine(center.AddShipment(shipment3)
                ? "Shipment added successfully."
                : "Delivery center is full.");


            Console.WriteLine();
            Console.WriteLine("--- All Shipments ---");

            Console.WriteLine();
            center[0].PrintShipment();

            Console.WriteLine();
            center[1].PrintShipment();

            Console.WriteLine();
            center[2].PrintShipment();


            Console.WriteLine();
            Console.Write("Enter a tracking code to search: ");
            string search = Console.ReadLine();

            Shipment result = center[search];

            if (string.IsNullOrWhiteSpace(result.TrackingCode))
            {
                Console.WriteLine("Shipment not found.");
            }
            else
            {
                Console.WriteLine("Shipment found: "
                    + result.TrackingCode
                    + " - "
                    + result.Description);
            }


            Console.WriteLine();
            Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress original =
                new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress copy = original;

            copy.BuildingNumber = 20;
            copy.Street = "Makram Ebeid Street";

            Console.WriteLine("Original Address: "
                + original.GetFullAddress());

            Console.WriteLine("Copied Address: "
                + copy.GetFullAddress());

            Console.ReadKey();
        }
    }
}
