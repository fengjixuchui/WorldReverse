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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class ArraySliceFilter : PathFilter // TypeDefIndex: 5460
	{
		// Properties
		public int? Start { get; } // 0x0000000186C66230-0x0000000186C66290 
		public int? End { get; } // 0x0000000186C661D0-0x0000000186C66230 
		public int? Step { get; } // 0x0000000186C66290-0x0000000186C662F0 
	
		// Constructors
		public ArraySliceFilter() {} // 0x0000000186C66130-0x0000000186C661D0
	
		// Methods
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch) => default; // 0x0000000186C65FF0-0x0000000186C660B0
		private bool IsValid(int index, int stopIndex, bool positiveStep) => default; // 0x0000000186C660B0-0x0000000186C66130
	}
}
