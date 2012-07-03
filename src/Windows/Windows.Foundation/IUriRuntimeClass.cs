using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(Uri)), Guid(2654363223u, 18610, 16736, 149, 111, 199, 56, 81, 32, 187, 252), Version(100794368u)]
	internal interface IUriRuntimeClass
	{
		string AbsoluteUri
		{
			get;
		}
		string DisplayUri
		{
			get;
		}
		string Domain
		{
			get;
		}
		string Extension
		{
			get;
		}
		string Fragment
		{
			get;
		}
		string Host
		{
			get;
		}
		string Password
		{
			get;
		}
		string Path
		{
			get;
		}
		int Port
		{
			get;
		}
		string Query
		{
			get;
		}
		WwwFormUrlDecoder QueryParsed
		{
			get;
		}
		string RawUri
		{
			get;
		}
		string SchemeName
		{
			get;
		}
		bool Suspicious
		{
			get;
		}
		string UserName
		{
			get;
		}
		bool Equals([In] Uri pUri);
		Uri CombineUri([In] string relativeUri);
	}
}
