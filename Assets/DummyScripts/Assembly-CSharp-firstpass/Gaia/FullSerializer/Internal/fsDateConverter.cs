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
	public class fsDateConverter : fsConverter // TypeDefIndex: 9216
	{
		// Fields
		private const string DefaultDateTimeFormatString = "o"; // Metadata: 0x00AE56AC
		private const string DateTimeOffsetFormatString = "o"; // Metadata: 0x00AE56B1
	
		// Properties
		private string DateTimeFormatString { /* [XID] */ /* 0x00000001899DEC70-0x00000001899DEC90 */ get => default; } // 0x0000000186B4EFB0-0x0000000186B4F090 
	
		// Constructors
		public fsDateConverter() {} // 0x0000000186B4EF50-0x0000000186B4EFB0
	
		// Methods
		// [XID] // 0x00000001897A3C70-0x00000001897A3C90
		public override bool CanProcess(System.Type type) => default; // 0x0000000186B4E650-0x0000000186B4E7B0
		// [XID] // 0x00000001897AB000-0x00000001897AB020
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000186B4ECB0-0x0000000186B4EF50
		// [XID] // 0x00000001897B2E00-0x00000001897B2E20
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000186B4E7B0-0x0000000186B4ECB0
	}
}
