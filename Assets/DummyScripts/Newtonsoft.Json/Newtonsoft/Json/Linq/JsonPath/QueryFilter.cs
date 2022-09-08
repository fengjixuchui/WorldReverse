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
	internal class QueryFilter : PathFilter // TypeDefIndex: 5473
	{
		// Properties
		public QueryExpression Expression { get; } // 0x0000000186C88EC0-0x0000000186C88F20 
	
		// Constructors
		public QueryFilter() {} // 0x0000000186C88E20-0x0000000186C88EC0
	
		// Methods
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch) => default; // 0x0000000186C88D70-0x0000000186C88E20
	}
}
