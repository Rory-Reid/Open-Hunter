using Microsoft.Practices.Unity;
using Microsoft.Xna.Framework.Graphics;
using MonoGameWrappers.Wrappers;

namespace MonoGameWrappers.UnityModule
{
	/// <summary>
	/// A module for easily registering the <see cref="MonoGameWrappers"/> types with the <see cref="Microsoft.Practices.Unity"/> dependency injection framework
	/// </summary>
	public sealed class MonoGameWrappersUnityModule
	{
		private IUnityContainer container;

		public MonoGameWrappersUnityModule(IUnityContainer container)
		{
			this.container = container;
		}

		public void Initialise()
		{
			// MonoGame types
			this.container.RegisterType<ISpriteBatch, SpriteBatchWrapper>();

			// Wrapper utilities
			this.container.RegisterType<IWrapperFactory, WrapperFactory>();
		}
	}
}
