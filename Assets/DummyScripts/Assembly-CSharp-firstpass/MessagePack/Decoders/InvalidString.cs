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
	internal class InvalidString : IStringDecoder // TypeDefIndex: 8376
	{
		// Fields
		internal static readonly IStringDecoder Instance; // 0x00
	
		// Constructors
		private InvalidString() {} // 0x00000001856D4B90-0x00000001856D4BF0
		static InvalidString() {} // 0x00000001856D4AD0-0x00000001856D4B90
	
		// Methods
		// [XID] // 0x0000000189826FC0-0x0000000189826FE0
		public string Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D4900-0x00000001856D4AD0
	}
}
