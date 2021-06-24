using DotNet_Phase3_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Phase3_Project.Services
{
    public class MockProductRepo : IRepo<Product>
    {
        public bool Add(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}