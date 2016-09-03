using Microsoft.Practices.Unity;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OpenHunter.GameCore;

namespace OpenHunter
{
	public class SpriteBatchFactory : IMonoGameObjectFactory
	{
		IUnityContainer container;

		public SpriteBatchFactory(IUnityContainer container)
		{
			this.container = container;
		}

		public ISpriteBatch GetSpriteBatch()
		{
			var activeGame = this.container.Resolve<Game>();

			return this.container.Resolve<ISpriteBatch>(new ParameterOverride("graphicsDevice", activeGame.GraphicsDevice));
		}

		public IGraphicsDeviceManager GetGraphicsDeviceManager()
		{
			return this.container.Resolve<IGraphicsDeviceManager>();
		}
	}
}
