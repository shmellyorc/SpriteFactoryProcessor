using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json;

namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
	[ContentImporter(".sf", DefaultProcessor = "SpriteFactoryProcessor", DisplayName = "Sprite Factory Importer")]
    public class SpriteFactoryImporter : ContentImporter<SpriteFactory>
    {
        public override SpriteFactory Import(string filename, ContentImporterContext context)
		{
			context.Logger.LogMessage($"Importing Sprite Factory: {filename}");

			var data = File.ReadAllText(filename);
			return JsonConvert.DeserializeObject<SpriteFactory>(data);
		}
    }
}

		