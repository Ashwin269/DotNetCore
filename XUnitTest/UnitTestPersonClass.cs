using DotNetCore.Models;
using Xunit;

namespace XUnitTest
{
    public class UnitTestPersonClass
    {
        [Fact]
        public void PersonClassSetValues()
        {
            int personId = 1;
            string firstName = "Ashwin";
            string lastName = "AnandaPadmanaban";
            Person person = new Person(1, "Ashwin", "AnandaPadmanaban");
            Assert.Equal(personId, person.personId);
            Assert.Equal(firstName, person.firstName);
            Assert.Equal(lastName, person.lastName);
        }
    }
}
