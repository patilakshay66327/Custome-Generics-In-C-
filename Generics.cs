using System;
using System.Collections;
using System.Collections.Generic;


namespace Assignments_on_Generics
{
    class Generics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are in main class.");

            GenericClass<Employee> employeeDetails = new GenericClass<Employee>();

            //***************************Setting up values to the collections*****************************//
            employeeDetails.Add(new Employee() { Name = "Akshay",EmployeeId = 123 });
            employeeDetails.Add(new Employee() { Name = "Ketan", EmployeeId = 548 });
            employeeDetails.Add(new Employee() { Name = "Swapnesh", EmployeeId = 954 });
            employeeDetails.Add(new Employee() { Name = "Bhushan", EmployeeId = 789 });



            //*******************Display th vslues through generic class************************************//
            for (int i = 0; i < employeeDetails.counter;i++)
            {
                Console.WriteLine(string.Format("Employee Having the name {0} has EmployeeId {1}", employeeDetails[i].Name, employeeDetails[i].EmployeeId));
                
            }



            //***********************Counting the numv=ber of the elements from collection*******************************//
            Console.WriteLine("\n The number of the elements into collection is without using property : "+employeeDetails.counter);
            int countInMain = employeeDetails.Count = employeeDetails.counter;
            Console.WriteLine("\n The number of the elements into the collections is using the property : "+countInMain);

          
            //************************Clear the values from collection*******************************//
            for (int j = 0; j < 4;j++)
            {
                employeeDetails.clear();
                if(employeeDetails.counter == 0)
                {
                    Console.WriteLine("\n Now your collection is empty.");
                }
            }
            //********************************************************//
            
            Console.ReadLine();
        }
    }

    class GenericClass<T> : IEnumerable<T>
    {
        private T[] itme = new T[20];
        public int counter = 0;

        public void Add(T item)
        {
            itme[counter] = item;
            counter++;
        }

        public int Count {
            get {return counter; }
            set {;}
        }


        public void clear()
        {
            if (counter >= 0)
            {
                counter--;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

       
        public T this[int index]
        {
            get
            {
                return itme[index];
            }
        }

    }

    //setting up and getting ups the values from one class to other

    class Employee
    {
        public String Name { get; set; }

        public int EmployeeId { get; set; }
    }

}
