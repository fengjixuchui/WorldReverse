/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 9222
	{
		// Constructors
		public fsIEnumerableConverter() {} // 0x000000018659B800-0x000000018659B860
	
		// Methods
		// [XID] // 0x0000000189610410-0x0000000189610430
		public override bool CanProcess(System.Type type) => default; // 0x000000018659A3D0-0x000000018659A4F0
		// [XID] // 0x0000000189874CB0-0x0000000189874CD0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018659A4F0-0x000000018659A5F0
		// [XID] // 0x000000018963D350-0x000000018963D370
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018659B340-0x000000018659B770
		// [XID] // 0x0000000189883850-0x0000000189883870
		private bool IsStack(System.Type type) => default; // 0x000000018659AA80-0x000000018659ABB0
		// [XID] // 0x0000000189688720-0x0000000189688740
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x000000018659ACA0-0x000000018659B1F0
		// [XID] // 0x0000000189892420-0x0000000189892440
		private static int HintSize(IEnumerable collection) => default; // 0x000000018659A960-0x000000018659AA80
		// [XID] // 0x0000000189899EB0-0x0000000189899ED0
		private static System.Type GetElementType(System.Type objectType) => default; // 0x000000018659A7D0-0x000000018659A960
		// [XID] // 0x00000001898A10E0-0x00000001898A1100
		private static void TryClear(System.Type type, object instance) {} // 0x000000018659ABB0-0x000000018659ACA0
		// [XID] // 0x00000001896D2200-0x00000001896D2220
		private static int TryGetExistingSize(System.Type type, object instance) => default; // 0x000000018659B1F0-0x000000018659B340
		// [XID] // 0x00000001898B0260-0x00000001898B0280
		private static MethodInfo GetAddMethod(System.Type type) => default; // 0x000000018659A5F0-0x000000018659A7D0
	}
}
