#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class EnumerableExtensionsTest
    {
        [TestClass]
        public class EnumerableExtensionsIsNotNullNorEmptyTest
        {
            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_False_When_A_Enumerable_Value_Is_Null()
            {
                ICollection<string> list = null;

                Assert.IsFalse(list.IsNotNullNorEmpty());
            }

            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_False_When_A_Enumerable_Value_Is_Empty()
            {
                var list = new List<string>();

                Assert.IsFalse(list.IsNotNullNorEmpty());
            }

            [TestMethod, UnitTest]
            public void IsNotNullNorEmpty_Returns_True_When_A_Enumerable_Value_Is_Not_Null_Nor_Empty()
            {
                var list = new List<string>(new[] { DataGenerator.Generate<string>(), DataGenerator.Generate<string>() });

                Assert.IsTrue(list.IsNotNullNorEmpty());
            }
        }
    }
}
