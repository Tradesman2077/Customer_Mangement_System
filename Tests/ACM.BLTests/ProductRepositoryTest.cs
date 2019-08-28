using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            //--Arrange

            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Sunflowers",
                Description = "Assorted sizes of 4 flowers",
                CurrentPrice = 15.96M,
                
             };
            //--Act
            var actual = productRepository.Retrieve(1);


            //--Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);


        }


       

    }
}
