﻿using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Repositories
{
    public class CustomerRepository
    {
        public ICollection<CustomerDetails> GetCustomerDetails()
        {
            using (var context = new HMSDbContext())
            {
                return context.CustomerDetails.AsNoTracking().ToList();
            }
        }

        public ICollection<Customer> GetCustomers()
        {
            using (var context = new HMSDbContext())
            {
                return context.Customers.AsNoTracking().ToList();
            }
        }
        
        public ICollection<CustomerDetails> GetCustomerByCustomerDetailsId(int CustomerDetailsId)
		{
			using (var context = new HMSDbContext())
			{
				// Get customer by category id
                return context.CustomerDetails.Where(e => e.CustomerId == CustomerDetailsId).ToList();
			}
		}

        public void CreateUser(Customer customerObj)
        {
            using (var context = new HMSDbContext())
            {
                if (customerObj.CustomerId == 0)
                {
                    // Create
                    context.Customers.Add(customerObj);

                }
                else
                {
                    // Edit
                    var customerInDb = context.Customers.SingleOrDefault(p => p.CustomerId == customerObj.CustomerId);

                    customerInDb.CustomerEmail = customerObj.CustomerEmail;
                    customerInDb.CustomerPhoneNo = customerObj.CustomerPhoneNo;
                    customerInDb.CustomerAddress = customerObj.CustomerAddress;
                    customerInDb.CustomerCity = customerObj.CustomerCity;
                    customerInDb.Password = customerObj.Password;

                }
                context.SaveChanges();
            }
        }

        public Customer LoginUser(string Email, string Password)
        {
            using (HMSDbContext context = new HMSDbContext())
            {

               return context.Customers.Where(a => a.CustomerEmail.Equals(Email) && a.Password.Equals(Password)).FirstOrDefault();
                     
            }
        }

        public Customer GetUserByEmail(string Email)
        {
            using (HMSDbContext context = new HMSDbContext())
            {

                return context.Customers.Where(a => a.CustomerEmail.Equals(Email)).FirstOrDefault();

            }
        }
    }
}
