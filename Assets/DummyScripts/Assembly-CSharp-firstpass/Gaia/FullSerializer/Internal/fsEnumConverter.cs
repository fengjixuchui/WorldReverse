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
	public class fsEnumConverter : fsConverter // TypeDefIndex: 9218
	{
		// Constructors
		public fsEnumConverter() {} // 0x0000000186598F50-0x0000000186598FB0
	
		// Methods
		// [XID] // 0x00000001897E7DD0-0x00000001897E7DF0
		public override bool CanProcess(System.Type type) => default; // 0x0000000186598060-0x0000000186598150
		// [XID] // 0x0000000189BD96E0-0x0000000189BD9700
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000186598260-0x0000000186598310
		// [XID] // 0x00000001895EDB50-0x00000001895EDB70
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000186598310-0x00000001865983C0
		// [XID] // 0x0000000189B2B200-0x0000000189B2B220
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186598150-0x0000000186598260
		// [XID] // 0x0000000189917580-0x00000001899175A0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000186598940-0x0000000186598DC0
		// [XID] // 0x000000018980D660-0x000000018980D680
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001865983C0-0x0000000186598940
		private static bool ArrayContains<T>(T[] values, T value) => default;
	}
}
