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
	internal class InvalidDateTime : IDateTimeDecoder // TypeDefIndex: 8401
	{
		// Fields
		internal static readonly IDateTimeDecoder Instance; // 0x00
	
		// Constructors
		private InvalidDateTime() {} // 0x00000001856D2E00-0x00000001856D2E60
		static InvalidDateTime() {} // 0x00000001856D2D40-0x00000001856D2E00
	
		// Methods
		// [XID] // 0x00000001898B1810-0x00000001898B1830
		public DateTime Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D2B60-0x00000001856D2D40
	}
}
