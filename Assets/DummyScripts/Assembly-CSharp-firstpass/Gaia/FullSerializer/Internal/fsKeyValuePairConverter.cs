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
	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 9223
	{
		// Constructors
		public fsKeyValuePairConverter() {} // 0x000000018659C450-0x000000018659C4B0
	
		// Methods
		// [XID] // 0x00000001896E1250-0x00000001896E1270
		public override bool CanProcess(System.Type type) => default; // 0x000000018659B860-0x000000018659B9C0
		// [XID] // 0x00000001899868F0-0x0000000189986910
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018659B9C0-0x000000018659BA70
		// [XID] // 0x0000000189B87980-0x0000000189B879A0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018659BA70-0x000000018659BB20
		// [XID] // 0x00000001897C3210-0x00000001897C3230
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018659BB20-0x000000018659BF60
		// [XID] // 0x00000001898496C0-0x00000001898496E0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018659BF60-0x000000018659C350
	}
}
