/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public static class fsVersionManager // TypeDefIndex: 9274
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager() {} // 0x00000001865A4540-0x00000001865A46E0
	
		// Methods
		// [XID] // 0x00000001897F2330-0x00000001897F2350
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path) {
			path = default;
			return default;
		} // 0x00000001865A36B0-0x00000001865A3AC0
		// [XID] // 0x0000000189ADCFF0-0x0000000189ADD010
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current) => default; // 0x00000001865A3470-0x00000001865A36B0
		// [XID] // 0x00000001896C7C50-0x00000001896C7C70
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type) => default; // 0x00000001865A3AC0-0x00000001865A4030
		// [XID] // 0x0000000189AEBEF0-0x0000000189AEBF10
		private static void VerifyConstructors(fsVersionedType type) {} // 0x00000001865A4030-0x00000001865A4280
		// [XID] // 0x00000001896D67E0-0x00000001896D6800
		private static void VerifyUniqueVersionStrings(fsVersionedType type) {} // 0x00000001865A4280-0x00000001865A4540
	}
}
