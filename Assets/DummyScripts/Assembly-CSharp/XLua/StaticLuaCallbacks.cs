/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class StaticLuaCallbacks // TypeDefIndex: 32360
	{
		// Fields
		internal lua_CSFunction GcMeta; // 0x10
		internal lua_CSFunction ToStringMeta; // 0x18
		internal lua_CSFunction EnumAndMeta; // 0x20
		internal lua_CSFunction EnumOrMeta; // 0x28
		internal lua_CSFunction StaticCSFunctionWraper; // 0x30
		internal lua_CSFunction FixCSFunctionWraper; // 0x38
		internal lua_CSFunction DelegateCtor; // 0x40
	
		// Constructors
		public StaticLuaCallbacks() {} // 0x00000001866BDBE0-0x00000001866BDD80
	
		// Methods
		internal static bool __tryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index) => default; // 0x00000001866BB0C0-0x00000001866BC540
		internal static bool __tryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx) => default; // 0x00000001866BC540-0x00000001866BDBE0
		// [MonoPInvokeCallback] // 0x00000001895ECF60-0x00000001895ECFB0
		public static int EnumAnd(IntPtr L) => default; // 0x00000001866B7120-0x00000001866B73A0
		// [MonoPInvokeCallback] // 0x00000001895F9080-0x00000001895F90D0
		public static int EnumOr(IntPtr L) => default; // 0x00000001866B73A0-0x00000001866B7620
		// [MonoPInvokeCallback] // 0x0000000189604DD0-0x0000000189604E20
		private static int StaticCSFunction(IntPtr L) => default; // 0x00000001866B99B0-0x00000001866B9AF0
		// [MonoPInvokeCallback] // 0x0000000189610EC0-0x0000000189610F10
		private static int FixCSFunction(IntPtr L) => default; // 0x00000001866B7620-0x00000001866B7750
		// [MonoPInvokeCallback] // 0x000000018961CDA0-0x000000018961CDF0
		public static int DelegateCall(IntPtr L) => default; // 0x00000001866B6920-0x00000001866B6AD0
		// [MonoPInvokeCallback] // 0x0000000189628CB0-0x0000000189628D00
		public static int LuaGC(IntPtr L) => default; // 0x00000001866B9290-0x00000001866B9390
		// [MonoPInvokeCallback] // 0x0000000189634E90-0x0000000189634EE0
		public static int ToString(IntPtr L) => default; // 0x00000001866B9D70-0x00000001866B9F30
		// [MonoPInvokeCallback] // 0x0000000189640B10-0x0000000189640B60
		public static int DelegateCombine(IntPtr L) => default; // 0x00000001866B6AD0-0x00000001866B6D20
		// [MonoPInvokeCallback] // 0x000000018964CE50-0x000000018964CEA0
		public static int DelegateRemove(IntPtr L) => default; // 0x00000001866B6EF0-0x00000001866B7120
		private static bool tryPrimitiveArrayGet(System.Type type, IntPtr L, object obj, int index) => default; // 0x00000001866BDF50-0x00000001866BE760
		// [MonoPInvokeCallback] // 0x0000000189658B00-0x0000000189658B50
		public static int ArrayIndexer(IntPtr L) => default; // 0x00000001866B5AC0-0x00000001866B6000
		public static bool TryPrimitiveArraySet(System.Type type, IntPtr L, object obj, int array_idx, int obj_idx) => default; // 0x00000001866B9F30-0x00000001866BA8C0
		// [MonoPInvokeCallback] // 0x0000000189664AB0-0x0000000189664B00
		public static int ArrayNewIndexer(IntPtr L) => default; // 0x00000001866B6170-0x00000001866B66E0
		// [MonoPInvokeCallback] // 0x0000000189670FF0-0x0000000189671040
		public static int ArrayLength(IntPtr L) => default; // 0x00000001866B6000-0x00000001866B6170
		// [MonoPInvokeCallback] // 0x000000018967CFF0-0x000000018967D040
		public static int MetaFuncIndex(IntPtr L) => default; // 0x00000001866B9390-0x00000001866B9540
		// [MonoPInvokeCallback] // 0x00000001896892D0-0x0000000189689320
		internal static int Panic(IntPtr L) => default; // 0x00000001866B9540-0x00000001866B9610
		// [MonoPInvokeCallback] // 0x0000000189695470-0x00000001896954C0
		internal static int Print(IntPtr L) => default; // 0x00000001866B9610-0x00000001866B98C0
		// [MonoPInvokeCallback] // 0x00000001896A1110-0x00000001896A1160
		internal static int LoadCS(IntPtr L) => default; // 0x00000001866B8750-0x00000001866B87E0
		// [MonoPInvokeCallback] // 0x00000001896ACD00-0x00000001896ACD50
		internal static int LoadBuiltinLib(IntPtr L) => default; // 0x00000001866B8590-0x00000001866B8750
		// [MonoPInvokeCallback] // 0x00000001896B88B0-0x00000001896B8900
		internal static int LoadFromResource(IntPtr L) => default; // 0x00000001866B8C70-0x00000001866B8FA0
		// [MonoPInvokeCallback] // 0x00000001896C4210-0x00000001896C4260
		internal static int LoadFromStreamingAssetsPath(IntPtr L) => default; // 0x00000001866B8FA0-0x00000001866B9290
		// [MonoPInvokeCallback] // 0x00000001896D0170-0x00000001896D01C0
		internal static int LoadFromCustomLoaders(IntPtr L) => default; // 0x00000001866B87E0-0x00000001866B8C70
		// [MonoPInvokeCallback] // 0x00000001896DBDC0-0x00000001896DBE10
		public static int LoadAssembly(IntPtr L) => default; // 0x00000001866B83F0-0x00000001866B8590
		// [MonoPInvokeCallback] // 0x00000001896E78E0-0x00000001896E7930
		public static int ImportType(IntPtr L) => default; // 0x00000001866B81F0-0x00000001866B83F0
		// [MonoPInvokeCallback] // 0x00000001896F3880-0x00000001896F38D0
		public static int ImportGenericType(IntPtr L) => default; // 0x00000001866B7EA0-0x00000001866B81F0
		// [MonoPInvokeCallback] // 0x00000001896FF8B0-0x00000001896FF900
		public static int Cast(IntPtr L) => default; // 0x00000001866B66E0-0x00000001866B6920
		private static System.Type getType(IntPtr L, ObjectTranslator translator, int idx) => default; // 0x00000001866BDD80-0x00000001866BDF50
		// [MonoPInvokeCallback] // 0x000000018970B5E0-0x000000018970B630
		public static int XLuaAccess(IntPtr L) => default; // 0x00000001866BA8C0-0x00000001866BACA0
		// [MonoPInvokeCallback] // 0x00000001897171C0-0x0000000189717210
		public static int XLuaPrivateAccessible(IntPtr L) => default; // 0x00000001866BAF20-0x00000001866BB0C0
		// [MonoPInvokeCallback] // 0x0000000189723300-0x0000000189723350
		public static int XLuaMetatableOperation(IntPtr L) => default; // 0x00000001866BACA0-0x00000001866BAF20
		// [MonoPInvokeCallback] // 0x000000018972F090-0x000000018972F0E0
		public static int DelegateConstructor(IntPtr L) => default; // 0x00000001866B6D20-0x00000001866B6EF0
		// [MonoPInvokeCallback] // 0x000000018973AF00-0x000000018973AF50
		public static int ToFunction(IntPtr L) => default; // 0x00000001866B9AF0-0x00000001866B9D70
		// [MonoPInvokeCallback] // 0x00000001897472D0-0x0000000189747320
		public static int GenericMethodWraper(IntPtr L) => default; // 0x00000001866B7750-0x00000001866B7AF0
		// [MonoPInvokeCallback] // 0x0000000189752FF0-0x0000000189753040
		public static int GetGenericMethod(IntPtr L) => default; // 0x00000001866B7AF0-0x00000001866B7EA0
		// [MonoPInvokeCallback] // 0x000000018975F090-0x000000018975F0E0
		public static int ReleaseCsObject(IntPtr L) => default; // 0x00000001866B98C0-0x00000001866B99B0
	}
}
