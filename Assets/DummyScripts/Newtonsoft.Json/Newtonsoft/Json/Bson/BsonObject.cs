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
	internal class BsonObject : BsonToken, IEnumerable<Newtonsoft.Json.Bson.BsonProperty> // TypeDefIndex: 5515
	{
		// Fields
		private readonly List<BsonProperty> _children; // 0x20
	
		// Properties
		public override BsonType Type { get => default; } // 0x0000000185CBAB40-0x0000000185CBAB90 
	
		// Constructors
		public BsonObject() {} // 0x0000000185CBAA70-0x0000000185CBAB40
	
		// Methods
		public void Add(string name, BsonToken token) {} // 0x0000000185CBA770-0x0000000185CBA950
		public IEnumerator<BsonProperty> GetEnumerator() => default; // 0x0000000185CBA950-0x0000000185CBAA00
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185CBAA00-0x0000000185CBAA70
	}
}
