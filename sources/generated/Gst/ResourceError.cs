// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.ResourceErrorGType))]
	public enum ResourceError {

		Failed = 1,
		TooLazy = 2,
		NotFound = 3,
		Busy = 4,
		OpenRead = 5,
		OpenWrite = 6,
		OpenReadWrite = 7,
		Close = 8,
		Read = 9,
		Write = 10,
		Seek = 11,
		Sync = 12,
		Settings = 13,
		NoSpaceLeft = 14,
		NotAuthorized = 15,
		NumErrors = 16,
	}

	internal class ResourceErrorGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_resource_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_resource_error_get_type ());
			}
		}
	}
#endregion
}