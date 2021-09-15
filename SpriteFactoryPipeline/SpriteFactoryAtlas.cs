using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
    public class SpriteFactoryAtlas
    {
	[JsonProperty(PropertyName = "Texture")]
        public string Path { get; set; }

	[JsonIgnore]
	public Texture2D Texture { get; set; }

	[JsonProperty(PropertyName = "regionWidth")]
	public int Width { get; set; }

	[JsonProperty(PropertyName = "regionHeight")]
	public int Height { get; set; }
    }
}
