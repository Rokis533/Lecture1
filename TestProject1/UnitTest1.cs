using System.Reflection;
using Testai;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetInitials_FormInitials_FormedCorrectly()
        {
            //Arange
            string name = "Rokas";
            string surname = "Slaboðevièius";

            //Act
            string result = Program.GetInitials(name, surname);

            //Assert
            Assert.Equal(result, "RS");
        }

        [Fact]
        public void TestPrivateMethod()
        {

            int result = MyClass.AddPublic(3, 4);

            Assert.Equal(7, result);

        }
    }
}