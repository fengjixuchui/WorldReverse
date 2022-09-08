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
	public class fsArrayConverter : fsConverter // TypeDefIndex: 9215
	{
		// Constructors
		public fsArrayConverter() {} // 0x0000000186B49C20-0x0000000186B49C80
	
		// Methods
		// [XID] // 0x0000000189B14D30-0x0000000189B14D50
		public override bool CanProcess(System.Type type) => default; // 0x0000000186B48E50-0x0000000186B48F10
		// [XID] // 0x0000000189776B20-0x0000000189776B40
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000186B49010-0x0000000186B490C0
		// [XID] // 0x000000018977DFE0-0x000000018977E000
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000186B490C0-0x0000000186B49170
		// [XID] // 0x0000000189A17390-0x0000000189A173B0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000186B49620-0x0000000186B49A90
		// [XID] // 0x0000000189A952F0-0x0000000189A95310
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000186B49170-0x0000000186B49620
		// [XID] // 0x0000000189794360-0x0000000189794380
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186B48F10-0x0000000186B49010
	}
}
