using System;

namespace Microsoft.Xna.Framework.Graphics
{
	public interface IGraphicsDevice : IDisposable
	{
		GraphicsAdapter Adapter { get; }
		BlendState BlendState { get; set; }
		DepthStencilState DepthStencilState { get; set; }
		DisplayMode DisplayMode { get; }
		GraphicsDeviceStatus GraphicsDeviceStatus { get; }
		GraphicsProfile GraphicsProfile { get; }
		IndexBuffer Indices { get; set; }
		bool IsContentLost { get; }
		bool IsDisposed { get; }
		/// <summary>
		/// The rendering information for debugging and profiling. The metrics are reset every frame after draw within <see cref="GraphicsDevice.Present"/>.
		/// </summary>
		GraphicsMetrics Metrics { get; set; }
		PresentationParameters PresentationParameters { get; }
		RasterizerState RasterizerState { get; set; }
		int RenderTargetCount { get; }
		bool ResourcesLost { get; set; }
		SamplerStateCollection SamplerStates { get; }
		Rectangle ScissorRectangle { get; set; }
		TextureCollection Textures { get; }
		SamplerStateCollection VertexSamplerStates { get; }
		TextureCollection VertexTextures { get; }
		Viewport Viewport { get; set; }

		event EventHandler<EventArgs> DeviceLost;
		event EventHandler<EventArgs> DeviceReset;
		event EventHandler<EventArgs> DeviceResetting;
		event EventHandler<EventArgs> Disposing;
		event EventHandler<ResourceCreatedEventArgs> ResourceCreated;
		event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;

		void Clear(Color color);
		void Clear(ClearOptions options, Color color, float depth, int stencil);
		void Clear(ClearOptions options, Vector4 color, float depth, int stencil);
		void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int startIndex, int primitiveCount);
		/// <summary>
		/// Draw geometry by indexing into the vertex buffer.
		/// </summary>
		/// <param name="primitiveType">The type of primitives in the index buffer.</param>
		/// <param name="baseVertex">Used to offset the vertex range indexed from the vertex buffer.</param>
		/// <param name="minVertexIndex">This is unused and remains here only for XNA API compatibility.</param>
		/// <param name="numVertices">This is unused and remains here only for XNA API compatibility.</param>
		/// <param name="startIndex">The index within the index buffer to start drawing from.</param>
		/// <param name="primitiveCount">The number of primitives to render from the index buffer.</param>
		/// <remarks>
		/// Note that <paramref name="minVertexIndex"/> and <paramref name="numVertices"/> are unused in MonoGame and will be ignored.
		/// </remarks>
		[Obsolete("Use DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int startIndex, int primitiveCount) instead. In future versions this method can be removed.")]
		void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount);
		void DrawInstancedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount, int instanceCount);
		void DrawPrimitives(PrimitiveType primitiveType, int vertexStart, int primitiveCount);
		void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType;
		void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType;
		void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct;
		void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct;
		void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount) where T : struct, IVertexType;
		void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct;
		RenderTargetBinding[] GetRenderTargets();
		void GetRenderTargets(RenderTargetBinding[] outTargets);
		void PlatformClear(ClearOptions options, Vector4 color, float depth, int stencil);
		void PlatformPresent();
		void Present();
		void SetRenderTarget(RenderTarget2D renderTarget);
		void SetRenderTarget(RenderTargetCube renderTarget, CubeMapFace cubeMapFace);
		void SetRenderTargets(params RenderTargetBinding[] renderTargets);
		void SetVertexBuffer(VertexBuffer vertexBuffer);
		void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset);
		void SetVertexBuffers(params VertexBufferBinding[] vertexBuffers);
	}
}
