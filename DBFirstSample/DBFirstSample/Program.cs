using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstSample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NORTHWINDEntities context = new NORTHWINDEntities();
            //var customerList = context.Customers.ToList();

            //foreach (var item in customerList)
            //{
            //    Console.WriteLine($"CustomerID : {item.CustomerID} - Company Name : {item.CompanyName}");
            //}
            //Console.ReadLine();

            //Customers customer = new Customers();
            //customer.CustomerID = "SAMCU";
            //customer.CompanyName = "Sample Customer";

            //context.Customers.Add(customer);

            //context.SaveChanges();

            //Console.ReadLine();

            //Customers customer = context.Customers.Find("SAMCU");
            //Console.WriteLine($"CustomerID : {customer.CustomerID} - Company Name : {customer.CompanyName}");
            //Console.ReadLine();


            //Customers customer = context.Customers.Find("SAMCU");
            //context.Customers.Remove(customer);
            //context.SaveChanges();

            //Customers customer = context.Customers.Find("SAMCU");
            //customer.CompanyName = "Update CUstomer";
            //context.SaveChanges();


        }
    }
}
