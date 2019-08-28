using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Bilbo ,Baggins";

            //--Act
            string actual = customer.FullName;
             
            //--Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameFirstEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameLastEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                
            };
            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer();
            customer.EmailAddress = "Bilbo@aol.com";
            customer.LastName = "Baggins";


            //--Arrange
            var expected = true;

            //--Act
            var actual = customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
