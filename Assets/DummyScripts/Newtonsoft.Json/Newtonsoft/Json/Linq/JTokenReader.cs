/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5442
	{
		// Fields
		private readonly JToken _root; // 0x78
		private string _initialPath; // 0x80
		private JToken _parent; // 0x88
		private JToken _current; // 0x90
	
		// Properties
		public JToken CurrentToken { get => default; } // 0x0000000186C736A0-0x0000000186C73700 
		int IJsonLineInfo.LineNumber { get => default; } // 0x0000000186C728E0-0x0000000186C72970 
		int IJsonLineInfo.LinePosition { get => default; } // 0x0000000186C72970-0x0000000186C72A00 
		public override string Path { get => default; } // 0x0000000186C73700-0x0000000186C738A0 
	
		// Constructors
		public JTokenReader() {} // Dummy constructor
		public JTokenReader(JToken token) {} // 0x0000000186C73610-0x0000000186C736A0
	
		// Methods
		public override bool Read() => default; // 0x0000000186C72CE0-0x0000000186C72DE0
		private bool ReadOver(JToken t) => default; // 0x0000000186C72AD0-0x0000000186C72C70
		private bool ReadToEnd() => default; // 0x0000000186C72C70-0x0000000186C72CE0
		private Newtonsoft.Json.JsonToken? GetEndToken(JContainer c) => default; // 0x0000000186C726E0-0x0000000186C72850
		private bool ReadInto(JContainer c) => default; // 0x0000000186C72A00-0x0000000186C72AD0
		private bool SetEnd(JContainer c) => default; // 0x0000000186C72E60-0x0000000186C72F40
		private void SetToken(JToken token) {} // 0x0000000186C72F40-0x0000000186C73610
		private string SafeToString(object value) => default; // 0x0000000186C72DE0-0x0000000186C72E60
		bool IJsonLineInfo.HasLineInfo() => default; // 0x0000000186C72850-0x0000000186C728E0
	}
}
