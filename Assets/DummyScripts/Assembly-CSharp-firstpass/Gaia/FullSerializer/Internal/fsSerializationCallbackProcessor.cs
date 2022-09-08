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
	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 9252
	{
		// Constructors
		public fsSerializationCallbackProcessor() {} // 0x00000001865A2470-0x00000001865A24D0
	
		// Methods
		// [XID] // 0x00000001896C3F00-0x00000001896C3F20
		public override bool CanProcess(System.Type type) => default; // 0x00000001865A1A00-0x00000001865A1B00
		// [XID] // 0x0000000189618270-0x0000000189618290
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x00000001865A2090-0x00000001865A21B0
		// [XID] // 0x000000018961FCF0-0x000000018961FD10
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x00000001865A1C20-0x00000001865A1D60
		// [XID] // 0x0000000189627030-0x0000000189627050
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x00000001865A1D60-0x00000001865A2090
		// [XID] // 0x0000000189A44870-0x0000000189A44890
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x00000001865A1B00-0x00000001865A1C20
	}
}
