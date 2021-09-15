# SpriteFactoryProcessor
Importer / Proccessor for SpriteFactory

This uses MonoGame.Framework.Content.Pipeline for 3.8.0.1641 : https://www.nuget.org/packages/MonoGame.Framework.Content.Pipeline/

Before you start:
  1. For this to work, Change The namespace to your own namespace
  2. Edit "SpriteFactoryWriter" and change "GetRuntimeReader" + "GetRuntimeType" to your own namespace since its required to read the binary xmb file and being it back into an asset file.

Process in these steps:
  1. Make a class library or a dotnet core classlib
  2. Add these files to the library.
  3. Also Add the nuget package of Json.net.
  4. MAKE SURE: the library is set to .NETStandard 2.0 not net5.0, etc.
  5. Do the things in "Before you start"
  6. Build the classlib
  7. Add a refenece to your monogame content builder of json.net and this library
  8. Add the .sf files to your monogame content builder, make sure it shows spritefactory and build.

If you see "unknown" in monogame for .sf files and you have done the steps above. its because you set your own namespace wrong in "Before you start" section.
  
  Other Information:
    Reason why ".NETStandard 2.0" is required for the classlib is because curernt version of "MonoGame.Framework.Content.Pipeline" only works with net standard not with net5.0. IF you use a net5.0 or new versions, it will compile but inside the monogame content builder, it will fail.
    
