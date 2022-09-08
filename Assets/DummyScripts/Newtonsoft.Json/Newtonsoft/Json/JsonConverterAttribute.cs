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
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189695420-0x0000000189695470
	[Preserve] // 0x0000000189695420-0x0000000189695470
	public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 5261
	{
		// Fields
		private readonly System.Type _converterType; // 0x10
	
		// Properties
		public System.Type ConverterType { get => default; } // 0x0000000185CC27E0-0x0000000185CC2840 
		public object[] ConverterParameters { get; } // 0x0000000185CC2780-0x0000000185CC27E0 
	
		// Constructors
		public JsonConverterAttribute() {} // Dummy constructor
		public JsonConverterAttribute(System.Type converterType) {} // 0x0000000185CC26D0-0x0000000185CC2780
	}
}
