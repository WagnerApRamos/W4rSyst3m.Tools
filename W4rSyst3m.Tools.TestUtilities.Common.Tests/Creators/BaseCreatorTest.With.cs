#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common.Tests.Creators
{
    public partial class BaseCreatorTest
    {
        [TestClass]
        public class BaseCreatorWithTest :
            BaseCreatorTestFixture
        {
            [TestMethod, UnitTest]
            public void With_Change_TestClassCreator_Id_To_0()
            {
                var oldValue = _entity.Id;

                With(c => c.Id = 0);

                Assert.AreNotEqual(oldValue, _entity.Id);
            }

            [TestMethod, UnitTest]
            public void With_Change_TestClassCreator_Name_To_Empty()
            {
                var oldValue = _entity.Name;

                With(c => c.Name = string.Empty);

                Assert.AreNotEqual(oldValue, _entity.Id);
            }

            [TestMethod, UnitTest]
            public void With_Change_TestClassCreator_DOB_To_Tomorrow()
            {
                var oldValue = _entity.Name;

                With(c => c.DOB = DateTime.Today.AddDays(1));

                Assert.AreNotEqual(oldValue, _entity.Id);
                Assert.IsTrue(DateTime.Now < _entity.DOB);
            }
        }
    }
}
