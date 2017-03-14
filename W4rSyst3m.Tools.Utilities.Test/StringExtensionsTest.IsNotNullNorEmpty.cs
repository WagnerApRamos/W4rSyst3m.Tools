#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class StringExtensionsTest
    {
        [TestClass]
        public class StringExtensionsIsNotNullNorEmptyTest
        {
            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_False_When_String_Value_Is_Null()
            {
                string value = null;
                Assert.IsFalse(value.IsNotNullNorEmpty());
            }

            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_False_When_String_Value_Is_Empty()
            {
                string value = string.Empty;
                Assert.IsFalse(value.IsNotNullNorEmpty());
            }

            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_True_When_String_Value_Is_Not_Null_Nor_Empty()
            {
                string value = DataGenerator.Generate<string>();
                Assert.IsTrue(value.IsNotNullNorEmpty());
            }
        }
    }
}
