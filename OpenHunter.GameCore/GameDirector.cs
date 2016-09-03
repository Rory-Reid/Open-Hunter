using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using OpenHunter.GameCore.Maps;

namespace OpenHunter.GameCore
{
	/// <summary>
	/// The beef
	/// </summary>
	public class GameDirector : IGameDirector
	{
		public GameDirector(IMapGenerator mapGenerator)
		{
		}

		public void Initialise()
		{
			// TODO: Add your initialization logic here
		}

		public void LoadContent()
		{
			// TODO: use this.Content to load your game content here
		}

		public void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		public void Update(IGameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			{
				//this.Exit();
			}

			// TODO: Add your update logic here
		}

		public void Draw(IGameTime gameTime, IGraphicsDevice device)
		{
			device.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here
		}
	}
}
