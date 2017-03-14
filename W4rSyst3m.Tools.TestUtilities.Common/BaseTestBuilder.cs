namespace W4rSyst3m.Tools.TestUtilities.Common
{
    public abstract class BaseTestBuilder
    {

        protected int GetRand(int min, int max)
        {
            return DataGenerator.GetRand().Next(min, max);
        }

        protected int GetRand(int max)
        {
            return DataGenerator.Next(max);
        }

    }
}
