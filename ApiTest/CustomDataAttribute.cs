using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    internal class CustomDataAttribute : AutoDataAttribute
    {
        public CustomDataAttribute() : base(() =>
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new BookSpecimenBuilder());
            return fixture;
        })
        { }
    }
}
