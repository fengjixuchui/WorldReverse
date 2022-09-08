/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	internal abstract class HttpBase // TypeDefIndex: 10228
	{
		// Fields
		private NameValueCollection _headers; // 0x10
		private const int _headersMaxLength = 8192; // Metadata: 0x00AE7276
		private Version _version; // 0x18
		internal byte[] EntityBodyData; // 0x20
		protected const string CrLf = "\r\n"; // Metadata: 0x00AE727A
	
		// Properties
		public string EntityBody { /* [XID] */ /* 0x0000000189A0DBC0-0x0000000189A0DBE0 */ get; } // 0x0000000186708AA0-0x0000000186708C50 
		public NameValueCollection Headers { /* [XID] */ /* 0x0000000189A2E1A0-0x0000000189A2E1C0 */ get; } // 0x0000000186708C50-0x0000000186708CF0 
		public Version ProtocolVersion { /* [XID] */ /* 0x0000000189A1C410-0x0000000189A1C430 */ get; } // 0x0000000186708CF0-0x0000000186708D90 
	
		// Constructors
		protected HttpBase() {} // Dummy constructor
		protected HttpBase(Version version, NameValueCollection headers) {} // 0x0000000186708A10-0x0000000186708AA0
	
		// Methods
		// [XID] // 0x0000000189A3D090-0x0000000189A3D0B0
		private static byte[] readEntityBody(Stream stream, string length) => default; // 0x0000000186708D90-0x0000000186708F70
		// [XID] // 0x0000000189603200-0x0000000189603220
		private static string[] readHeaders(Stream stream, int maxLength) => default; // 0x0000000186708F70-0x00000001867093F0
		protected static T Read<T>(Stream stream, Func<string[], T> parser, int millisecondsTimeout)
			where T : HttpBase => default;
		// [XID] // 0x000000018960ABE0-0x000000018960AC00
		public byte[] ToByteArray() => default; // 0x0000000186708900-0x0000000186708A10
	}
}
