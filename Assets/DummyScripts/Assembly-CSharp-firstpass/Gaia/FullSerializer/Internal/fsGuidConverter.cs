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
	public class fsGuidConverter : fsConverter // TypeDefIndex: 9221
	{
		// Constructors
		public fsGuidConverter() {} // 0x000000018659A370-0x000000018659A3D0
	
		// Methods
		// [XID] // 0x0000000189BA23D0-0x0000000189BA23F0
		public override bool CanProcess(System.Type type) => default; // 0x0000000186599B10-0x0000000186599C00
		// [XID] // 0x0000000189BB10F0-0x0000000189BB1110
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000186599CF0-0x0000000186599DA0
		// [XID] // 0x0000000189BBF950-0x0000000189BBF970
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000186599DA0-0x0000000186599E50
		// [XID] // 0x0000000189857690-0x00000001898576B0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018659A020-0x000000018659A1E0
		// [XID] // 0x000000018985E850-0x000000018985E870
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000186599E50-0x000000018659A020
		// [XID] // 0x00000001895F2170-0x00000001895F2190
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186599C00-0x0000000186599CF0
	}
}
