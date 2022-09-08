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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class ReflectionObject // TypeDefIndex: 5309
	{
		// Properties
		public ObjectConstructor<object> Creator { get; private set; } // 0x0000000185E61850-0x0000000185E618B0 0x0000000185E61910-0x0000000185E61970
		public IDictionary<string, ReflectionMember> Members { get; private set; } // 0x0000000185E618B0-0x0000000185E61910 0x0000000185E61970-0x0000000185E619D0
	
		// Constructors
		public ReflectionObject() {} // 0x0000000185E61780-0x0000000185E61850
	
		// Methods
		public object GetValue(object target, string member) => default; // 0x0000000185E61640-0x0000000185E61780
		public System.Type GetType(string member) => default; // 0x0000000185E61530-0x0000000185E61640
		public static ReflectionObject Create(System.Type t, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] memberNames) => default; // 0x0000000185E60B80-0x0000000185E60C10
		public static ReflectionObject Create(System.Type t, MethodBase creator, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] memberNames) => default; // 0x0000000185E60C10-0x0000000185E61530
	}
}
