/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 4746
	{
		// Constructors
		public fsIEnumerableConverter() {} // 0x0000000188DD4910-0x0000000188DD4970
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD3520-0x0000000188DD3600
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD3600-0x0000000188DD36C0
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD4400-0x0000000188DD4910
		private bool IsStack(System.Type type) => default; // 0x0000000188DD3A90-0x0000000188DD3C20
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x0000000188DD3CD0-0x0000000188DD4300
		private static int HintSize(IEnumerable collection) => default; // 0x0000000188DD39B0-0x0000000188DD3A90
		private static System.Type GetElementType(System.Type objectType) => default; // 0x0000000188DD3860-0x0000000188DD39B0
		private static void TryClear(System.Type type, object instance) {} // 0x0000000188DD3C20-0x0000000188DD3CD0
		private static int TryGetExistingSize(System.Type type, object instance) => default; // 0x0000000188DD4300-0x0000000188DD4400
		private static MethodInfo GetAddMethod(System.Type type) => default; // 0x0000000188DD36C0-0x0000000188DD3860
	}
}
