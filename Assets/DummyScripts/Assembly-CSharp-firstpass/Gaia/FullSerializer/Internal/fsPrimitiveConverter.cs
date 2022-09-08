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
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 9225
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x00000001865A0C20-0x00000001865A0C80
	
		// Methods
		// [XID] // 0x00000001898FB440-0x00000001898FB460
		public override bool CanProcess(System.Type type) => default; // 0x000000018659F420-0x000000018659F590
		// [XID] // 0x00000001899030F0-0x0000000189903110
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018659F590-0x000000018659F640
		// [XID] // 0x000000018990A6C0-0x000000018990A6E0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018659F640-0x000000018659F6F0
		// [XID] // 0x0000000189912030-0x0000000189912050
		private static bool UseBool(System.Type type) => default; // 0x00000001865A0590-0x00000001865A0670
		// [XID] // 0x0000000189646020-0x0000000189646040
		private static bool UseInt64(System.Type type) => default; // 0x00000001865A07D0-0x00000001865A0A20
		// [XID] // 0x0000000189655000-0x0000000189655020
		private static bool UseUInt64(System.Type type) => default; // 0x00000001865A0B40-0x00000001865A0C20
		// [XID] // 0x0000000189B8D790-0x0000000189B8D7B0
		private static bool UseDouble(System.Type type) => default; // 0x00000001865A0670-0x00000001865A07D0
		// [XID] // 0x000000018992FF30-0x000000018992FF50
		private static bool UseString(System.Type type) => default; // 0x00000001865A0A20-0x00000001865A0B40
		// [XID] // 0x00000001899374D0-0x00000001899374F0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018659FE00-0x00000001865A0490
		// [XID] // 0x000000018993EFA0-0x000000018993EFC0
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x000000018659F6F0-0x000000018659FE00
	}
}
