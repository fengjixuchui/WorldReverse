/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	internal abstract class QueryExpression // TypeDefIndex: 5470
	{
		// Properties
		public QueryOperator Operator { get; } // 0x0000000186C88D10-0x0000000186C88D70 
	
		// Constructors
		protected QueryExpression() {} // 0x0000000186C88CB0-0x0000000186C88D10
	
		// Methods
		public abstract bool IsMatch(JToken t);
	}
}
