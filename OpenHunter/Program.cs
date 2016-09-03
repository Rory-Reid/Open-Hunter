using System;
using OpenHunter.GameCore;
using OpenHunter.UnityModule;

namespace OpenHunter
{
	/// <summary>
	/// The main class.
	/// </summary>
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Configure Unity & MonoGame
			var bootstrapper = CreateBootstrapper();
			bootstrapper.Initialise();

			using (var game = bootstrapper.InstantiateGame<HunterGame>())
			{
				game.Run();
			}
		}

		private static IGameBootstrapper CreateBootstrapper()
		{
			IGameBootstrapper bootstrapper;

			// Here we literally decide some of the fundemental underlying components. If we have to change a framework, it should only be in here?
			bootstrapper = new MonoGameUnityConfig();

			return bootstrapper;
		}
	}
}
