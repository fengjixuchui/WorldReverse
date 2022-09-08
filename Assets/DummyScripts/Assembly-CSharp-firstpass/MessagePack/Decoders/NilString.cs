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
	internal class NilString : IStringDecoder // TypeDefIndex: 8371
	{
		// Fields
		internal static readonly IStringDecoder Instance; // 0x00
	
		// Constructors
		private NilString() {} // 0x00000001856E61B0-0x00000001856E6210
		static NilString() {} // 0x00000001856E60F0-0x00000001856E61B0
	
		// Methods
		// [XID] // 0x0000000189971220-0x0000000189971240
		public string Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E6000-0x00000001856E60F0
	}
}
