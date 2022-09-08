/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public struct fsResult // TypeDefIndex: 4731
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get => default; } // 0x0000000188DDB960-0x0000000188DDBA70 
		public bool Succeeded { get => default; } // 0x0000000188DDBC20-0x0000000188DDBC80 
		public bool HasWarnings { get => default; } // 0x0000000188DDBB00-0x0000000188DDBBB0 
		public Exception AsException { get => default; } // 0x0000000188DDB8F0-0x0000000188DDB960 
		public IEnumerable<string> RawMessages { get => default; } // 0x0000000188DDBBB0-0x0000000188DDBC20 
		public string FormattedMessages { get => default; } // 0x0000000188DDBA70-0x0000000188DDBB00 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x0000000188DDB720-0x0000000188DDB8F0
	
		// Methods
		public void AddMessage(string message) {} // 0x0000000188DDB180-0x0000000188DDB270
		public void AddMessages(fsResult result) {} // 0x0000000188DDB270-0x0000000188DDB370
		public fsResult Merge(fsResult other) => default; // 0x0000000188DDB560-0x0000000188DDB650
		public static fsResult Warn(string warning) => default; // 0x0000000188DDB650-0x0000000188DDB720
		public static fsResult Fail(string warning) => default; // 0x0000000188DDB490-0x0000000188DDB560
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x0000000188DDBC80-0x0000000188DDBDC0
		public fsResult AssertSuccess() => default; // 0x0000000188DDB460-0x0000000188DDB490
		public fsResult AssertSuccessWithoutWarnings() => default; // 0x0000000188DDB370-0x0000000188DDB460
	}
}
