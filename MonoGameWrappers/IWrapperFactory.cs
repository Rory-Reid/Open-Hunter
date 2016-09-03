using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameWrappers
{
	public interface IWrapperFactory
	{
		IGameTime Wrap(GameTime gameTime);
		IGraphicsDevice Wrap(GraphicsDevice device);
	}
}
