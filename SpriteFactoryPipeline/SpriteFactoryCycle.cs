namespace StinkyEngine.Pipelines.SpriteFactoryPipeline
{
    public class SpriteFactoryCycle
    {
        public int[] Frames { get; set; }
	    
	public bool IsLooping { get; set; }
	    
	public float FrameDuration { get; set; }

	public SpriteFactoryCycle(bool isLooping, int[] frames, float frameDuration)
	{
		IsLooping = isLooping;
		Frames = frames;
		FrameDuration = frameDuration;
	}
    }
}
