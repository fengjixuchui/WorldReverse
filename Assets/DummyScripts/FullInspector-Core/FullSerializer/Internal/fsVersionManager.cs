/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public static class fsVersionManager // TypeDefIndex: 4764
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager() {} // 0x0000000188DE34B0-0x0000000188DE35F0
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path) {
			path = default;
			return default;
		} // 0x0000000188DE2770-0x0000000188DE2B30
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current) => default; // 0x0000000188DE25B0-0x0000000188DE2770
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type) => default; // 0x0000000188DE2B30-0x0000000188DE3040
		private static void VerifyConstructors(fsVersionedType type) {} // 0x0000000188DE3040-0x0000000188DE3250
		private static void VerifyUniqueVersionStrings(fsVersionedType type) {} // 0x0000000188DE3250-0x0000000188DE34B0
	}
}
