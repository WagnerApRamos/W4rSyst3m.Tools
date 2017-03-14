#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class ObjectExtensionsTest
    {
        [TestClass]
        public class ObjectExtensionsIsNotNullTest
        {
            [TestMethod, UnitTest]
            public void IsNotNull_Returns_False_When_An_Int_Value_Is_Null()
            {
                int? value = null;
                Assert.IsFalse(value.IsNotNull());
            }

            [TestMethod, UnitTest]
            public void IsNotNull_Returns_True_When_An_Int_Value_Is_Not_Null()
            {
                int? value = DataGenerator.Generate<int>();
                Assert.IsTrue(value.IsNotNull());
            }

            [TestMethod, UnitTest]
            public void IsNotNull_Returns_False_When_A_String_Value_Is_Null()
            {
                string value = null;
                Assert.IsFalse(value.IsNotNull());
            }

            [TestMethod, UnitTest]
            public void IsNotNull_Returns_True_When_A_String_Value_Is_Not_Null()
            {
                string value = DataGenerator.Generate<string>();
                Assert.IsTrue(value.IsNotNull());
            }

            [TestMethod, UnitTest]
            public void IsNotNull_Returns_False_When_A_DateTime_Value_Is_Null()
            {
                DateTime? value = null;
                Assert.IsFalse(value.IsNotNull());
            }

            [TestMethod, UnitTest]
            public void IsNotNull_Returns_True_When_A_DateTime_Value_Is_Not_Null()
            {
                DateTime? value = DataGenerator.Generate<DateTime>();
                Assert.IsTrue(value.IsNotNull());
            }
        }
    }
}
