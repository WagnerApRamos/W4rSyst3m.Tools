#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class ConditionsTest
    {
        [TestClass]
        public class ConditionsNotNullOrEmptyOrEmptyTest
        {
            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void NotNullOrEmpty_Throws_ArgumentException_When_A_String_Argument_Is_Null()
            {
                string value = null;

                value.NotNullOrEmpty("value");
            }

            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void NotNullOrEmpty_Throws_ArgumentException_When_A_String_Argument_Is_Empty()
            {
                string value = string.Empty;

                value.NotNullOrEmpty("value");
            }

            [TestMethod, UnitTest]
            public void NotNullOrEmpty_Does_Not_Throw_ArgumentException_When_A_String_Argument_Is_Not_Null_Nor_Empty()
            {
                var value = DataGenerator.Generate<string>();
                value.NotNullOrEmpty("value");
            }

            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void NotNullOrEmpty_Throws_ArgumentException_When_A_Enumerable_Argument_Is_Null()
            {
                ICollection<string> value = null;

                value.NotNullOrEmpty("value");
            }

            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentException))]
            public void NotNullOrEmpty_Throws_ArgumentException_When_A_Enumerable_Argument_Is_Empty()
            {
                var value = new List<string>();

                value.NotNullOrEmpty("value");
            }

            [TestMethod, UnitTest]
            public void NotNullOrEmpty_Does_Not_Throw_ArgumentException_When_A_Enumerable_Argument_Is_Not_Null()
            {
                var value = new List<string>(new[] { DataGenerator.Generate<string>(), DataGenerator.Generate<string>(), DataGenerator.Generate<string>() });
                value.NotNullOrEmpty("value");
            }
        }
    }
}
