using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Version(100794368u)]
	public enum TiffCompressionMode
	{
		Automatic,
		None,
		Ccitt3,
		Ccitt4,
		Lzw,
		Rle,
		Zip,
		LzwhDifferencing
	}
}
