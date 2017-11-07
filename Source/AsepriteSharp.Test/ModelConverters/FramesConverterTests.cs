using System.Collections.Generic;
using AsepriteSharp.ModelConverters;
using AsepriteSharp.Models;
using FluentAssertions;
using NUnit.Framework;

namespace AsepriteSharp.Test.ModelConverters
{
    [TestFixture]
    public class FramesConverterTests : BaseTest
    {
        [Test]
        public void Decode_ConvertsDictionaryToList()
        {
            // Arrange.
            var data = new Dictionary<string, Frame> {{"file0", new Frame()}, {"file1", new Frame()}};
            
            // Act.
            var output = FramesConverter.Decode(data);
            
            // Assert.
            output.ShouldAllBeEquivalentTo(data.Values);
            output[0].FileName.Should().Be("file0");
            output[1].FileName.Should().Be("file1");
        }
    }
}