/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal class HttpHeaderInfo // TypeDefIndex: 10254
	{
		// Fields
		private string _name; // 0x10
		private HttpHeaderType _type; // 0x18
	
		// Properties
		internal bool IsMultiValueInRequest { /* [XID] */ /* 0x000000018976D8A0-0x000000018976D8C0 */ get => default; } // 0x000000018670C960-0x000000018670CA10 
		internal bool IsMultiValueInResponse { /* [XID] */ /* 0x00000001896F35B0-0x00000001896F35D0 */ get => default; } // 0x000000018670CA10-0x000000018670CAC0 
		public bool IsRequest { /* [XID] */ /* 0x0000000189B9CAF0-0x0000000189B9CB10 */ get => default; } // 0x000000018670CAC0-0x000000018670CB60 
		public bool IsResponse { /* [XID] */ /* 0x0000000189702320-0x0000000189702340 */ get => default; } // 0x000000018670CB60-0x000000018670CC10 
		public string Name { /* [XID] */ /* 0x0000000189709B80-0x0000000189709BA0 */ get => default; } // 0x000000018670CC10-0x000000018670CCB0 
		public HttpHeaderType Type { /* [XID] */ /* 0x000000018980D480-0x000000018980D4A0 */ get => default; } // 0x000000018670CCB0-0x000000018670CD50 
	
		// Constructors
		public HttpHeaderInfo() {} // Dummy constructor
		internal HttpHeaderInfo(string name, HttpHeaderType type) {} // 0x000000018670C8E0-0x000000018670C960
	
		// Methods
		// [XID] // 0x0000000189718A00-0x0000000189718A20
		public bool IsMultiValue(bool response) => default; // 0x000000018670C720-0x000000018670C800
		// [XID] // 0x0000000189720160-0x0000000189720180
		public bool IsRestricted(bool response) => default; // 0x000000018670C800-0x000000018670C8E0
	}
}
