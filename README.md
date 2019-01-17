# LongPathTools
######C# library used to provide long path equivalents for common file manipulation methods.

Although both Windows and .NET Framework *technically* support long paths (>260 characters), .NET Framework still does not currently have any file methods which actually work with them. This is a collection of replacement methods that PInvoke the WIN32 API to provide support for common operations (delete, copy, exists, etc.)

###Further Information
Technique used: <br>
https://blogs.msdn.microsoft.com/bclteam/2007/02/13/long-paths-in-net-part-1-of-3-kim-hamilton/

PInvoke signature specifications: <br>
http://pinvoke.net/

###Regarding Windows Support
While Windows does support long paths, they *must* [first be enabled](https://betanews.com/2016/05/29/long-paths-windows-10/) via Group Policy or the Registry Editor. Even after doing so, in order to use them, applications have to be coded to support them. For example, in Windows Explorer you are able to view the paths, but may encounter problems when attempting to delete files. There are [other file management tools](http://onecommander.com/) which can be used if files must be manually manipulated. The good news is that, using this library, *your* application will be able to handle them just fine.
