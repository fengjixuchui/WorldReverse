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
	internal abstract class BsonToken // TypeDefIndex: 5514
	{
		// Properties
		public abstract BsonType Type { get; }
		public BsonToken Parent { get; set; } // 0x0000000185CBDCE0-0x0000000185CBDD40 0x0000000185CBDDA0-0x0000000185CBDE00
		public int CalculatedSize { get; set; } // 0x0000000185CBDC80-0x0000000185CBDCE0 0x0000000185CBDD40-0x0000000185CBDDA0
	
		// Constructors
		protected BsonToken() {} // 0x0000000185CBDC20-0x0000000185CBDC80
	}
}
