using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataVectors;
namespace TestProjectVectors
{
    [TestClass]
    public class UnitTest1
    {

        public MagnitudandConstructor magnitudandConstructor = new MagnitudandConstructor();
        public double[] vect1 = new double[] { 2, 5, 3 };


        [TestMethod]
        public void TestMethodMagnitude()
        {
           double respuesta =  magnitudandConstructor.DetMagnitud(vect1);

            Assert.AreEqual(6.164, respuesta);
        }
    }
}
