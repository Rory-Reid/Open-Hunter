using Microsoft.Xna.Framework;

namespace OpenHunter.GameCore
{
	public interface IGameBootstrapper
	{
		void Initialise();
		IGame InstantiateGame<T>() where T : IGame;
	}
}
