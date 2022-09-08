/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public static class fiISerializedObjectUtility // TypeDefIndex: 4982
	{
		// Methods
		private static bool SaveStateForProperty(ISerializedObject obj, InspectedProperty property, BaseSerializer serializer, ISerializationOperator serializationOperator, out string serializedValue, ref bool success) {
			serializedValue = default;
			return default;
		} // 0x0000000185CFE330-0x0000000185CFE680
		public static bool SaveState<TSerializer>(ISerializedObject obj)
			where TSerializer : BaseSerializer => default;
		private static bool AreListsDifferent(IList<string> a, IList<string> b) => default; // 0x0000000185CFDDC0-0x0000000185CFDF20
		private static bool AreListsDifferent(IList<UnityEngine.Object> a, IList<UnityEngine.Object> b) => default; // 0x0000000185CFDF20-0x0000000185CFE040
		public static bool RestoreState<TSerializer>(ISerializedObject obj)
			where TSerializer : BaseSerializer => default;
		private static void InstantiateReferences(object obj, InspectedType metadata) {} // 0x0000000185CFE040-0x0000000185CFE330
	}
}
