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
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189661900-0x0000000189661950
	[Preserve] // 0x0000000189661900-0x0000000189661950
	public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5259
	{
		// Fields
		internal bool? _isReference; // 0x20
		internal bool? _itemIsReference; // 0x22
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x24
		internal TypeNameHandling? _itemTypeNameHandling; // 0x2C
	
		// Properties
		public System.Type ItemConverterType { get; } // 0x0000000185CC11A0-0x0000000185CC1200 
		public object[] ItemConverterParameters { get; } // 0x0000000185CC1140-0x0000000185CC11A0 
	
		// Constructors
		protected JsonContainerAttribute() {} // 0x0000000185CC10E0-0x0000000185CC1140
	}
}
