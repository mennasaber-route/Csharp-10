namespace Assignment_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // *******   OOP 03 – Smart Delivery Management System after Sealed classes , Methods **********
            //    Part 01 : Theoretical Questions   //

            #region  Question 1

            //a)  What is the difference between Method Overloading and Method Overriding?
            // Allows a class to have multiple methods with the same name but different Parameters.
            // Method Overriding Allows a derived class to provide a specific implementation of a method that is already defined in its base class.



            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static Binding occurs at compile time, where the method to be called is determined based on the reference type.
            // Dynamic Binding occurs at runtime, where the method to be called is determined based on the actual object type.

            #endregion

            #region  Question 2

            //  a)  What is the purpose of the sealed keyword when applied to a class?
            // The sealed keyword is used to prevent a class from being inherited.


            //b)  What is the difference between a sealed class and a sealed method?
            // A sealed class cannot be inherited, while a sealed method can be overridden in derived classes and prevent derived classes to make this method be overridden again.

            //c)  Can a sealed method be overridden? Why?
            // No, a sealed method cannot be overridden because it is a final
            // that the purpose of sealing a method is to prevent further overriding of inheritance.

            #endregion


            #region Question Part 02 : Practical
            //   Part 02 : Practical   //

            Driver driver = new Driver("Ahmed Mohamed");

            DeliveryCenter driverCenter = new DeliveryCenter("Ali");

            driverCenter.AssignedDriver = driver;

            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Nasr City", 10);

            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3, 80, address1);

            ExpressShipment expressShipment = new ExpressShipment("EX001", "Smartphone", 1, 50, address1, 2);

            InternationalShipment internationalShipment = new InternationalShipment("INT001", "Tablet", 2, 100, address1, "USA", 100);

            driverCenter.AddShipment(standardShipment);
            driverCenter.AddShipment(expressShipment);
            driverCenter.AddShipment(internationalShipment);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Driver : {driverCenter.AssignedDriver.Name}");


            driverCenter.PrintAllShipments();


            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper");

            DeliveryHelper.PrintShipmentDetails(standardShipment);
            Console.WriteLine("Standard Shipment Printed Successfully.");
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            Console.WriteLine("Express Shipment Printed Successfully.");
            DeliveryHelper.PrintShipmentDetails(internationalShipment);
            Console.WriteLine("International Shipment Printed Successfully.");


            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight...");

            Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");
            standardShipment.UpdateWeight(5);
            Console.WriteLine(
                $"Updated Weight : {standardShipment.Weight} KG"
            );

            expressShipment.UpdateWeight(2, 0.5);
            Console.WriteLine(
                $"Updated Weight After Packing : {standardShipment.Weight} KG"
            );

            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using Shipment[]");

            Shipment[] shipments =
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] is StandardShipment)
                {
                    Console.WriteLine("Standard Shipment...");
                }
                else if (shipments[i] is ExpressShipment)
                {
                    Console.WriteLine("Express Shipment...");
                }
                else if (shipments[i] is InternationalShipment)
                {
                    Console.WriteLine("International Shipment...");
                }
            }

            Console.WriteLine("================================================");



            CompletedShipment completedShipment =
                new CompletedShipment(
                    "SH004",
                    "Completed Package",
                    4,
                    70,
                    address1);


            PriorityInternationalShipment
                priorityShipment =
                new PriorityInternationalShipment(
                    "SH005",
                    "Priority Package",
                    6,
                    150,
                    address1,
                    "France",
                    120);
        }
    }
}
            #endregion


            
