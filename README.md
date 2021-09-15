# SpriteFactoryProcessor
Importer / Proccessor for SpriteFactory

This uses MonoGame.Framework.Content.Pipeline for 3.8.0.1641 : https://www.nuget.org/packages/MonoGame.Framework.Content.Pipeline/

1. For this to work, Change The namespace to your own namespace
2. Edit "SpriteFactoryWriter" and change "GetRuntimeReader" + "GetRuntimeType" to your own namespace since its required to read the binary xmb fuke and being it back into an asset file.

Done.
