/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Decoders
{
	internal class InvalidUInt32 : IUInt32Decoder // TypeDefIndex: 8362
	{
		// Fields
		internal static readonly IUInt32Decoder Instance; // 0x00
	
		// Constructors
		private InvalidUInt32() {} // 0x00000001856D5170-0x00000001856D51D0
		static InvalidUInt32() {} // 0x00000001856D50B0-0x00000001856D5170
	
		// Methods
		// [XID] // 0x000000018999F520-0x000000018999F540
		public uint Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D4EE0-0x00000001856D50B0
	}
}
