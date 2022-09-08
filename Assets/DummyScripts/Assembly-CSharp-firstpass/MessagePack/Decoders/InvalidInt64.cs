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
	internal class InvalidInt64 : IInt64Decoder // TypeDefIndex: 8351
	{
		// Fields
		internal static readonly IInt64Decoder Instance; // 0x00
	
		// Constructors
		private InvalidInt64() {} // 0x00000001856D3FC0-0x00000001856D4020
		static InvalidInt64() {} // 0x00000001856D3F00-0x00000001856D3FC0
	
		// Methods
		// [XID] // 0x0000000189788980-0x00000001897889A0
		public long Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D3D30-0x00000001856D3F00
	}
}
