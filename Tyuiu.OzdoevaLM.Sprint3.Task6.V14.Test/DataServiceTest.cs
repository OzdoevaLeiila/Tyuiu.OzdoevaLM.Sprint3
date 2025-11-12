using Tyuiu.OzdoevaLM.Sprint3.Task6.V14.Lib;
namespace Tyuiu.OzdoevaLM.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 7;
            int stopValue = 16;
            
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}