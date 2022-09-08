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
	internal class InvalidArrayHeader : IArrayHeaderDecoder // TypeDefIndex: 8296
	{
		// Fields
		internal static readonly IArrayHeaderDecoder Instance; // 0x00
	
		// Constructors
		private InvalidArrayHeader() {} // 0x00000001856D2330-0x00000001856D2390
		static InvalidArrayHeader() {} // 0x00000001856D2270-0x00000001856D2330
	
		// Methods
		// [XID] // 0x0000000189B082B0-0x0000000189B082D0
		public uint Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D20A0-0x00000001856D2270
	}
}
