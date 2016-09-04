using Microsoft.Xna.Framework.Graphics;

namespace MonoGameWrappers.Wrappers
{
	public class Texture2DWrapper : Texture2D, ITexture2D
	{
		public Texture2DWrapper(GraphicsDevice graphicsDevice, int width, int height) :
			base(graphicsDevice, width, height)
		{ }

		public Texture2DWrapper(GraphicsDevice graphicsDevice, int width, int height, bool mipmap, SurfaceFormat format) :
			base(graphicsDevice, width, height, mipmap, format)
		{ }

		public Texture2DWrapper(GraphicsDevice graphicsDevice, int width, int height, bool mipmap, SurfaceFormat format, int arraySize) :
			base(graphicsDevice, width, height, mipmap, format, arraySize)
		{ }
	}
}
