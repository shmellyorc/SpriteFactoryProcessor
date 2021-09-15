using Microsoft.Xna.Framework.Content.Pipeline;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
    public class SpriteFactoryData
    {
        public SpriteFactory SpriteFactory { get; }
	    
	public ContentBuildLogger Logger { get; }

	public SpriteFactoryData(SpriteFactory spriteFactory, ContentBuildLogger logger)
	{
		SpriteFactory = spriteFactory;
		Logger = logger;
	}
    }
}
