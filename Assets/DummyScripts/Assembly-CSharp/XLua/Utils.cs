/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using XLua.LuaDLL;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public static class Utils // TypeDefIndex: 32448
	{
		// Fields
		public const int OBJ_META_IDX = -4; // Metadata: 0x00B14487
		public const int METHOD_IDX = -3; // Metadata: 0x00B1448B
		public const int GETTER_IDX = -2; // Metadata: 0x00B1448F
		public const int SETTER_IDX = -1; // Metadata: 0x00B14493
		public const int CLS_IDX = -4; // Metadata: 0x00B14497
		public const int CLS_META_IDX = -3; // Metadata: 0x00B1449B
		public const int CLS_GETTER_IDX = -2; // Metadata: 0x00B1449F
		public const int CLS_SETTER_IDX = -1; // Metadata: 0x00B144A3
		public const string LuaIndexsFieldName = "LuaIndexs"; // Metadata: 0x00B144A7
		public const string LuaNewIndexsFieldName = "LuaNewIndexs"; // Metadata: 0x00B144B4
		public const string LuaClassIndexsFieldName = "LuaClassIndexs"; // Metadata: 0x00B144C4
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs"; // Metadata: 0x00B144D6
	
		// Nested types
		private struct MethodKey // TypeDefIndex: 32449
		{
			// Fields
			public string Name; // 0x00
			public bool IsStatic; // 0x08
		}
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name) => default; // 0x00000001866C5850-0x00000001866C5910
		public static IntPtr GetMainState(IntPtr L) => default; // 0x00000001866C3FC0-0x00000001866C4090
		public static List<System.Type> GetAllTypes(bool exclude_generic_definition = true /* Metadata: 0x00B14481 */) => default; // 0x00000001866C3340-0x00000001866C3560
		public static List<System.Type> GetTypes(bool exclude_generic_definition = true /* Metadata: 0x00B14482 */) => default; // 0x00000001866C4090-0x00000001866C4230
		private static lua_CSFunction genFieldGetter(System.Type type, FieldInfo field) => default; // 0x00000001866C7F60-0x00000001866C8090
		private static lua_CSFunction genFieldSetter(System.Type type, FieldInfo field) => default; // 0x00000001866C8090-0x00000001866C81C0
		private static lua_CSFunction genItemGetter(System.Type type, PropertyInfo[] props) => default; // 0x00000001866C81C0-0x00000001866C84C0
		private static lua_CSFunction genItemSetter(System.Type type, PropertyInfo[] props) => default; // 0x00000001866C84C0-0x00000001866C87C0
		private static lua_CSFunction genEnumCastFrom(System.Type type) => default; // 0x00000001866C7E60-0x00000001866C7F60
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend) => default; // 0x00000001866C3560-0x00000001866C3FC0
		private static void makeReflectionWrap(IntPtr L, System.Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access) {
			item_getter = default;
			item_setter = default;
		} // 0x00000001866C8F80-0x00000001866CA870
		public static void loadUpvalue(IntPtr L, System.Type type, string metafunc, int num) {} // 0x00000001866C8DC0-0x00000001866C8F80
		public static void MakePrivateAccessible(IntPtr L, System.Type type) {} // 0x00000001866C5AC0-0x00000001866C5FC0
		// [MonoPInvokeCallback] // 0x0000000189A944C0-0x0000000189A94510
		internal static int LazyReflectionCall(IntPtr L) => default; // 0x00000001866C4970-0x00000001866C56C0
		public static void ReflectionWrap(IntPtr L, System.Type type, bool privateAccessible) {} // 0x00000001866C5FC0-0x00000001866C6BC0
		public static void BeginObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1 /* Metadata: 0x00B14483 */) {} // 0x00000001866C2730-0x00000001866C2A80
		private static int abs_idx(int top, int idx) => default; // 0x00000001866C7DF0-0x00000001866C7E60
		public static void EndObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, System.Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer) {} // 0x00000001866C2ED0-0x00000001866C3340
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func) {} // 0x00000001866C6BC0-0x00000001866C6CC0
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, System.Type type, LazyMemberTypes memberType, bool isStatic) {} // 0x00000001866C6CC0-0x00000001866C6E80
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj) {} // 0x00000001866C6E80-0x00000001866C6F80
		public static void BeginClassRegister(System.Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count) {} // 0x00000001866C2530-0x00000001866C2730
		public static void EndClassRegister(System.Type type, IntPtr L, ObjectTranslator translator) {} // 0x00000001866C2A80-0x00000001866C2ED0
		private static List<string> getPathOfType(System.Type type) => default; // 0x00000001866C8940-0x00000001866C8DC0
		public static void LoadCSTable(IntPtr L, System.Type type) {} // 0x00000001866C56C0-0x00000001866C5850
		public static void SetCSTable(IntPtr L, System.Type type, int cls_table) {} // 0x00000001866C6F80-0x00000001866C7480
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod) => default; // 0x00000001866C4230-0x00000001866C4450
		public static bool IsSupportedMethod(MethodInfo method) => default; // 0x00000001866C46E0-0x00000001866C4970
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method) => default; // 0x00000001866C5910-0x00000001866C5AC0
		private static System.Type getExtendedType(MethodInfo method) => default; // 0x00000001866C87C0-0x00000001866C8940
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction) => default; // 0x00000001866C45E0-0x00000001866C46E0
		public static bool IsPublic(System.Type type) => default; // 0x00000001866C4450-0x00000001866C45E0
	}
}
