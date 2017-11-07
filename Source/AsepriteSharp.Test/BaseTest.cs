using NUnit.Framework;
using Ploeh.AutoFixture;

namespace AsepriteSharp.Test
{
    public abstract class BaseTest
    {
        protected Fixture Factory { get; private set; }

        [SetUp]
        public void SetupAutoFixture()
        {
            Factory = new Fixture();
            new SupportMutableValueTypesCustomization().Customize(Factory);
        }
    }

    public abstract class BaseTest<TSubject> : BaseTest
    {
        protected TSubject Subject { get; private set; }

        [SetUp]
        public abstract TSubject GetTestSubject();
    }
}