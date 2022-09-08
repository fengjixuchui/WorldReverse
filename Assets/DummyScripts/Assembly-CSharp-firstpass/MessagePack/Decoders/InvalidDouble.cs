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
	internal class InvalidDouble : IDoubleDecoder // TypeDefIndex: 8321
	{
		// Fields
		internal static readonly IDoubleDecoder Instance; // 0x00
	
		// Constructors
		private InvalidDouble() {} // 0x00000001856D3100-0x00000001856D3160
		static InvalidDouble() {} // 0x00000001856D3040-0x00000001856D3100
	
		// Methods
		// [XID] // 0x00000001898602B0-0x00000001898602D0
		public double Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D2E60-0x00000001856D3040
	}
}
