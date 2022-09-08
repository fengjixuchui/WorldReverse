/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	public class WebSocketException : Exception // TypeDefIndex: 10322
	{
		// Fields
		private CloseStatusCode _code; // 0x60
	
		// Properties
		public CloseStatusCode Code { /* [XID] */ /* 0x00000001897EAEC0-0x00000001897EAEE0 */ get => default; } // 0x0000000189490CC0-0x0000000189490D60 
	
		// Constructors
		internal WebSocketException() {} // 0x0000000189490970-0x0000000189490A60
		internal WebSocketException(Exception innerException) {} // 0x0000000189490A60-0x0000000189490B50
		internal WebSocketException(string message) {} // 0x0000000189490C40-0x0000000189490CC0
		internal WebSocketException(CloseStatusCode code) {} // 0x0000000189490B50-0x0000000189490C40
		internal WebSocketException(string message, Exception innerException) {} // 0x0000000189490700-0x0000000189490790
		internal WebSocketException(CloseStatusCode code, Exception innerException) {} // 0x0000000189490820-0x00000001894908B0
		internal WebSocketException(CloseStatusCode code, string message) {} // 0x0000000189490790-0x0000000189490820
		internal WebSocketException(CloseStatusCode code, string message, Exception innerException) {} // 0x00000001894908B0-0x0000000189490970
	}
}
