/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	internal class InternalGlobals // TypeDefIndex: 32362
	{
		// Fields
		internal static TryArrayGet genTryArrayGetPtr; // 0x00
		internal static TryArraySet genTryArraySetPtr; // 0x08
		internal static ObjectTranslatorPool objectTranslatorPool; // 0x10
		internal static int LUA_REGISTRYINDEX; // 0x18
		internal static Dictionary<string, string> supportOp; // 0x20
		internal static Dictionary<System.Type, IEnumerable<MethodInfo>> extensionMethodMap; // 0x28
		internal static lua_CSFunction LazyReflectionWrap; // 0x30
	
		// Nested types
		internal delegate bool TryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index); // TypeDefIndex: 32363; 0x0000000183EFA0D0-0x0000000183EFA4D0
	
		internal delegate bool TryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx); // TypeDefIndex: 32364; 0x0000000183EFA6F0-0x0000000183EFAB60
	
		// Constructors
		static InternalGlobals() {} // 0x0000000183EEB250-0x0000000183EEB740
		public InternalGlobals() {} // 0x0000000183EEB740-0x0000000183EEB7A0
	}
}
