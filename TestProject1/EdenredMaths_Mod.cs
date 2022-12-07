namespace TestProject1
{
    [TestClass]
    public class EdenredMaths_Mod
    {
        EdenredMaths math;

        [TestInitialize]
        public void Init()
        {
            math = new EdenredMaths();
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(100, 100, 0)]
        [DataRow(101, 101, 0)]
        [DataRow(1111, 1111, 0)]
        [DataRow(6, 4, 2)]
        [DataRow(7, 6, 1)]
        public void EdenredMaths_Mod_WHENSameNumber_THENReturnZero(int first, int second, int exp)
        {
            // ACT
            var result = math.Mod(first, second);

            // ASSERT
            Assert.AreEqual(exp, result);
        }
    }
}