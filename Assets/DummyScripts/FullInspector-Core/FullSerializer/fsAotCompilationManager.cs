/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public class fsAotCompilationManager // TypeDefIndex: 4708
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Properties
		public static Dictionary<System.Type, string> AvailableAotCompilations { get => default; } // 0x0000000185D07810-0x0000000185D07A10 
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 4709
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager() {} // 0x0000000185D077B0-0x0000000185D07810
		static fsAotCompilationManager() {} // 0x0000000185D076F0-0x0000000185D077B0
	
		// Methods
		public static bool TryToPerformAotCompilation(fsConfig config, System.Type type, out string aotCompiledClassInCSharp) {
			aotCompiledClassInCSharp = default;
			return default;
		} // 0x0000000185D075E0-0x0000000185D076F0
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) {} // 0x0000000185D064C0-0x0000000185D065C0
		private static string GetConverterString(fsMetaProperty member) => default; // 0x0000000185D07510-0x0000000185D075E0
		private static string GenerateDirectConverterForTypeInCSharp(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) => default; // 0x0000000185D065C0-0x0000000185D07510
	}
}
