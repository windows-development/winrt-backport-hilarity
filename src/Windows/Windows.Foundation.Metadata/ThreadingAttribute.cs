using System;
namespace Windows.Foundation.Metadata
{
	//[AttributeUsage(AttributeTargets.RuntimeClass), Version(100794368u)]
    [AttributeUsage(AttributeTargets.Class)]
	public sealed class ThreadingAttribute : Attribute
	{
		public extern ThreadingAttribute(ThreadingModel model);
	}
}
