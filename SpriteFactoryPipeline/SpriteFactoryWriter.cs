using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
	[ContentTypeWriter]
	public class SpriteFactoryWriter : ContentTypeWriter<SpriteFactoryData>
	{
		protected override void Write(ContentWriter output, SpriteFactoryData value)
		{
			var sf = value.SpriteFactory;

			output.Write(sf.TextureAtlas.Path);
			output.Write(sf.TextureAtlas.Width);
			output.Write(sf.TextureAtlas.Height);
			output.Write(sf.Cycles.Count);

			if(sf.Cycles.Count > 0)
			{
				foreach (var item in sf.Cycles)
				{
					output.Write(item.Key);
					output.Write(item.Value.IsLooping);
					output.Write(item.Value.FrameDuration);
					output.Write(item.Value.Frames.Length);

					if(item.Value.Frames.Length > 0)
					{
						foreach (var frame in item.Value.Frames)
							output.Write(frame);
					}
				}
			}
		}


		public override string GetRuntimeReader(TargetPlatform targetPlatform)
		{
			return "StinkyEngine.Pipelines.SpriteFactoryPipeline.SpriteFactoryReader, StinkyEngine";
		}

		public override string GetRuntimeType(TargetPlatform targetPlatform)
		{
			return "StinkyEngine.Pipelines.SpriteFactoryPipeline.SpriteFactory, StinkyEngine";
		}
	}
}