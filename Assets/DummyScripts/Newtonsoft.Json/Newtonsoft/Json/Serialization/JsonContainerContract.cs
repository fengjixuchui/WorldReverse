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

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonContainerContract : JsonContract // TypeDefIndex: 5354
	{
		// Fields
		private JsonContract _itemContract; // 0x90
		private JsonContract _finalItemContract; // 0x98
	
		// Properties
		internal JsonContract ItemContract { get => default; set {} } // 0x00000001863509F0-0x0000000186350A50 0x0000000186350BD0-0x0000000186350CA0
		internal JsonContract FinalItemContract { get => default; } // 0x0000000186350990-0x00000001863509F0 
		public JsonConverter ItemConverter { get; set; } // 0x0000000186350A50-0x0000000186350AB0 0x0000000186350CA0-0x0000000186350D10
		public bool? ItemIsReference { get; set; } // 0x0000000186350AB0-0x0000000186350B10 0x0000000186350D10-0x0000000186350D70
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; } // 0x0000000186350B10-0x0000000186350B70 0x0000000186350D70-0x0000000186350DD0
		public TypeNameHandling? ItemTypeNameHandling { get; set; } // 0x0000000186350B70-0x0000000186350BD0 0x0000000186350DD0-0x0000000186350E30
	
		// Constructors
		public JsonContainerContract() {} // Dummy constructor
		internal JsonContainerContract(System.Type underlyingType) {} // 0x00000001863507B0-0x0000000186350990
	}
}
