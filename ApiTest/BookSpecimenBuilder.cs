using ApiWithDatabase;
using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    public class BookSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is Type type && type == typeof(Book))
            {
                return new Book { Id = Guid.NewGuid(), Name = "Harry Potter" };
            }
            return new NoSpecimen();

        }
    }
}
