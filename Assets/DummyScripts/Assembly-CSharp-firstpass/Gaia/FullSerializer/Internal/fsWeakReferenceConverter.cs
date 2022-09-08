/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 9228
	{
		// Constructors
		public fsWeakReferenceConverter() {} // 0x00000001865A5C30-0x00000001865A6BA0
	
		// Methods
		// [XID] // 0x0000000189991920-0x0000000189991940
		public override bool CanProcess(System.Type type) => default; // 0x00000001865A5070-0x00000001865A5160
		// [XID] // 0x0000000189A8A780-0x0000000189A8A7A0
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001865A5240-0x00000001865A52F0
		// [XID] // 0x00000001899A0D30-0x00000001899A0D50
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001865A52F0-0x00000001865A53A0
		// [XID] // 0x0000000189BD60E0-0x0000000189BD6100
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001865A5790-0x00000001865A5AA0
		// [XID] // 0x0000000189BC7070-0x0000000189BC7090
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001865A53A0-0x00000001865A5790
		// [XID] // 0x00000001899B72A0-0x00000001899B72C0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001865A5160-0x00000001865A5240
	}
}
