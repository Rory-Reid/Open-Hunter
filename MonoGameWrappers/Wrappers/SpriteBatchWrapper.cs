using Microsoft.Xna.Framework.Graphics;

namespace MonoGameWrappers.Wrappers
{
	public class SpriteBatchWrapper : SpriteBatch, ISpriteBatch
	{
		public SpriteBatchWrapper(GraphicsDevice graphicsDevice) : base(graphicsDevice) { }
	}
}
