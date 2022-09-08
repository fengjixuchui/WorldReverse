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
	public class fsTypeConverter : fsConverter // TypeDefIndex: 9227
	{
		// Constructors
		public fsTypeConverter() {} // 0x00000001865A3270-0x00000001865A32D0
	
		// Methods
		// [XID] // 0x000000018986B400-0x000000018986B420
		public override bool CanProcess(System.Type type) => default; // 0x00000001865A2A10-0x00000001865A2B10
		// [XID] // 0x0000000189BB1920-0x0000000189BB1940
		public override bool RequestCycleSupport(System.Type type) => default; // 0x00000001865A2BD0-0x00000001865A2C80
		// [XID] // 0x00000001899C7110-0x00000001899C7130
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x00000001865A2C80-0x00000001865A2D30
		// [XID] // 0x000000018997ADB0-0x000000018997ADD0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001865A2F50-0x00000001865A30E0
		// [XID] // 0x0000000189948760-0x0000000189948780
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001865A2D30-0x00000001865A2F50
		// [XID] // 0x00000001896D2930-0x00000001896D2950
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001865A2B10-0x00000001865A2BD0
	}
}
