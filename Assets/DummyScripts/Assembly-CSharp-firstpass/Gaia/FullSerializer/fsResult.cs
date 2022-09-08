/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public struct fsResult // TypeDefIndex: 9260
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { /* [XID] */ /* 0x00000001897C9DC0-0x00000001897C9DE0 */ get => default; } // 0x0000000186B58DA0-0x0000000186B58EA0 
		public bool Succeeded { /* [XID] */ /* 0x00000001899C1410-0x00000001899C1430 */ get => default; } // 0x0000000186B59110-0x0000000186B59120 
		public bool HasWarnings { /* [XID] */ /* 0x00000001897D93A0-0x00000001897D93C0 */ get => default; } // 0x0000000186B58F70-0x0000000186B59060 
		public Exception AsException { /* [XID] */ /* 0x00000001898C4340-0x00000001898C4360 */ get => default; } // 0x0000000186B58CF0-0x0000000186B58DA0 
		public IEnumerable<string> RawMessages { /* [XID] */ /* 0x00000001897F7120-0x00000001897F7140 */ get => default; } // 0x0000000186B59060-0x0000000186B59110 
		public string FormattedMessages { /* [XID] */ /* 0x00000001897FE7D0-0x00000001897FE7F0 */ get => default; } // 0x0000000186B58EA0-0x0000000186B58F70 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x0000000186B58B00-0x0000000186B58CF0
	
		// Methods
		// [XID] // 0x000000018979C7E0-0x000000018979C800
		public void AddMessage(string message) {} // 0x0000000186B58380-0x0000000186B584A0
		// [XID] // 0x00000001897A3C50-0x00000001897A3C70
		public void AddMessages(fsResult result) {} // 0x0000000186B584A0-0x0000000186B585D0
		// [XID] // 0x0000000189B03370-0x0000000189B03390
		public fsResult Merge(fsResult other) => default; // 0x0000000186B589A0-0x0000000186B589E0
		// [XID] // 0x00000001897B2DE0-0x00000001897B2E00
		public static fsResult Warn(string warning) => default; // 0x0000000186B589E0-0x0000000186B58B00
		// [XID] // 0x00000001897BA9D0-0x00000001897BA9F0
		public static fsResult Fail(string warning) => default; // 0x0000000186B58720-0x0000000186B589A0
		// [XID] // 0x0000000189AE56A0-0x0000000189AE56C0
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x0000000186B59120-0x0000000186B59240
		// [XID] // 0x00000001898628D0-0x00000001898628F0
		public fsResult AssertSuccess() => default; // 0x0000000186B586F0-0x0000000186B58720
		// [XID] // 0x0000000189AEFC60-0x0000000189AEFC80
		public fsResult AssertSuccessWithoutWarnings() => default; // 0x0000000186B585D0-0x0000000186B586F0
	}
}
