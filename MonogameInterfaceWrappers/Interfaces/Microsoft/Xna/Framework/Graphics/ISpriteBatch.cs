using System;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
	public interface ISpriteBatch : IGraphicsResource
	{
		/// <summary>
		/// Begins a new sprite and text batch with the specified render state.
		/// </summary>
		/// <param name="sortMode">The drawing order for sprite and text drawing. <see cref="SpriteSortMode.Deferred"/> by default.</param>
		/// <param name="blendState">State of the blending. Uses <see cref="BlendState.AlphaBlend"/> if <see cref="null"/>.</param>
		/// <param name="samplerState">State of the sampler. Uses <see cref="SamplerState.LinearClamp"/> if <see cref="null"/>.</param>
		/// <param name="depthStencilState">State of the depth-stencil buffer. Uses <see cref="DepthStencilState.None"/> if <see cref="null"/>.</param>
		/// <param name="rasterizerState">State of the rasterization. Uses <see cref="RasterizerState.CullCounterClockwise"/> if <see cref="null"/>.</param>
		/// <param name="effect">A custom <see cref="Effect"/> to override the default sprite effect. Uses default sprite effect if <see cref="null"/>.</param>
		/// <param name="transformMatrix">An optional matrix used to transform the sprite geometry. Uses <see cref="Matrix.Identity"/> if <see cref="null"/>.</param>
		/// <exception cref="InvalidOperationException">Thrown if <see cref="SpriteBatch.Begin(SpriteSortMode, BlendState, SamplerState, DepthStencilState, RasterizerState, Effect, Matrix?)"/> is called next time without previous Microsoft.Xna.Framework.Graphics.SpriteBatch.End.</exception>
		/// <remarks>
		/// This method uses optional parameters.
		/// </remarks>
		void Begin(
			SpriteSortMode sortMode = SpriteSortMode.Deferred,
			BlendState blendState = null,
			SamplerState samplerState = null,
			DepthStencilState depthStencilState = null,
			RasterizerState rasterizerState = null,
			Effect effect = null,
			Matrix? transformMatrix = default(Matrix?));

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="destinationRectangle">The drawing bounds on screen.</param>
		/// <param name="color">A color mask.</param>
		void Draw(Texture2D texture, Rectangle destinationRectangle, Color color);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		void Draw(Texture2D texture, Vector2 position, Color color);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="color">A color mask.</param>
		void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="destinationRectangle">The drawing bounds on screen.</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="color">A color mask.</param>
		void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="destinationRectangle">The drawing bounds on screen.</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this sprite.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this sprite.</param>
		void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this sprite.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this sprite.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this sprite.</param>
		void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this sprite.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this sprite.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this sprite.</param>
		void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a sprite for drawing in the current batch.
		/// </summary>
		/// <param name="texture">A texture.</param>
		/// <param name="position">The drawing location on screen or null if <paramref name="destinationRectangle"/></param>
		/// <param name="destinationRectangle">The drawing bounds on screen or null if position</param>
		/// <param name="sourceRectangle">An optional region on the texture which will be rendered. If <see cref="null"/> - draws full texture.</param>
		/// <param name="origin">An optional center of rotation. Uses <see cref="Vector2.Zero"/> if null.</param>
		/// <param name="rotation">An optional rotation of this sprite. 0 by default.</param>
		/// <param name="scale">An optional scale vector. Uses <see cref="Vector2.One"/> if null.</param>
		/// <param name="color">An optional color mask. Uses <see cref="Color.White"/> if null.</param>
		/// <param name="effects">The optional drawing modificators. <see cref="SpriteEffects.None"/> by default.</param>
		/// <param name="layerDepth">An optional depth of the layer of this sprite. 0 by default.</param>
		/// <exception cref="InvalidOperationException">Throwns if both position and <paramref name="destinationRectangle"/> been used.</exception>
		/// <remarks>
		/// This overload uses optional parameters. This overload requires only one of position and <paramref="destinationRectangle"/> been used.
		/// </remarks>
		void Draw(Texture2D texture, Vector2? position = default(Vector2?), Rectangle? destinationRectangle = default(Rectangle?), Rectangle? sourceRectangle = default(Rectangle?), Vector2? origin = default(Vector2?), float rotation = 0, Vector2? scale = default(Vector2?), Color? color = default(Color?), SpriteEffects effects = SpriteEffects.None, float layerDepth = 0);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this string.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this string.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this string.</param>
		void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this string.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this string.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this string.</param>
		void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this string.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this string.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this string.</param>
		void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Submit a text string of sprites for drawing in the current batch.
		/// </summary>
		/// <param name="spriteFont">A font.</param>
		/// <param name="text">The text which will be drawn.</param>
		/// <param name="position">The drawing location on screen.</param>
		/// <param name="color">A color mask.</param>
		/// <param name="rotation">A rotation of this string.</param>
		/// <param name="origin">Center of the rotation. 0,0 by default.</param>
		/// <param name="scale">A scaling of this string.</param>
		/// <param name="effects">Modificators for drawing. Can be combined.</param>
		/// <param name="layerDepth">A depth of the layer of this string.</param>
		void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth);

		/// <summary>
		/// Flushes all batched text and sprites to the screen.
		/// </summary>
		/// <remarks>
		/// This command should be called after <see cref="SpriteBatch.Begin(SpriteSortMode, BlendState, SamplerState, DepthStencilState, RasterizerState, Effect, Matrix?)"/> and drawing commands.
		/// </remarks>
		void End();
	}
}
