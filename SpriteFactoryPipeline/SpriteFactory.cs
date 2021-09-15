using System.Collections.Generic;
namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
    public class SpriteFactory
    {
        public SpriteFactoryAtlas TextureAtlas { get; set; }
		public Dictionary<string, SpriteFactoryCycle> Cycles { get; set; } =
			new Dictionary<string, SpriteFactoryCycle>();
    }
}