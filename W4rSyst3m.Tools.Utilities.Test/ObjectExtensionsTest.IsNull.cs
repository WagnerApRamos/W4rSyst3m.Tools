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
        public class ObjectExtensionsIsNullTest
        {
            [TestMethod, UnitTest]
            public void IsNull_Returns_True_When_An_Int_Value_Is_Null()
            {
                int? value = null;
                Assert.IsTrue(value.IsNull());
            }

            [TestMethod, UnitTest]
            public void IsNull_Returns_False_When_An_Int_Value_Is_Not_Null()
            {
                int? value = DataGenerator.Generate<int>();
                Assert.IsFalse(value.IsNull());
            }

            [TestMethod, UnitTest]
            public void IsNull_Returns_True_When_A_String_Value_Is_Null()
            {
                string value = null;
                Assert.IsTrue(value.IsNull());
            }

            [TestMethod, UnitTest]
            public void IsNull_Returns_False_When_A_String_Value_Is_Not_Null()
            {
                string value = DataGenerator.Generate<string>();
                Assert.IsFalse(value.IsNull());
            }

            [TestMethod, UnitTest]
            public void IsNull_Returns_True_When_A_DateTime_Value_Is_Null()
            {
                DateTime? value = null;
                Assert.IsTrue(value.IsNull());
            }

            [TestMethod, UnitTest]
            public void IsNull_Returns_False_When_A_DateTime_Value_Is_Not_Null()
            {
                DateTime? value = DataGenerator.Generate<DateTime>();
                Assert.IsFalse(value.IsNull());
            }
        }
    }
}
