#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public abstract class CategoryOfTestAttribute : TestCategoryBaseAttribute
    {
        public CategoryOfTestAttribute(
            CategoryOfTestType type) 
            : base()
        {
            Type = type;
        }

        public CategoryOfTestType Type { get; set; }

        public override IList<string> TestCategories
        {
            get
            {
                return new string[] { Type.ToString() }.ToList();
            }
        }
    }
}
