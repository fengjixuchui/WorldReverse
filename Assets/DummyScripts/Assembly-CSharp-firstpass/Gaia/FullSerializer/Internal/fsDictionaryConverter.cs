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
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 9217
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x0000000186B50A80-0x0000000186B50AE0
	
		// Methods
		// [XID] // 0x0000000189686AB0-0x0000000189686AD0
		public override bool CanProcess(System.Type type) => default; // 0x0000000186B4F4F0-0x0000000186B4F5F0
		// [XID] // 0x00000001897C2680-0x00000001897C26A0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186B4F5F0-0x0000000186B4F6F0
		// [XID] // 0x00000001897C9DE0-0x00000001897C9E00
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x0000000186B4F8B0-0x0000000186B50320
		// [XID] // 0x00000001897D14E0-0x00000001897D1500
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000186B50320-0x0000000186B509F0
		// [XID] // 0x0000000189A217D0-0x0000000189A217F0
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value) => default; // 0x0000000186B4F090-0x0000000186B4F4F0
		// [XID] // 0x0000000189B520A0-0x0000000189B520C0
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType) {
			keyStorageType = default;
			valueStorageType = default;
		} // 0x0000000186B4F6F0-0x0000000186B4F8B0
	}
}
