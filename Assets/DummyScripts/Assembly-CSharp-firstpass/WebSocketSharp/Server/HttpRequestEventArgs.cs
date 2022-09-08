/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using IFix.Core;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public class HttpRequestEventArgs : EventArgs // TypeDefIndex: 10293
	{
		// Fields
		private HttpListenerContext _context; // 0x10
		private string _docRootPath; // 0x18
	
		// Properties
		public HttpListenerRequest Request { /* [XID] */ /* 0x000000018962C150-0x000000018962C170 */ get => default; } // 0x00000001857CE670-0x00000001857CE720 
		public HttpListenerResponse Response { /* [XID] */ /* 0x00000001899D3A20-0x00000001899D3A40 */ get => default; } // 0x00000001857CE720-0x00000001857CE7D0 
		public IPrincipal User { /* [XID] */ /* 0x0000000189A610D0-0x0000000189A610F0 */ get => default; } // 0x00000001857CE7D0-0x00000001857CE880 
	
		// Constructors
		public HttpRequestEventArgs() {} // Dummy constructor
		internal HttpRequestEventArgs(HttpListenerContext context, string documentRootPath) {} // 0x00000001857CE3F0-0x00000001857CE490
	
		// Methods
		// [XID] // 0x0000000189A0F120-0x0000000189A0F140
		private string createFilePath(string childPath) => default; // 0x00000001857CE490-0x00000001857CE670
		// [XID] // 0x0000000189A70240-0x0000000189A70260
		private static bool tryReadFile(string path, out byte[] contents) {
			contents = default;
			return default;
		} // 0x00000001857CE880-0x00000001857CE960
		// [XID] // 0x0000000189A77AE0-0x0000000189A77B00
		public byte[] ReadFile(string path) => default; // 0x00000001857CE070-0x00000001857CE230
		// [XID] // 0x0000000189A33F60-0x0000000189A33F80
		public bool TryReadFile(string path, out byte[] contents) {
			contents = default;
			return default;
		} // 0x00000001857CE230-0x00000001857CE3F0
	}
}
