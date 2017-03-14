#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace W4rSyst3m.Tools.TestUtilities
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public abstract class TestCategoryAttribute : TestCategoryBaseAttribute
    {
        public TestCategoryAttribute(
            TestCategoryType type) 
            : base()
        {
            Type = type;
        }

        public TestCategoryType Type { get; set; }

        public override IList<string> TestCategories
        {
            get
            {
                return new string[] { Type.ToString() }.ToList();
            }
        }
    }
}
