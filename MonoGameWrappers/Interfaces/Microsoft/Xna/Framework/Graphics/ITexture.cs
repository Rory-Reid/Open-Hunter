namespace Microsoft.Xna.Framework.Graphics
{
	public interface ITexture : IGraphicsResource
	{
		SurfaceFormat Format { get; }
		int LevelCount { get; }
	}
}
