# TextEncoder
TextEncoder is a simplified TEI.2 text markup application that can be
used for automatic text tagging in preparation for simple text corpus. 
It is written in C# and requires .NET 4 to function.
The code is well commented and easy to read.
## Classes

The program has 3 additional classes that manage the workflow.
Their methods are called from Form1.cs class as most of program logic is in that class.

```csharp
SimpleTextSplitter.cs
XmlEncoder.cs
HeaderInformation.cs
```

First one has method that splits text into paragraphs with seprated sentences.

HeaderInformation.cs is a packer class for storing several string values in one object.

XmlEncoder.cs is responsible for all the magic.
## License
MIT
