#region

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common.Tests
{
    #region Intrastructure

    public enum TestEnum
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    public class TestClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    #endregion

    public partial class DataGeneratorTest
    {
        [TestClass]
        public class DataGeneratorGenerateTest
        {
            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_String_When_T_Is_String()
            {
                var value = DataGenerator.Generate<string>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(string));
                Assert.AreNotEqual(string.Empty, value);
                Assert.IsTrue(value.Length > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Guid_When_T_Is_Guid()
            {
                var value = DataGenerator.Generate<Guid>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(Guid));
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Int_When_T_Is_Int()
            {
                var value = DataGenerator.Generate<int>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(int));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Long_When_T_Is_Long()
            {
                var value = DataGenerator.Generate<long>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(long));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Bool_When_T_Is_Bool()
            {
                var value = DataGenerator.Generate<bool>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(bool));
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Decimal_When_T_Is_Decimal()
            {
                var value = DataGenerator.Generate<decimal>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(decimal));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Double_When_T_Is_Double()
            {
                var value = DataGenerator.Generate<double>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(double));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Byte_When_T_Is_Byte()
            {
                var value = DataGenerator.Generate<byte>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(byte));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Short_When_T_Is_Short()
            {
                var value = DataGenerator.Generate<short>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(short));
                Assert.IsTrue(value > 0);
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_DateTime_When_T_Is_DateTime()
            {
                var value = DataGenerator.Generate<DateTime>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(DateTime));
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_Enum_When_T_Is_Enum()
            {
                var value = DataGenerator.Generate<TestEnum>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(TestEnum));
            }

            [TestMethod, UnitTest]
            public void Generate_Returns_A_Random_TestClass_When_T_Is_TestClass()
            {
                var value = DataGenerator.Generate<TestClass>();

                Assert.IsNotNull(value);
                Assert.IsInstanceOfType(value, typeof(TestClass));
                Assert.IsNotNull(value.Name);
            }
        }
    }
}
