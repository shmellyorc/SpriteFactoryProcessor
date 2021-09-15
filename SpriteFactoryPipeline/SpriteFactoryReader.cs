using System.Linq;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
	public class SpriteFactoryReader : ContentTypeReader<SpriteFactory>
	{
		protected override SpriteFactory Read(ContentReader input, SpriteFactory existingInstance)
		{
			SpriteFactory sf = new SpriteFactory();

			string path = input.ReadString();
			int width = input.ReadInt32();
			int height = input.ReadInt32();
			int cycleLength = input.ReadInt32();

			if(cycleLength > 0)
			{
				for (var i = 0; i < cycleLength; i++)
				{
					string cycleName = input.ReadString();
					bool isLooping = input.ReadBoolean();
					float frameDuration = input.ReadSingle();
					int[] frames = new int[input.ReadInt32()];

					if(frames.Length > 0)
					{
						for (int x = 0; x < frames.Length; x++)
							frames[x] = input.ReadInt32();
					}

					sf.Cycles.Add(cycleName, new SpriteFactoryCycle(isLooping, frames, frameDuration));
				}
			}

			var texturePath = path.Split(new char[] { '.' }).First();
			var texture = 
				input.ContentManager.Load<Texture2D>(texturePath);

			sf.TextureAtlas = new SpriteFactoryAtlas
			{
				Path = path,
				Texture = texture,
				Width = width,
				Height = height
			};

			return sf;
		}
	}
}