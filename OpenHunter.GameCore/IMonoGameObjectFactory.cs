using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OpenHunter.GameCore
{
	public interface IMonoGameObjectFactory
	{
		ISpriteBatch GetSpriteBatch();

		IGraphicsDeviceManager GetGraphicsDeviceManager();
	}
}
