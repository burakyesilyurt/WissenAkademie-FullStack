using BusinessLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessLogicLayer
    {
        public List<Customer> Customers()
        {
            string query = "Select * From Customers";
            List<Customer> customers = new List<Customer>();

            DataAccessLayer dataLayer = new DataAccessLayer();

            SqlCommand cmd = dataLayer.ExecuteCommand(query);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                Customer customer = new Customer();
                customer.CustomerID = reader["CustomerID"].ToString();
                customer.CompanyName = reader["CompanyName"].ToString();
                customer.ContactTitle = reader["ContactTitle"].ToString();
                customer.ContactName = reader["ContactName"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.PostalCode = reader["PostalCode"].ToString();
                customer.Country = reader["Country"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Region = reader["Region"].ToString();
                customer.Fax = reader["Fax"].ToString();
                customer.City = reader["City"].ToString();

                if(!customers.Contains(customer))
                    customers.Add(customer);

            }
            dataLayer.CloseConnection(cmd.Connection);

            return customers;

        }
    }
}
