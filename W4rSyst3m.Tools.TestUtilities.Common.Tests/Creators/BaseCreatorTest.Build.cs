#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common.Tests.Creators
{
    public partial class BaseCreatorTest
    {
        [TestClass]
        public class BaseCreatorCreateTest :
            BaseCreatorTestFixture
        {
            [TestMethod, UnitTest]
            public void Create_Returns_A_New_Instance_Of_TestClassCreator_When_T_Is_TestClassCreator()
            {
                var entity = Create();

                Assert.IsNotNull(_entity);
                Assert.IsInstanceOfType(_entity, typeof(TestClassCreator));
            }
        }
    }
}
