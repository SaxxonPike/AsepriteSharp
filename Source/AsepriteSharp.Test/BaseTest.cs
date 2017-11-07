using System.IO;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace AsepriteSharp.Test
{
    public abstract class BaseTest
    {
        protected Fixture Factory { get; private set; }

        [SetUp]
        public void __SetupAutoFixture()
        {
            Factory = new Fixture();
            new SupportMutableValueTypesCustomization().Customize(Factory);
        }

        public string GetTextData(string name)
        {
            using (var stream = GetType().Assembly.GetManifestResourceStream($"AsepriteSharp.Test.TestData.{name}"))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }            
        }
    }

    public abstract class BaseTest<TSubject> : BaseTest
    {
        protected TSubject Subject { get; private set; }

        [SetUp]
        public void __SetupTestSubject()
        {
            Subject = GetTestSubject();
        }
        
        public abstract TSubject GetTestSubject();
    }
}