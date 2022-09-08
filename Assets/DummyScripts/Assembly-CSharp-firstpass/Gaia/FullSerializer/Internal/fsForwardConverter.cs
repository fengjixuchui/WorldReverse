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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 9220
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x0000000186599A80-0x0000000186599B10
	
		// Methods
		// [XID] // 0x00000001899C7190-0x00000001899C71B0
		public override bool CanProcess(System.Type type) => default; // 0x0000000186598FB0-0x0000000186599090
		// [XID] // 0x0000000189823CC0-0x0000000189823CE0
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x0000000186599190-0x00000001865994D0
		// [XID] // 0x0000000189A8A800-0x0000000189A8A820
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000186599780-0x00000001865999F0
		// [XID] // 0x000000018989AC10-0x000000018989AC30
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001865994D0-0x0000000186599780
		// [XID] // 0x000000018983A1E0-0x000000018983A200
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000186599090-0x0000000186599190
	}
}
