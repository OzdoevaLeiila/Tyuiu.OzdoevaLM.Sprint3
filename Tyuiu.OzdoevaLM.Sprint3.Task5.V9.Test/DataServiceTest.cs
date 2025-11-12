using Tyuiu.OzdoevaLM.Sprint3.Task9.Lib;

namespace Tyuiu.OzdoevaLM.Sprint3.Task9.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 231.235;

            Assert.AreEqual(wait, res);
       
        }
    }
}
