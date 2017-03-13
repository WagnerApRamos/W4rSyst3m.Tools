namespace W4rSyst3m.Tools.TestUtilities.Attributes
{
    public class UnitTestAttribute : TestCategoryAttribute
    {
        public UnitTestAttribute() 
            : base(TestCategoryType.UnitTest)
        { }
    }
}
