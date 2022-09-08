/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public class fiRuntimeReflectionUtility // TypeDefIndex: 5004
	{
		// Fields
		private static List<Assembly> _cachedRuntimeAssemblies; // 0x00
		private static List<Assembly> _cachedUserDefinedEditorAssemblies; // 0x08
	
		// Constructors
		public fiRuntimeReflectionUtility() {} // Dummy constructor
	
		// Methods
		public static void InvokeMethod(System.Type type, string methodName, object thisInstance, object[] parameters) {} // 0x0000000185D016C0-0x0000000185D01780
		public static IEnumerable<TInterface> GetAssemblyInstances<TInterface>() => default;
		private static string GetName(Assembly assembly) => default; // 0x0000000185D00CD0-0x0000000185D00DB0
		public static IEnumerable<Assembly> GetRuntimeAssemblies() => default; // 0x0000000185D00DB0-0x0000000185D01290
		public static IEnumerable<Assembly> GetUserDefinedEditorAssemblies() => default; // 0x0000000185D01290-0x0000000185D016C0
		private static bool IsUnityEditorAssembly(Assembly assembly) => default; // 0x0000000185D02A80-0x0000000185D02BE0
		private static bool IsBannedAssembly(Assembly assembly) => default; // 0x0000000185D01780-0x0000000185D02A80
		public static IEnumerable<System.Type> AllSimpleTypesDerivingFrom(System.Type baseType) => default; // 0x0000000185D00810-0x0000000185D00CD0
	}
}
