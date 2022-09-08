/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public static class Utils // TypeDefIndex: 27425
	{
		// Fields
		private static Dictionary<string, bool> ms_staticClasses; // 0x00
		private static Dictionary<string, string> ms_type_mapping; // 0x08
	
		// Properties
		private static Dictionary<string, bool> StaticClasses { get; } // 0x0000000186DFD020-0x0000000186DFD130 
	
		// Constructors
		static Utils() {} // 0x0000000186DFCBE0-0x0000000186DFD020
	
		// Methods
		public static bool IsNull(object aObj) => default; // 0x0000000186DFC850-0x0000000186DFC8B0
		public static bool IsStaticType(System.Type type) => default; // 0x0000000186DFCA20-0x0000000186DFCAB0
		public static void AddStaticClass(System.Type type) {} // 0x0000000186DFA0D0-0x0000000186DFA1D0
		public static bool IsStaticClass(string className) => default; // 0x0000000186DFC970-0x0000000186DFCA20
		public static Agent GetParentAgent(Agent pAgent, string instanceName) => default; // 0x0000000186DFB050-0x0000000186DFB2A0
		public static bool IsDefault<T>(T obj) => default;
		public static uint MakeVariableId(string idstring) => default; // 0x0000000186DFCB50-0x0000000186DFCBE0
		public static int GetClassTypeNumberId<T>() => default;
		public static void ConvertFromInteger<T>(int v, ref T ret) {}
		public static uint ConvertToInteger<T>(T v) => default;
		public static System.Type GetType(string typeName) => default; // 0x0000000186DFBC10-0x0000000186DFBF10
		private static object GetDefaultValue(System.Type t) => default; // 0x0000000186DFAAC0-0x0000000186DFAB50
		public static object FromStringPrimitive(System.Type type, string valueStr) => default; // 0x0000000186DFA1D0-0x0000000186DFAAC0
		public static System.Type GetPrimitiveTypeFromName(string typeName) => default; // 0x0000000186DFB2A0-0x0000000186DFB8B0
		public static System.Type GetElementTypeFromName(string typeName) => default; // 0x0000000186DFAB50-0x0000000186DFAC50
		public static System.Type GetTypeFromName(string typeName) => default; // 0x0000000186DFB990-0x0000000186DFBC10
		public static System.Type GetTypeFromName(string typeName, ref bool bIsArrayType) => default; // 0x0000000186DFB8B0-0x0000000186DFB990
		public static string GetNativeTypeName(string typeName) => default; // 0x0000000186DFADE0-0x0000000186DFB050
		public static string GetNativeTypeName(System.Type type) => default; // 0x0000000186DFAC50-0x0000000186DFADE0
		public static bool IsStringType(System.Type type) => default; // 0x0000000186DFCAB0-0x0000000186DFCB50
		public static bool IsEnumType(System.Type type) => default; // 0x0000000186DFC6D0-0x0000000186DFC750
		public static bool IsArrayType(System.Type type) => default; // 0x0000000186DFC340-0x0000000186DFC420
		public static bool IsCustomClassType(System.Type type) => default; // 0x0000000186DFC420-0x0000000186DFC580
		public static bool IsCustomStructType(System.Type type) => default; // 0x0000000186DFC580-0x0000000186DFC6D0
		public static bool IsAgentType(System.Type type) => default; // 0x0000000186DFC240-0x0000000186DFC340
		public static bool IsGameObjectType(System.Type type) => default; // 0x0000000186DFC750-0x0000000186DFC850
		public static bool IsRefNullType(System.Type type) => default; // 0x0000000186DFC8B0-0x0000000186DFC970
		public static bool IfEquals(object l, object r) => default; // 0x0000000186DFBF10-0x0000000186DFC240
		public static void Clone<T>(ref T o, T c) {}
	}
}
