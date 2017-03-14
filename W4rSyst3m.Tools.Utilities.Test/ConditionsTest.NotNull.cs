#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class ConditionsTest
    {
        [TestClass]
        public class ConditionsNotNullTest
        {
            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void NotNull_Throws_ArgumentException_When_Argument_Is_Null()
            {
                string value = null;

                value.NotNull("value");
            }

            [TestMethod, UnitTest]
            public void NotNull_Does_Not_Throw_ArgumentException_When_Argument_Is_Not_Null()
            {
                var value = DataGenerator.Generate<string>();
                value.NotNull("value");
            }
        }
    }
}
