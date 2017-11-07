using System;
using FluentAssertions;
using NUnit.Framework;

namespace AsepriteSharp.Test
{
    [TestFixture]
    public class SheetConverterTests : BaseTest<SheetConverter>
    {
        public override SheetConverter GetTestSubject()
        {
            return new SheetConverter();
        }

        [Test]
        public void Decode_DecodesJson()
        {
            // Arrange.
            var data = GetTextData("FullExport.json");
            
            // Act.
            Action output = () => Subject.Decode(data);
            
            // Assert.
            output.ShouldNotThrow();
        }
    }
}