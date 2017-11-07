using System.Collections.Generic;
using System.IO;
using System.Linq;
using AsepriteSharp.ModelConverters;
using AsepriteSharp.Models;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace AsepriteSharp.Test.ModelConverters
{
    [TestFixture]
    public class FramesJsonConverterTests : BaseTest<FramesJsonConverter>
    {
        private JsonSerializer _serializer;

        [SetUp]
        public void Setup()
        {
            _serializer = new JsonSerializer();
        }

        public override FramesJsonConverter GetTestSubject() => 
            new FramesJsonConverter();

        [Test]
        public void ReadJson_ReadsArray()
        {
            // Arrange.
            var names = Factory.CreateMany<string>().ToArray();
            var data = names.Select(n => new {filename = n}).ToArray();
            var str = JsonConvert.SerializeObject(data);
            var reader = new JsonTextReader(new StringReader(str));
            reader.Read();
            
            // Act.
            var output = (List<Frame>) Subject.ReadJson(reader, typeof(List<Frame>), null, _serializer);

            // Assert.
            output.Select(x => x.FileName).ShouldAllBeEquivalentTo(names);
        }
        
        [Test]
        public void ReadJson_ReadsHash()
        {
            // Arrange.
            var data = new {file0 = new { }, file1 = new { }};
            var str = JsonConvert.SerializeObject(data);
            var reader = new JsonTextReader(new StringReader(str));
            reader.Read();
            
            // Act.
            var output = (List<Frame>) Subject.ReadJson(reader, typeof(List<Frame>), null, _serializer);

            // Assert.
            output.Select(x => x.FileName).ShouldAllBeEquivalentTo(new[] {"file0", "file1"});
        }

        [Test]
        public void WriteJson_WritesArray()
        {
            // Arrange.
            var names = Factory.CreateMany<string>().ToArray();
            var data = names.Select(n => new Frame {FileName = n}).ToArray();
            var str = new StringWriter();
            var writer = new JsonTextWriter(str);
            
            // Act.
            Subject.WriteJson(writer, data, _serializer);
            writer.Flush();
            
            // Assert.
            str.ToString().Should().Be(JsonConvert.SerializeObject(data));
        }
    }
}