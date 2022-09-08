/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Decoders
{
	internal class InvalidExtHeader : IExtHeaderDecoder // TypeDefIndex: 8396
	{
		// Fields
		internal static readonly IExtHeaderDecoder Instance; // 0x00
	
		// Constructors
		private InvalidExtHeader() {} // 0x00000001856D33F0-0x00000001856D3450
		static InvalidExtHeader() {} // 0x00000001856D3330-0x00000001856D33F0
	
		// Methods
		// [XID] // 0x00000001898AB600-0x00000001898AB620
		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D3160-0x00000001856D3330
	}
}
