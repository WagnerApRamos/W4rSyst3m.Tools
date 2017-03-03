namespace W4rSyst3m.Tools.TestUtilities.Attributes
{
    public class AcceptanceTestAttribute : TestCategoryAttribute
    {
        public AcceptanceTestAttribute() 
            : base(TestCategoryType.AcceptanceTest)
        { }
    }
}
