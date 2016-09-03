using System;

namespace Microsoft.Xna.Framework
{
	public interface IGameTime
	{
		TimeSpan ElapsedGameTime { get; set; }
		bool IsRunningSlowly { get; set; }
		TimeSpan TotalGameTime { get; set; }
	}
}
