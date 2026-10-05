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



        }
    }
}



            
