/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	internal class BooleanQueryExpression : QueryExpression // TypeDefIndex: 5472
	{
		// Properties
		public List<PathFilter> Path { get; } // 0x0000000186C66C60-0x0000000186C66CC0 
		public JValue Value { get; } // 0x0000000186C66CC0-0x0000000186C66D20 
	
		// Constructors
		public BooleanQueryExpression() {} // 0x0000000186C66BC0-0x0000000186C66C60
	
		// Methods
		public override bool IsMatch(JToken t) => default; // 0x0000000186C667B0-0x0000000186C66BC0
		private bool EqualsWithStringCoercion(JValue value, JValue queryValue) => default; // 0x0000000186C662F0-0x0000000186C667B0
	}
}
