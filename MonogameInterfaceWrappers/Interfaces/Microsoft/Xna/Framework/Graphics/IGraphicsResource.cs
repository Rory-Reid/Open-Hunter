using System;

namespace Microsoft.Xna.Framework.Graphics
{
	public interface IGraphicsResource : IDisposable
	{
		GraphicsDevice GraphicsDevice { get; }
		bool IsDisposed { get; }
		string Name { get; set; }
		object Tag { get; set; }

		event EventHandler<EventArgs> Disposing;

		string ToString();
	}
}
