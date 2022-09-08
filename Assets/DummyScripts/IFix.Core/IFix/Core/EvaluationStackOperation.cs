/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	internal static class EvaluationStackOperation // TypeDefIndex: 5060
	{
		// Methods
		internal static unsafe void UnboxPrimitive(Value* evaluationStackPointer, object obj, System.Type type) {} // 0x0000000189412890-0x0000000189412EC0
		internal static object mGet(bool isArray, object root, int layer, int[] fieldIdList, FieldInfo[] fieldInfos) => default; // 0x00000001894132B0-0x00000001894134D0
		internal static void mSet(bool isArray, object root, object val, int layer, int[] fieldIdList, FieldInfo[] fieldInfos) {} // 0x00000001894134D0-0x0000000189413740
		internal static unsafe object ToObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone = true /* Metadata: 0x00ADAA5B */) => default; // 0x0000000189411CF0-0x0000000189412890
		public static unsafe void PushObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, System.Type type) {} // 0x00000001894119B0-0x0000000189411CF0
		public static unsafe void UpdateReference(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x0000000189412EC0-0x00000001894132B0
	}
}
