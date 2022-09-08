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
	internal class CompositeExpression : QueryExpression // TypeDefIndex: 5471
	{
		// Properties
		public List<QueryExpression> Expressions { get; set; } // 0x0000000186C67190-0x0000000186C671F0 0x0000000186C671F0-0x0000000186C67250
	
		// Constructors
		public CompositeExpression() {} // 0x0000000186C67090-0x0000000186C67190
	
		// Methods
		public override bool IsMatch(JToken t) => default; // 0x0000000186C66D20-0x0000000186C67090
	}
}
