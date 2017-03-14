#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    #region Enums

    public enum TestEnum
    {
        Zero = 0,
        One = 1,
        Two = 2
    }

    #endregion

    public partial class ConditionsTest
    {
        [TestClass]
        public class ConditionsIsEnumTest
        {
            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void IsEnum_Throws_ArgumentException_When_Argument_Is_Not_A_Enum()
            {
                var value = DataGenerator.Generate<string>();

                value.IsEnum();
            }

            [TestMethod, UnitTest]
            public void IsEnum_Does_Not_Throw_ArgumentException_When_Argument_Is_A_Enum()
            {
                var value = DataGenerator.Generate<TestEnum>();
                value.IsEnum();
            }
        }
    }
}
