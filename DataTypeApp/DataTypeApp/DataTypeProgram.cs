using System;

namespace DataTypeApp
{
    class DataTypeProgram
    {
        static void Main(string[] args)
        {
            String firstName = "Zomer";
            int age = 23;
            char middleInitial = 'L';
            double GWA = 1.75;
            bool isMale = true;
            
            Console.WriteLine(String.Format("First name: {0}\nAge: {1}\nMiddle initial: {2}\nGWA: {3}\nIs male? {4}",
                firstName, age, middleInitial, GWA, isMale));
        }
    }
}