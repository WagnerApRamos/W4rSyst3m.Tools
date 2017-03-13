namespace W4rSyst3m.Tools.TestUtilities
{
    public class IntegrationTestAttribute : TestCategoryAttribute
    {
        public IntegrationTestAttribute() 
            : base(TestCategoryType.IntegrationTest)
        { }
    }
}
