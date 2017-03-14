#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using W4rSyst3m.Tools.TestUtilities.Common.Creators;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common.Tests.Creators
{
    public partial class BaseCreatorTest
    {
        [TestClass]
        public class BaseCreatorTestFixture :
            BaseCreator<TestClassCreator>
        { }

        public class TestClassCreator
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
        }

    }
}
