using Tyuiu.OzdoevaLM.Sprint3.Task7.V14.Lib;
namespace Tyuiu.OzdoevaLM.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] expected = new double[len];
            expected[0] = -9.10;
            expected[1] = 1.54;
            expected[2] = 292.77;
            expected[3] = -0.57;
            expected[4] = -0.35;
            expected[5] = 2.00;
            expected[6] = 4.35;
            expected[7] = 4.57;
            expected[8] = -288.77;
            expected[9] = 2.45;
            expected[10] = 13.10;

            double[] actual = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}