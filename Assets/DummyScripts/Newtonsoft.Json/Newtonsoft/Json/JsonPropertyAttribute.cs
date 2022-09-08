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

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189754A60-0x0000000189754AB0
	[Preserve] // 0x0000000189754A60-0x0000000189754AB0
	public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 5269
	{
		// Fields
		internal NullValueHandling? _nullValueHandling; // 0x10
		internal DefaultValueHandling? _defaultValueHandling; // 0x18
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x20
		internal ObjectCreationHandling? _objectCreationHandling; // 0x28
		internal TypeNameHandling? _typeNameHandling; // 0x30
		internal bool? _isReference; // 0x38
		internal int? _order; // 0x3C
		internal Required? _required; // 0x44
		internal bool? _itemIsReference; // 0x4C
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x50
		internal TypeNameHandling? _itemTypeNameHandling; // 0x58
	
		// Properties
		public System.Type ItemConverterType { get; } // 0x0000000185CC3BC0-0x0000000185CC3C20 
		public object[] ItemConverterParameters { get; } // 0x0000000185CC3B60-0x0000000185CC3BC0 
		public string PropertyName { get; } // 0x0000000185CC3C20-0x0000000185CC3C80 
	
		// Constructors
		public JsonPropertyAttribute() {} // 0x0000000185CC3B00-0x0000000185CC3B60
	}
}
