using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameWrappers.Wrappers
{
	public class GraphicsDeviceWrapper : IGraphicsDevice
	{
		private readonly GraphicsDevice wrapped;

		#region Constructors
		public GraphicsDeviceWrapper(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters)
		{
			this.wrapped = new GraphicsDevice(adapter, graphicsProfile, presentationParameters);
		}

		public GraphicsDeviceWrapper(GraphicsDevice objectToWrap)
		{
			this.wrapped = objectToWrap;
		}
		#endregion

		private void HookUpEvents()
		{
			this.wrapped.DeviceLost += (s, e) => this.DeviceLost(s, e);
			this.wrapped.DeviceReset += (s, e) => this.DeviceReset(s, e);
			this.wrapped.DeviceResetting += (s, e) => this.DeviceResetting(s, e);
			this.wrapped.Disposing += (s, e) => this.Disposing(s, e);
			this.wrapped.ResourceCreated += (s, e) => this.ResourceCreated(s, e);
			this.wrapped.ResourceDestroyed += (s, e) => this.ResourceDestroyed(s, e);
		}

		public event EventHandler<EventArgs> DeviceLost = delegate { };
		public event EventHandler<EventArgs> DeviceReset = delegate { };
		public event EventHandler<EventArgs> DeviceResetting = delegate { };
		public event EventHandler<EventArgs> Disposing = delegate { };
		public event EventHandler<ResourceCreatedEventArgs> ResourceCreated = delegate { };
		public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed = delegate { };

		public GraphicsAdapter Adapter
		{
			get { return this.wrapped.Adapter; }
		}

		public BlendState BlendState
		{
			get { return this.wrapped.BlendState; }
			set { this.wrapped.BlendState = value; }
		}

		public DepthStencilState DepthStencilState
		{
			get { return this.wrapped.DepthStencilState; }
			set { this.wrapped.DepthStencilState = value; }
		}

		public DisplayMode DisplayMode
		{
			get { return this.wrapped.DisplayMode; }
		}

		public GraphicsDeviceStatus GraphicsDeviceStatus
		{
			get { return this.wrapped.GraphicsDeviceStatus; }
		}

		public GraphicsProfile GraphicsProfile
		{
			get { return this.wrapped.GraphicsProfile; }
		}

		public IndexBuffer Indices
		{
			get { return this.wrapped.Indices; }
			set { this.wrapped.Indices = value; }
		}

		public bool IsContentLost
		{
			get { return this.wrapped.IsContentLost; }
		}

		public bool IsDisposed
		{
			get { return this.wrapped.IsDisposed; }
		}

		public GraphicsMetrics Metrics
		{
			get { return this.wrapped.Metrics; }
			set { this.wrapped.Metrics = value; }
		}

		public PresentationParameters PresentationParameters
		{
			get { return this.wrapped.PresentationParameters; }
		}

		public RasterizerState RasterizerState
		{
			get { return this.wrapped.RasterizerState; }
			set { this.wrapped.RasterizerState = value; }
		}

		public int RenderTargetCount
		{
			get { return this.wrapped.RenderTargetCount; }
		}

		public bool ResourcesLost
		{
			get { return this.wrapped.ResourcesLost; }
			set { this.wrapped.ResourcesLost = value; }
		}

		public SamplerStateCollection SamplerStates
		{
			get { return this.wrapped.SamplerStates; }
		}

		public Rectangle ScissorRectangle
		{
			get { return this.wrapped.ScissorRectangle; }
			set { this.wrapped.ScissorRectangle = value; }
		}

		public TextureCollection Textures
		{
			get { return this.wrapped.Textures; }
		}

		public SamplerStateCollection VertexSamplerStates
		{
			get { return this.wrapped.VertexSamplerStates; }
		}

		public TextureCollection VertexTextures
		{
			get { return this.wrapped.VertexTextures; }
		}

		public Viewport Viewport
		{
			get { return this.wrapped.Viewport; }
			set { this.wrapped.Viewport = value; }
		}

		public void Clear(Color color)
		{
			this.wrapped.Clear(color);
		}

		public void Clear(ClearOptions options, Color color, float depth, int stencil)
		{
			this.wrapped.Clear(options, color, depth, stencil);
		}

		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
			this.wrapped.Clear(options, color, depth, stencil);
		}

		public void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int startIndex, int primitiveCount)
		{
			this.wrapped.DrawIndexedPrimitives(primitiveType, baseVertex, startIndex, primitiveCount);
		}

		[Obsolete("Use DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int startIndex, int primitiveCount) instead. In future versions this method can be removed.")]
		public void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount)
		{
			this.wrapped.DrawIndexedPrimitives(primitiveType, baseVertex, minVertexIndex, numVertices, startIndex, primitiveCount);
		}

		public void DrawInstancedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount, int instanceCount)
		{
			this.wrapped.DrawInstancedPrimitives(primitiveType, baseVertex, minVertexIndex, numVertices, startIndex, primitiveCount, instanceCount);
		}

		public void DrawPrimitives(PrimitiveType primitiveType, int vertexStart, int primitiveCount)
		{
			this.wrapped.DrawPrimitives(primitiveType, vertexStart, primitiveCount);
		}

		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType
		{
			this.wrapped.DrawUserIndexedPrimitives(primitiveType, vertexData, vertexOffset, numVertices, indexData, indexOffset, primitiveCount);
		}

		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType
		{
			this.wrapped.DrawUserIndexedPrimitives(primitiveType, vertexData, vertexOffset, numVertices, indexData, indexOffset, primitiveCount);
		}

		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct
		{
			this.wrapped.DrawUserIndexedPrimitives(primitiveType, vertexData, vertexOffset, numVertices, indexData, indexOffset, primitiveCount, vertexDeclaration);
		}

		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct
		{
			this.wrapped.DrawUserIndexedPrimitives(primitiveType, vertexData, vertexOffset, numVertices, indexData, indexOffset, primitiveCount, vertexDeclaration);
		}

		public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount) where T : struct, IVertexType
		{
			this.wrapped.DrawUserPrimitives(primitiveType, vertexData, vertexOffset, primitiveCount);
	}

		public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct
		{
			this.wrapped.DrawUserPrimitives(primitiveType, vertexData, vertexOffset, primitiveCount, vertexDeclaration);
		}

		public RenderTargetBinding[] GetRenderTargets()
		{
			return this.wrapped.GetRenderTargets();
		}

		public void GetRenderTargets(RenderTargetBinding[] outTargets)
		{
			this.wrapped.GetRenderTargets(outTargets);
		}

		public void PlatformClear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
			this.wrapped.PlatformClear(options, color, depth, stencil);
		}

		public void PlatformPresent()
		{
			this.wrapped.PlatformPresent();
		}

		public void Present()
		{
			this.wrapped.Present();
		}

		public void SetRenderTarget(RenderTarget2D renderTarget)
		{
			this.wrapped.SetRenderTarget(renderTarget);
		}

		public void SetRenderTarget(RenderTargetCube renderTarget, CubeMapFace cubeMapFace)
		{
			this.wrapped.SetRenderTarget(renderTarget, cubeMapFace);
		}

		public void SetRenderTargets(params RenderTargetBinding[] renderTargets)
		{
			this.wrapped.SetRenderTargets(renderTargets);
		}

		public void SetVertexBuffer(VertexBuffer vertexBuffer)
		{
			this.wrapped.SetVertexBuffer(vertexBuffer);
		}

		public void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset)
		{
			this.wrapped.SetVertexBuffer(vertexBuffer, vertexOffset);
		}

		public void SetVertexBuffers(params VertexBufferBinding[] vertexBuffers)
		{
			this.wrapped.SetVertexBuffers(vertexBuffers);
		}

		public void Dispose()
		{
			this.wrapped.Dispose();
		}
	}
}
