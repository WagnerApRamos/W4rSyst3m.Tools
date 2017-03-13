namespace W4rSyst3m.Tools.TestUtilities
{
    public class AcceptanceTestAttribute : TestCategoryAttribute
    {
        public AcceptanceTestAttribute() 
            : base(TestCategoryType.AcceptanceTest)
        { }
    }
}
