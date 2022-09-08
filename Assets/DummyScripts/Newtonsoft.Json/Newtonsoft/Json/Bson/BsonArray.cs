/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	internal class BsonArray : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonToken> // TypeDefIndex: 5516
	{
		// Fields
		private readonly List<BsonToken> _children; // 0x20
	
		// Properties
		public override BsonType Type { get => default; } // 0x0000000185CB8440-0x0000000185CB8490 
	
		// Constructors
		public BsonArray() {} // 0x0000000185CB8370-0x0000000185CB8440
	
		// Methods
		public void Add(BsonToken token) {} // 0x0000000185CB8180-0x0000000185CB8250
		public IEnumerator<BsonToken> GetEnumerator() => default; // 0x0000000185CB8250-0x0000000185CB8300
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185CB8300-0x0000000185CB8370
	}
}
