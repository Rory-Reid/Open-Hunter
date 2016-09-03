using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameWrappers.Wrappers;

namespace MonoGameWrappers
{
	public sealed class WrapperFactory : IWrapperFactory
	{
		public IGameTime Wrap(GameTime gameTime)
		{
			return new GameTimeWrapper(gameTime);
		}

		public IGraphicsDevice Wrap(GraphicsDevice device)
		{
			return new GraphicsDeviceWrapper(device);
		}
	}
}
