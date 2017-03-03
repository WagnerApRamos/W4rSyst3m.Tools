namespace W4rSyst3m.Tools.TestUtilities.Attributes
{
    public class IntegrationTestAttribute : TestCategoryAttribute
    {
        public IntegrationTestAttribute() 
            : base(TestCategoryType.IntegrationTest)
        { }
    }
}
