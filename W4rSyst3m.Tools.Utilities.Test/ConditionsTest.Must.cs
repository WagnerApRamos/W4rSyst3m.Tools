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
        public class ConditionsMustTest
        {
            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void Must_Throws_ArgumentException_When_Condition_Returns_False()
            {
                var value = 0;
                value.Must(c => c > 0, "Value must be greater then 0.");
            }

            [TestMethod, UnitTest]
            public void Must_Does_Not_Throw_ArgumentException_When_Condition_Returns_True()
            {
                var value = DataGenerator.Generate<int>();
                value.Must(c => c > 0, "Value must be greater then 0.");
            }
        }
    }
}
