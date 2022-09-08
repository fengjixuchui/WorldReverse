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
	internal class ArrayIndexFilter : PathFilter // TypeDefIndex: 5456
	{
		// Properties
		public int? Index { get; } // 0x0000000186C65DD0-0x0000000186C65E30 
	
		// Constructors
		public ArrayIndexFilter() {} // 0x0000000186C65D30-0x0000000186C65DD0
	
		// Methods
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch) => default; // 0x0000000186C65C70-0x0000000186C65D30
	}
}
