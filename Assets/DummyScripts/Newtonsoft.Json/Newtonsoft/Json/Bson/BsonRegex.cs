/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class BsonRegex : BsonToken // TypeDefIndex: 5520
	{
		// Properties
		public BsonString Pattern { get; set; } // 0x0000000185CBD870-0x0000000185CBD8D0 0x0000000185CBD980-0x0000000185CBD9E0
		public BsonString Options { get; set; } // 0x0000000185CBD810-0x0000000185CBD870 0x0000000185CBD920-0x0000000185CBD980
		public override BsonType Type { get => default; } // 0x0000000185CBD8D0-0x0000000185CBD920 
	
		// Constructors
		public BsonRegex() {} // Dummy constructor
		public BsonRegex(string pattern, string options) {} // 0x0000000185CBD6A0-0x0000000185CBD810
	}
}
