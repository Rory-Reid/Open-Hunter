using Microsoft.Practices.Unity;
using Microsoft.Xna.Framework;
using MonoGameWrappers.UnityModule;
using OpenHunter.GameCore;
using OpenHunter.GameCore.UnityModule;

namespace OpenHunter.UnityModule
{
	/// <summary>
	/// Class that specifically sets up monogame with the Unity dependency injection framework
	/// </summary>
	public class MonoGameUnityConfig : IGameBootstrapper, IMonoGameConfig
	{
		private IUnityContainer Container { get; set; }

		public void Initialise()
		{
			this.Container = new UnityContainer();

			this.Container.RegisterInstance<IGameBootstrapper>(this);
			this.Container.RegisterInstance<IMonoGameConfig>(this);

			this.Container.RegisterType<IMonoGameObjectFactory, SpriteBatchFactory>();

			// Initialise all modules.
			this.Container.Resolve<MonoGameWrappersUnityModule>().Initialise();
			this.Container.Resolve<GameCoreUnityModule>().Initialise();
		}

		public IGame InstantiateGame<T>() where T : IGame
		{
			return this.Container.Resolve<T>();
		}

		/// <summary>
		/// Some of the objects that the gamme needs also need a reference back to the game. Ugh.
		/// This method sorts that out a bit, by registering the active game
		/// </summary>
		/// <param name="game">Reference to the currently active game</param>
		public void SetActiveGame(IActiveGame game)
		{
			this.Container.RegisterInstance(game);
			this.Container.RegisterInstance(game as Game);
			this.Container.RegisterType<IGraphicsDeviceManager, GraphicsDeviceManager>(new ContainerControlledLifetimeManager());
		}
	}
}
