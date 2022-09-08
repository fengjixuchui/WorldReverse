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
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 5397
	{
		// Fields
		private ErrorContext _currentErrorContext; // 0x10
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		internal readonly ITraceWriter TraceWriter; // 0x28
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x0000000186357D00-0x0000000186357E40 
	
		// Nested types
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 5398
		{
			// Constructors
			public ReferenceEqualsEqualityComparer() {} // 0x0000000186364FC0-0x00000001863650E0
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000186364EE0-0x0000000186364F50
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000186364F50-0x0000000186364FC0
		}
	
		// Constructors
		protected JsonSerializerInternalBase() {} // Dummy constructor
		protected JsonSerializerInternalBase(JsonSerializer serializer) {} // 0x0000000186357C50-0x0000000186357D00
	
		// Methods
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) => default; // 0x00000001863576F0-0x0000000186357850
		protected void ClearErrorContext() {} // 0x0000000186357650-0x00000001863576F0
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) => default; // 0x0000000186357850-0x0000000186357C50
	}
}
