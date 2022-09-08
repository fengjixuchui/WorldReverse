/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public class fsAotCompilationManager // TypeDefIndex: 9238
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Properties
		public static Dictionary<System.Type, string> AvailableAotCompilations { /* [XID] */ /* 0x0000000189A71A30-0x0000000189A71A50 */ get => default; } // 0x0000000186B48C20-0x0000000186B48E50 
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 9239
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager() {} // 0x0000000186B48BC0-0x0000000186B48C20
		static fsAotCompilationManager() {} // 0x0000000186B48B00-0x0000000186B48BC0
	
		// Methods
		// [XID] // 0x00000001896CA7F0-0x00000001896CA810
		public static bool TryToPerformAotCompilation(System.Type type, out string aotCompiledClassInCSharp) {
			aotCompiledClassInCSharp = default;
			return default;
		} // 0x0000000186B489B0-0x0000000186B48B00
		// [XID] // 0x0000000189A80CF0-0x0000000189A80D10
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) {} // 0x0000000186B47960-0x0000000186B47AA0
		// [XID] // 0x0000000189A88620-0x0000000189A88640
		private static string GenerateDirectConverterForTypeInCSharp(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) => default; // 0x0000000186B47AA0-0x0000000186B489B0
	}
}
