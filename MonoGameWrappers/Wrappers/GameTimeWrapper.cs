using System;
using Microsoft.Xna.Framework;

namespace MonoGameWrappers.Wrappers
{
	public class GameTimeWrapper : IGameTime
	{
		private readonly GameTime wrapped;

		#region Constructors

		public GameTimeWrapper()
		{
			this.wrapped = new GameTime();
		}

		public GameTimeWrapper(TimeSpan totalGameTime, TimeSpan elapsedGameTime)
		{
			this.wrapped = new GameTime(totalGameTime, elapsedGameTime);
		}

		public GameTimeWrapper(TimeSpan totalRealTime, TimeSpan elapsedRealTime, bool isRunningSlowly)
		{
			this.wrapped = new GameTime(totalRealTime, elapsedRealTime, isRunningSlowly);
		}

		public GameTimeWrapper(GameTime objectToWrap)
		{
			this.wrapped = objectToWrap;
		}

		#endregion

		public TimeSpan ElapsedGameTime
		{
			get { return this.wrapped.ElapsedGameTime; }
			set { this.wrapped.ElapsedGameTime = value; }
		}

		public bool IsRunningSlowly
		{
			get { return this.wrapped.IsRunningSlowly; }
			set { this.wrapped.IsRunningSlowly = value; }
		}

		public TimeSpan TotalGameTime
		{
			get { return this.wrapped.TotalGameTime; }
			set { this.wrapped.TotalGameTime = value; }
		}
	}
}
