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
	public class fsReflectedConverter : fsConverter // TypeDefIndex: 9226
	{
		// Constructors
		public fsReflectedConverter() {} // 0x00000001865A16B0-0x00000001865A1710
	
		// Methods
		// [XID] // 0x0000000189B58360-0x0000000189B58380
		public override bool CanProcess(System.Type type) => default; // 0x00000001865A0C80-0x00000001865A0DD0
		// [XID] // 0x000000018994DCC0-0x000000018994DCE0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001865A12B0-0x00000001865A1620
		// [XID] // 0x000000018992AB80-0x000000018992ABA0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001865A0ED0-0x00000001865A12B0
		// [XID] // 0x000000018995CBC0-0x000000018995CBE0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001865A0DD0-0x00000001865A0ED0
	}
}
