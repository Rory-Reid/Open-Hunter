using System;
using System.IO;

namespace Microsoft.Xna.Framework.Graphics
{
	public interface ITexture2D
	{
		/// <summary>
		/// Gets the dimensions of the texture
		/// </summary>
		Rectangle Bounds { get; }
		int Height { get; }
		int Width { get; }

		/// <summary>
		/// Retrieves the contents of the texture 
		/// </summary>
		/// <param name="data">Destination array for the texture data</param>
		/// <exception cref="ArgumentException">Throws if <paramref name="data"/> is <see cref="null"/>of if <paramref name="data"/>.length is too short</exception>
		void GetData<T>(T[] data) where T : struct;

		/// <summary>
		/// Retrieves the contents of the texture
		/// </summary>
		/// <param name="data">Destination array for the texture data</param>
		/// <param name="startIndex">First position in data where to write the pixel data</param>
		/// <param name="elementCount">Number of pixels to read</param>
		/// <exception cref="ArgumentException">Throws if <paramref name="data"/> is <see cref="null"/> or if <paramref name="data"/>.length is too short</exception>
		void GetData<T>(T[] data, int startIndex, int elementCount) where T : struct;

		/// <summary>
		/// Retrieves the contents of the texture
		/// </summary>
		/// <param name="level">Layer of the texture</param>
		/// <param name="rect">Area of the texture</param>
		/// <param name="data">Destination array for the texture data</param>
		/// <param name="startIndex">First position in data where to write the pixel data</param>
		/// <param name="elementCount">Number of pixels to read</param>
		/// <exception cref="ArgumentException">Throws if <paramref name="data"/> is <see cref="null"/>, <paramref name="data"/>.length is too short or if <paramref name="arraySlice"/> is greater than 0 and the <see cref="GraphicsDevice"/> doesn't support texture arrays</exception>
		void GetData<T>(int level, Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct;

		/// <summary>
		/// Retrieves the contents of the texture
		/// </summary>
		/// <param name="level">Layer of the texture</param>
		/// <param name="arraySlice">Index inside the texture array</param>
		/// <param name="rect">Area of the texture to retrieve</param>
		/// <param name="data">Destination array for the data</param>
		/// <param name="startIndex">Starting index of data where to write the pixel data</param>
		/// <param name="elementCount">Number of pixels to read</param>
		/// <exception cref="ArgumentException">Throws if <paramref name="data"/> is <see cref="null"/>, <paramref name="data"/>.length is too short or if <paramref name="arraySlice"/> is greater than 0 and the <see cref="GraphicsDevice"/> doesn't support texture arrays</exception>
		void GetData<T>(int level, int arraySlice, Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct;
		void Reload(Stream textureStream);

		/// <summary>
		/// Converts the texture to a JPG image
		/// </summary>
		/// <param name="stream">Destination for the image</param>
		void SaveAsJpeg(Stream stream, int width, int height);

		/// <summary>
		/// Converts the texture to a PNG image
		/// </summary>
		/// <param name="stream">Destination for the image</param>
		void SaveAsPng(Stream stream, int width, int height);

		/// <summary>
		/// Changes the texture's pixels
		/// </summary>
		/// <param name="data">New data for the texture</param>
		void SetData<T>(T[] data) where T : struct;

		/// <summary>
		/// Changes the texture's pixels
		/// </summary>
		/// <param name="data">New data for the texture</param>
		/// <param name="startIndex">Start position of data</param>
		void SetData<T>(T[] data, int startIndex, int elementCount) where T : struct;

		/// <summary>
		/// Changes the pixels of the texture
		/// </summary>
		/// <param name="level">Layer of the texture to modify</param>
		/// <param name="rect">Area to modify</param>
		/// <param name="data">New data for the texture</param>
		/// <param name="startIndex">Start position of data</param>
		void SetData<T>(int level, Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct;

		/// <summary>
		/// Changes the pixels of the texture
		/// </summary>
		/// <param name="level">Layer of the texture to modify</param>
		/// <param name="arraySlice">Index inside the texture array</param>
		/// <param name="rect">Area to modify</param>
		/// <param name="data">New data for the texture</param>
		/// <param name="startIndex">Start position of data</param>
		/// <exception cref="ArgumentNullException">Throws if <paramref name="data"/> is <see cref="null"/>.</exception>
		/// <exception cref="ArgumentException">Throws if <paramref name="arraySlice"/> is greater than 0 and the <see cref="GraphicsDevice"/> does not support texture arrays.</exception>
		void SetData<T>(int level, int arraySlice, Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct;
	}
}
