using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Customer
    {
        public int id
        {
            get;
            set;

        }
        public string Name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;

        }
        public string Address
        {
            get;
            set;

        }

        private static bool getdata(Customer cust)
        {
            return cust.id == 102;

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> lscustomer = new List<Customer>()
            {

                new Customer { id = 101, Name = "Deepti", Gender = "Female", Address = "mms" },

                new Customer { id = 102, Name = "Raghav", Gender = "male", Address = "mdd" },
                new Customer { id = 103, Name = "Rohan", Gender = "male", Address = "mrwer" },
                new Customer { id = 104, Name = "Deeda", Gender = "Female", Address = "dsadass" },
            };
            Predicate<Customer> custPre = new Predicate<Customer>(getdata);
            Customer cust = lscustomer.Find(x => custPre(x));
            Console.WriteLine("id:{0},Name: {1},gender :{2},Address:{3}", cust.id, cust.Name, cust.Gender, cust.Address);


        }



        private static bool getdata(Customer cust)
        {
            return cust.id == 103;
            Console.ReadKey();

        }

    }
}
