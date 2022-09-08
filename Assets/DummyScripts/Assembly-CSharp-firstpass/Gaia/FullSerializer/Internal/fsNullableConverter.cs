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
	public class fsNullableConverter : fsConverter // TypeDefIndex: 9224
	{
		// Constructors
		public fsNullableConverter() {} // 0x000000018659D840-0x000000018659D8A0
	
		// Methods
		// [XID] // 0x00000001898DD1A0-0x00000001898DD1C0
		public override bool CanProcess(System.Type type) => default; // 0x000000018659D310-0x000000018659D470
		// [XID] // 0x0000000189882AD0-0x0000000189882AF0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018659D670-0x000000018659D7B0
		// [XID] // 0x0000000189723970-0x0000000189723990
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018659D530-0x000000018659D670
		// [XID] // 0x0000000189B850B0-0x0000000189B850D0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018659D470-0x000000018659D530
	}
}
