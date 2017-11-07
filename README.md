# AsepriteSharp

An import layer for use with JSON+PNG files exported from [Aseprite](https://github.com/aseprite/aseprite).
Definitely check that project out to get a feel for one of the best pixel art programs available.

### Usage

```c#
var json = File.ReadAllText("path.to.json");
var converter = new SheetConverter();
var sheet = converter.Decode(json);
```

Now you can access the `sheet` object by using such things as `sheet.Meta.App` or `sheet.Frames.First().FileName`.
Go nuts.

### License

This work is published under the MIT license. The [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
library is referenced via Nuget in the project. At the time of this writing, the license for that is also MIT.
