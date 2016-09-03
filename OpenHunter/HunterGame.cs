using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameWrappers;
using MonoGameWrappers.Wrappers;
using OpenHunter.GameCore;

namespace OpenHunter
{
	public class HunterGame : GameWrapper, IActiveGame
	{
		IMonoGameObjectFactory monoGameObjectFactory;
		IWrapperFactory wrapperFactory;
		IGameDirector gameDirector;

		IGraphicsDeviceManager graphics;
		ISpriteBatch spriteBatch;

		public HunterGame(
			IMonoGameObjectFactory monoGameObjectFactory,
			IWrapperFactory wrapperFactory,
			IGameDirector gameDirector,
			IMonoGameConfig monoGameConfig)
		{
			// Private references to dependencies
			this.monoGameObjectFactory = monoGameObjectFactory;
			this.wrapperFactory = wrapperFactory;
			this.gameDirector = gameDirector;

			// Initialisation
			monoGameConfig.SetActiveGame(this);
			graphics = monoGameObjectFactory.GetGraphicsDeviceManager();

			// Settings
			Content.RootDirectory = "Content";
		}

		public new IGraphicsDevice GraphicsDevice
		{
			get
			{
				return this.wrapperFactory.Wrap(base.GraphicsDevice);
			}
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			this.gameDirector.Initialise();

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = this.monoGameObjectFactory.GetSpriteBatch();

			this.gameDirector.LoadContent();
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			this.gameDirector.UnloadContent();
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="baseGameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime baseGameTime)
		{
			var gameTime = this.wrapperFactory.Wrap(baseGameTime);

			this.gameDirector.Update(gameTime);

			base.Update(baseGameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="baseGameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime baseGameTime)
		{
			// Wrap, so that all objects we call can rely on interfaces
			var gameTime = this.wrapperFactory.Wrap(baseGameTime);

			this.gameDirector.Draw(gameTime, this.GraphicsDevice);

			base.Draw(baseGameTime);
		}
	}
}
