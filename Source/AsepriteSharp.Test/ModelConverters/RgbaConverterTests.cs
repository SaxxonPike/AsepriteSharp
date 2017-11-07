using AsepriteSharp.ModelConverters;
using AsepriteSharp.Models;
using FluentAssertions;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace AsepriteSharp.Test.ModelConverters
{
    [TestFixture]
    public class RgbaConverterTests : BaseTest
    {
        [Test]
        public void Encode_EncodesRGBA()
        {
            // Arrange.
            var data = Factory.Create<Rgba>();

            // Act.
            var output = RgbaConverter.Encode(data);

            // Assert.
            output.Should().Be($"#{data.R:X2}{data.G:X2}{data.B:X2}{data.A:X2}");
        }
        
        [Theory]
        public void Decode_DecodesRGB(bool withHash)
        {
            // Arrange.
            var expected = Factory.Create<Rgba>();
            expected.A = 255;
            var data = (withHash ? "#" : "") + $"{expected.R:X2}{expected.G:X2}{expected.B:X2}";

            // Act.
            var output = RgbaConverter.Decode(data);

            // Assert.
            output.Should().Be(expected);
        }
        
        [Theory]
        public void Decode_DecodesRGBA(bool withHash)
        {
            // Arrange.
            var expected = Factory.Create<Rgba>();
            var data = (withHash ? "#" : "") + $"{expected.R:X2}{expected.G:X2}{expected.B:X2}{expected.A:X2}";

            // Act.
            var output = RgbaConverter.Decode(data);

            // Assert.
            output.Should().Be(expected);
        }
    }
}