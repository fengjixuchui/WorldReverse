/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 5365
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver() {} // 0x0000000186348060-0x00000001863480C0
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context) => default; // 0x0000000186347C00-0x0000000186347DE0
		public object ResolveReference(object context, string reference) => default; // 0x0000000186347FA0-0x0000000186348060
		public string GetReference(object context, object value) => default; // 0x0000000186347DE0-0x0000000186347EF0
		public void AddReference(object context, string reference, object value) {} // 0x0000000186347B60-0x0000000186347C00
		public bool IsReferenced(object context, object value) => default; // 0x0000000186347EF0-0x0000000186347FA0
	}
}
