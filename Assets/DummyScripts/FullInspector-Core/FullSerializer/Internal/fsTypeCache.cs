/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public static class fsTypeCache // TypeDefIndex: 4767
	{
		// Fields
		private static Dictionary<string, System.Type> _cachedTypes; // 0x00
		private static Dictionary<string, Assembly> _assembliesByName; // 0x08
		private static List<Assembly> _assembliesByIndex; // 0x10
	
		// Constructors
		static fsTypeCache() {} // 0x0000000188DE16A0-0x0000000188DE1920
	
		// Methods
		private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args) {} // 0x0000000188DE1100-0x0000000188DE1290
		private static bool TryDirectTypeLookup(string assemblyName, string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000188DE1340-0x0000000188DE1460
		private static bool TryIndirectTypeLookup(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000188DE1460-0x0000000188DE16A0
		public static void Reset() {} // 0x0000000188DE1290-0x0000000188DE1340
		public static System.Type GetType(string name) => default; // 0x0000000188DE0EA0-0x0000000188DE0F30
		public static System.Type GetType(string name, string assemblyHint) => default; // 0x0000000188DE0F30-0x0000000188DE1100
		public static System.Type GetType_Alt(string shortname) => default; // 0x0000000188DE0C20-0x0000000188DE0EA0
	}
}
