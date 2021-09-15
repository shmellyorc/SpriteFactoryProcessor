using Microsoft.Xna.Framework.Content.Pipeline;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
	[ContentProcessor(DisplayName = "Sprite Factory Processor")]
	public class SpriteFactoryProcessor : ContentProcessor<SpriteFactory, SpriteFactoryData>
	{
		public override SpriteFactoryData Process(SpriteFactory input, ContentProcessorContext context)
		{
			return new SpriteFactoryData(input, context.Logger);
		}
	}
}