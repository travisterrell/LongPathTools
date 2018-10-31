# LongPathTools
Collection of C# methods used to provide long path equivalents for file manipulation methods.

Although having officially added support for long paths, .NET Framework does not have file methods which actually properly work with them. This is a collection of replacement methods that PInvoke the WIN32 API to provide support for common operations (delete, copy, exists, etc.)

Information on technique used: <br>
https://blogs.msdn.microsoft.com/bclteam/2007/02/13/long-paths-in-net-part-1-of-3-kim-hamilton/

PInvoke signature specifications: <br>
http://pinvoke.net/