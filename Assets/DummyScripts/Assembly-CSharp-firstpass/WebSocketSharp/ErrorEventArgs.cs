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
	public class ErrorEventArgs : EventArgs // TypeDefIndex: 10217
	{
		// Fields
		private Exception _exception; // 0x10
		private string _message; // 0x18
	
		// Properties
		public Exception Exception { /* [XID] */ /* 0x0000000189826C50-0x0000000189826C70 */ get => default; } // 0x0000000186E96CF0-0x0000000186E96D90 
		public string Message { /* [XID] */ /* 0x0000000189A13D10-0x0000000189A13D30 */ get => default; } // 0x0000000186E96D90-0x0000000186E96E30 
	
		// Constructors
		public ErrorEventArgs() {} // Dummy constructor
		internal ErrorEventArgs(string message) {} // 0x0000000186E96BD0-0x0000000186E96C50
		internal ErrorEventArgs(string message, Exception exception) {} // 0x0000000186E96C50-0x0000000186E96CF0
	}
}
