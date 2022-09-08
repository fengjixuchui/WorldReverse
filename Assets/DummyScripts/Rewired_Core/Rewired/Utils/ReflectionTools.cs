/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	public static class ReflectionTools // TypeDefIndex: 4381
	{
		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum BindingFlags // TypeDefIndex: 4382
		{
			IgnoreCase = 1,
			DeclaredOnly = 2,
			Instance = 4,
			Static = 8,
			Public = 16,
			NonPublic = 32,
			FlattenHierarchy = 64
		}
	
		// Methods
		public static bool IsValueType(System.Type type) => default; // 0x00000001862F21B0-0x00000001862F2230
		public static bool IsEnum(System.Type type) => default; // 0x00000001862F20C0-0x00000001862F2130
		public static System.Type GetUnderlyingEnumType(System.Type enumType) => default; // 0x00000001862F1AF0-0x00000001862F1BE0
		public static bool IsArray(System.Type type) => default; // 0x00000001862F1BE0-0x00000001862F1C60
		public static bool DoesTypeImplement(System.Type type, System.Type baseOrInterfaceType) => default; // 0x00000001862F1690-0x00000001862F1720
		public static bool IsGenericType(System.Type type) => default; // 0x00000001862F2130-0x00000001862F21B0
		public static System.Type[] GetGenericArguments(System.Type type) => default; // 0x00000001862F17B0-0x00000001862F1830
		public static IEnumerable<FieldInfo> GetFields(System.Type type, BindingFlags bindingFlags) => default; // 0x00000001862F1720-0x00000001862F17B0
		public static IEnumerable<PropertyInfo> GetProperties(System.Type type, BindingFlags bindingFlags) => default; // 0x00000001862F18A0-0x00000001862F1930
		public static bool IsDefined(System.Type type, System.Type attributeType, bool inherit) => default; // 0x00000001862F2020-0x00000001862F20C0
		public static T GetAttribute<T>(System.Type type, bool inherit)
			where T : Attribute => default;
		internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase) => default; // 0x00000001862F1C60-0x00000001862F2020
		internal static System.Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = false /* Metadata: 0x00AC4F90 */) => default; // 0x00000001862F1A60-0x00000001862F1AF0
		private static System.Type UzDcEHAnPuPHCBXYooCbdgSVsykk(string param_00009226, bool param_00009227, bool param_00009228 = false /* Metadata: 0x00AC4F91 */) => default; // 0x00000001862F2230-0x00000001862F2390
		internal static System.Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false /* Metadata: 0x00AC4F92 */) => default; // 0x00000001862F1930-0x00000001862F1A60
		public static MethodInfo GetMethodInfo(Delegate @delegate) => default; // 0x00000001862F1830-0x00000001862F18A0
	}
}
