using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OpenHunter.GameCore
{
	public interface IGameDirector
	{
		void Initialise();
		void LoadContent();
		void UnloadContent();
		void Update(IGameTime gameTime);
		void Draw(IGameTime gameTime, IGraphicsDevice device);
	}
}
