using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Model;

internal class Customers
{
    public List<Customer> customers {  get; set; } //just a reference variable no list at this point

    public Customers() 
    { 
        customers = new List<Customer>(); // now there is an actual list
    }

    public Customer Authenticate(string username, string password)
    {
        var c = customers.Where(o => (o.UserName == username) && (o.Password == password));

        if(c.Count() > 0) 
        { 
            return c.First();
        }
        else
        {
            return null;
        }
    }
}
