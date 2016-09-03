using System;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	public interface IGame : IDisposable
	{
		GameComponentCollection Components { get; }
		ContentManager Content { get; set; }
		GraphicsDevice GraphicsDevice { get; }
		TimeSpan InactiveSleepTime { get; set; }
		bool IsActive { get; }
		bool IsFixedTimeStep { get; set; }
		bool IsMouseVisible { get; set; }
		LaunchParameters LaunchParameters { get; }
		/// <summary>
		/// The maximum amount of time we will frameskip over and only perform Update calls with no Draw calls. MonoGame extension.
		/// </summary>
		TimeSpan MaxElapsedTime { get; set; }
		GameServiceContainer Services { get; }
		TimeSpan TargetElapsedTime { get; set; }
		GameWindow Window { get; }

		event EventHandler<EventArgs> Activated;
		event EventHandler<EventArgs> Deactivated;
		event EventHandler<EventArgs> Disposed;
		event EventHandler<EventArgs> Exiting;

		void Exit();
		void ResetElapsedTime();
		void Run();
		void Run(GameRunBehavior runBehavior);
		void RunOneFrame();
		void SuppressDraw();
		void Tick();
	}
}
