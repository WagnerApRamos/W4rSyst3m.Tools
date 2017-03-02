namespace W4rSyst3m.Tools.TestUtilities.Attributes
{
    public class TestOfUnitAttribute : CategoryOfTestAttribute
    {
        public TestOfUnitAttribute() 
            : base(CategoryOfTestType.UnitTest)
        { }
    }
}
