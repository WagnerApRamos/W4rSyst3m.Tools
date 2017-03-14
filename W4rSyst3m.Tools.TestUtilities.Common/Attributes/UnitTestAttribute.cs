namespace W4rSyst3m.Tools.TestUtilities
{
    public class UnitTestAttribute : TestCategoryAttribute
    {
        public UnitTestAttribute() 
            : base(TestCategoryType.UnitTest)
        { }
    }
}
