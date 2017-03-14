#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using W4rSyst3m.Tools.TestUtilities;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.Utilities.Test
{
    public partial class ObjectExtensionsTest
    {
        [TestClass]
        public class ObjectExtensionsGetCloneTest
        {
            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentNullException))]
            public void GetClone_Throws_ArgumentNullException_When_Enumerable_Argument_Is_Null()
            {
                ICollection<string> list = null;

                var clone = list.GetClone();
            }

            [TestMethod, UnitTest]
            public void GetClone_Returns_A_Copy_From_Enumerable_Argument()
            {
                ICollection<string> list = GetValues().ToList();

                var clone = list.GetClone();

                Assert.IsNotNull(clone);
                Assert.AreEqual(list.Count, clone.Count);
                Assert.AreNotSame(list, clone);

                for (int i = 0; i < list.Count; i++)
                {
                    Assert.AreEqual(list.ElementAt(i), clone.ElementAt(i));
                }
            }

            [TestMethod, UnitTest]
            [ExpectedException(typeof(ArgumentNullException))]
            public void GetClone_Throws_ArgumentNullException_When_Class_Argument_Is_Null()
            {
                Test list = null;

                var clone = list.GetClone();
            }

            [TestMethod, UnitTest]
            public void GetClone_Returns_A_Copy_From_Class_Argument()
            {
                var source = DataGenerator.Generate<Test>();

                var clone = source.GetClone();

                Assert.IsNotNull(clone);
                Assert.AreNotSame(source, clone);

                Assert.AreEqual(source.Id, clone.Id);
                Assert.AreEqual(source.Name, clone.Name);
                Assert.AreEqual(source.Date, clone.Date);
            }

            private IEnumerable<string> GetValues()
            {
                var max = DataGenerator.Next(10);

                for (int i = 0; i < max; i++)
                {
                    yield return DataGenerator.Generate<string>();
                }
            }

        }

        protected class Test
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
