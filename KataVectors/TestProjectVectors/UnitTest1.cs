using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataVectors;
namespace TestProjectVectors
{
    [TestClass]
    public class UnitTest1
    {

        public MagnitudandConstructor magnitudandConstructor = new MagnitudandConstructor();
        public double[] vect1 = new double[] { 2, 5, 3 };
        public double[] vect2 = new double[] { 2, 5, 3 };

        [TestMethod]
        public void TestMethodMagnitude()
        {
           double respuesta =  magnitudandConstructor.DetMagnitud(vect1);

            Assert.AreEqual(6.164, respuesta);
        }

        [TestMethod]
        public void DotProct()
        {
            double[] respuesta = DotProduct.dorProduct(vect1, vect2);
            double[] productanswer = new double[3] { 4, 25, 9 };

            for(int i = 0; i < 3; i++)
            {
                Assert.AreEqual(productanswer[i], respuesta[i]);
            }
        }

        [TestMethod]
        public void AngleBetweenTest()
        {
            double respuesta = AngleBetween.angle_between(vect1, vect2);

            Assert.AreEqual(1.000, respuesta);
        }

    }
}
