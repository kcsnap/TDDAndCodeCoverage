using Moq;

namespace TestProject1
{
    [TestClass]
    public class EdenredFunction_IsEven
    {
        EdenredFunctions erFunction;
        Mock<IEdenredMaths> _mockMath;

        [TestInitialize]
        public void Init()
        {
            // ARRANGE 
            _mockMath = new Mock<IEdenredMaths>();
            erFunction = new EdenredFunctions(_mockMath.Object);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(12)]
        public void EdenredMath_IsEven_WHENNumber2_THENReturnTrue(int number)
        {   
            // ACT
            var result = erFunction.IsEven(number);

            // ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(5)]
        public void EdenredMath_IsEven_WHENNumber3_THENReturnFalse(int number)
        {
            // ARRANGE
            _mockMath.Setup(m => m.Mod(number, 2)).Returns(1);

            // ACT
            var result = erFunction.IsEven(number);

            // ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EdenredMath_IsEven_WHENOneHundred_THENReturnFalse()
        {
            // ACT
            var result = erFunction.IsEven(100);

            // ASSERT
            Assert.IsFalse(result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            erFunction = null;
        }
    }
}