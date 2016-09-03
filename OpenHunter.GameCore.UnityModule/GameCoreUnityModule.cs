using Microsoft.Practices.Unity;
using OpenHunter.GameCore.Maps;

namespace OpenHunter.GameCore.UnityModule
{
	public class GameCoreUnityModule
	{
		private IUnityContainer container;

		public GameCoreUnityModule(IUnityContainer container)
		{
			this.container = container;
		}

		public void Initialise()
		{
			this.container.RegisterType<IGameDirector, GameDirector>();

			this.container.RegisterType<IMap, Map>();
			this.container.RegisterType<IMapTile, MapTile>();
			this.container.RegisterType<IMapGenerator, MapGenerator>();
		}
	}
}
